using ExpertSystemShell.Model;
using System.Data;

namespace ExpertSystemShell
{
    public partial class DomainForm : Form
    {
        private int edit;
        private Domain domain = new Domain();
        public DomainForm(int edit = -1)
        {
            InitializeComponent();
            if (edit != -1)
            {
                domain = new Domain(Program.shell.kbase.domain[edit]);
                rtbName.Text = domain.dname;
                ReloadDataToListView();
            }
            this.edit = edit;
            lvVal.InsertionMark.Color = Color.DarkCyan;
            ListViewResizeColumns(lvVal);
        }

        //перезагрузка данных в ListView
        private void ReloadDataToListView()
        {
            lvVal.Items.Clear();
            foreach (var val in domain.dvalue)
                lvVal.Items.Add(val.value);
        }

        //обработчики для функции Drag&Drop
        private void lvVal_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvVal.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void ListViewResizeColumns(ListView lv) //настроить ширину колонок listview
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lvVal_DragDrop(object sender, DragEventArgs e)
        {
            int index = lvVal.InsertionMark.Index;

            if (index == -1) return;

            if (lvVal.InsertionMark.AppearsAfterItem && index != lvVal.Items.Count - 1) index++;

            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            var value = domain.FindDomainValue(item.Text);

            lvVal.Items.Remove(item);
            domain.dvalue.Remove(value);
            lvVal.Items.Insert(index, item);
            domain.dvalue.Insert(index, value);

            lvVal.SelectedItems.Clear();
        }

        private void lvVal_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void lvVal_DragLeave(object sender, EventArgs e)
        {
            lvVal.InsertionMark.Index = -1;
        }

        private void lvVal_DragOver(object sender, DragEventArgs e)
        {
            Point point = lvVal.PointToClient(new Point(e.X, e.Y));
            int index = lvVal.InsertionMark.NearestIndex(point);
            if (index > -1)
            {
                Rectangle itemBounds = lvVal.GetItemRect(index);
                lvVal.InsertionMark.AppearsAfterItem = point.X > itemBounds.Left + (itemBounds.Width / 2);
            }
            lvVal.InsertionMark.Index = index;
        }

        private void btnSave_Click(object sender, EventArgs e) //сохранить изменения
        {
            if (string.IsNullOrEmpty(rtbName.Text.Trim()))
            {
                MessageBox.Show("Необходимо заполнить имя домена!", "Ошибка!");
                return;
            }

            if (domain.dvalue.Count == 0)
            {
                MessageBox.Show("Домен должен содержать хотя бы одно значение!", "Ошибка!");
                return;
            }

            if (!Program.shell.kbase.CheckReplaysDomain(rtbName.Text.Trim()) && domain.dname != rtbName.Text)
            {
                MessageBox.Show("Домен с указанным именем уже существует!", "Ошибка!");
                return;
            }

            domain.dname = rtbName.Text.Trim();

            if (edit == -1)
                Program.shell.kbase.AddDomain(domain);
            else
                Program.shell.kbase.EditDomain(domain, edit);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnExit_Click(object sender, EventArgs e) //отменить изменения
        {
            if (MessageBox.Show("Заполненные данные не будут сохранены. " +
                "Вы действительно хотите закрыть форму?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnDeleteVal_Click(object sender, EventArgs e) //удалить значение домена
        {
            domain.dvalue.RemoveAt(lvVal.SelectedIndices[0]);
            lvVal.SelectedItems.Clear();
            ReloadDataToListView();
        }

        private void btnAddVal_Click(object sender, EventArgs e) //добавить значение домена
        {
            if (domain.CheckReplays(rtbVal.Text.Trim()))
            {
                DomainValue val = new DomainValue(rtbVal.Text.Trim());
                domain.dvalue.Add(val);
                ReloadDataToListView();
            }
            else
            {
                MessageBox.Show("Значения домена не могут повторяться", "Ошибка!");
            }
            rtbVal.Text = string.Empty;
        }
        private void btnEditVal_Click(object sender, EventArgs e) //изменить значение домена
        {
            int index = lvVal.SelectedIndices[0];
            if (domain.CheckReplays(rtbVal.Text.Trim()))
            {
                domain.dvalue[index].value = rtbVal.Text.Trim();
                lvVal.SelectedItems.Clear();
                ReloadDataToListView();
            }
            else
            {
                MessageBox.Show("Значения домена не могут повторяться", "Ошибка!");
            }
        }
        private void lvVal_SelectedIndexChanged(object sender, EventArgs e) //настроить доступ кнопок для изменения и удаления
        {
            btnEditVal.Enabled = lvVal.SelectedItems.Count == 1;
            btnDeleteVal.Enabled = lvVal.SelectedItems.Count == 1;
            if (lvVal.SelectedItems.Count == 1) 
                rtbVal.Text = lvVal.SelectedItems[0].Text;
            else
                rtbVal.Text = string.Empty;
        }

        private void rtbVal_TextChanged(object sender, EventArgs e) //настроить доступ кнопок для добавления
        {
            btnAddVal.Enabled = rtbVal.Text.Trim() != "" && !btnEditVal.Enabled;
            btnEditVal.Enabled = rtbVal.Text.Trim() != "" && lvVal.SelectedItems.Count == 1;
        }

        private void DomainForm_Resize(object sender, EventArgs e)
        {
            ListViewResizeColumns(lvVal);
        }

        private void rtbName_Click(object sender, EventArgs e)
        {
            lvVal.SelectedItems.Clear();
        }
    }
}
