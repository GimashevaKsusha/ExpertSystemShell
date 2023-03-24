using ExpertSystemShell.Model;

namespace ExpertSystemShell
{
    public partial class RuleForm : Form
    {
        private int place;
        private int num;
        private Rule rule = new Rule();
        public RuleForm(int place, int num)
        {
            InitializeComponent();
            lvCond.InsertionMark.Color = Color.DarkCyan;
            this.place = place;
            this.num = num;
            if (num != -1)
            {
                rule = new Rule(Program.shell.kbase.rules[num]);
                rtbName.Text = rule.rname;
                rtbReason.Text = rule.reason;
            }
            else
                rtbName.Text = $"RULE{Program.shell.kbase.rules.Count + 1}";

            LoadDataToListView();
        }

        private void ListViewResizeColumns(ListView lv) //настроить ширину колонок listview
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LoadDataToListView()
        {
            lvCond.Items.Clear();
            foreach(var cond in rule.condition)
            {
                lvCond.Items.Add(cond.GetInfo());
            }

            lvConcl.Items.Clear();

            if (rule.conclusion != null)
            {
                lvConcl.Items.Add(rule.conclusion.GetInfo());
                btnAddConcl.Enabled = false;
            }

            ListViewResizeColumns(lvCond);
            ListViewResizeColumns(lvConcl);
        }

        private void btnAddCond_Click(object sender, EventArgs e) //добавить факт посылки
        {
            var addCond = new FactForm(1)
            {
                Text = "Добавление факта посылки"
            };
            addCond.ShowDialog();

            if (addCond.DialogResult == DialogResult.OK)
            {
                if (addCond.newFact != null && !rule.CheckReplays(addCond.newFact))
                    rule.AddCondition(addCond.newFact);
                else
                    MessageBox.Show("Добавление факта посылки невозможно, так как добавленный факт уже присутствует в посылке", "Ошибка!");
            }

            LoadDataToListView();
        }

        private void btnEditCond_Click(object sender, EventArgs e) //изменить факт посылки
        {
            int index = lvCond.SelectedIndices[0];
            var editCond = new FactForm(1, rule.condition[index])
            {
                Text = "Изменение факта посылки"
            };
            editCond.ShowDialog();

            if (editCond.DialogResult == DialogResult.OK)
            {
                if (editCond.newFact != null && !rule.CheckReplays(editCond.newFact))
                    rule.EditCondition(editCond.newFact, index);
                else
                    MessageBox.Show("Изменение факта посылки невозможно, так как измененный факт уже присутствует в посылке", "Ошибка!");
            }

            lvCond.SelectedItems.Clear();
            LoadDataToListView();
        }

        private void btnDeleteCond_Click(object sender, EventArgs e) //удалить факт посылки
        {
            int index = lvCond.SelectedIndices[0];
            rule.DeleteCondition(index);

            lvCond.SelectedItems.Clear();
            LoadDataToListView();
        }

        private void btnAddConcl_Click(object sender, EventArgs e) //добавить факт заключения
        {
            var addConcl = new FactForm(2)
            {
                Text = "Добавление факта заключения"
            };
            addConcl.ShowDialog();

            if (addConcl.newFact != null)
            {
                rule.AddConclusion(addConcl.newFact);
                btnAddConcl.Enabled = false;
            }

            LoadDataToListView();
        }

        private void btnEditConcl_Click(object sender, EventArgs e) //изменить факт заключения
        {
            var editConcl = new FactForm(2, rule.conclusion)
            {
                Text = "Изменение факта заключения"
            };
            editConcl.ShowDialog();

            if (editConcl.newFact != null)
                rule.EditConclusion(editConcl.newFact);

            lvConcl.SelectedItems.Clear();
            LoadDataToListView();
        }

        private void btnDeleteConcl_Click(object sender, EventArgs e) //удалить факт заключения
        {
            rule.DeleteConclusion();
            btnAddConcl.Enabled = true;

            lvConcl.SelectedItems.Clear();
            LoadDataToListView();
        }

        private void btnSave_Click(object sender, EventArgs e) //сохранить изменения
        {
            if (string.IsNullOrEmpty(rtbName.Text.Trim()))
            {
                MessageBox.Show("Необходимо заполнить имя правила!", "Ошибка!");
                return;
            }

            if (rule.conclusion == null)
            {
                MessageBox.Show("Правило должно содержать факт заключения!", "Ошибка!");
                return;
            }

            if (!Program.shell.kbase.CheckReplaysRule(rtbName.Text.Trim()) && rule.rname != rtbName.Text)
            {
                MessageBox.Show("Правило с указанным именем уже существует!", "Ошибка!");
                return;
            }

            rule.rname = rtbName.Text.Trim();
            rule.reason = rtbReason.Text.Trim();

            if (num == -1)
                Program.shell.kbase.AddRule(rule, place);
            else
                Program.shell.kbase.EditRule(rule, num);

            Close();
        }

        private void btnExit_Click(object sender, EventArgs e) //отменить изменения
        {
            if (MessageBox.Show("Заполненные данные не будут сохранены. " +
                "Вы действительно хотите закрыть форму?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void lvCond_SelectedIndexChanged(object sender, EventArgs e) //настроить доступ кнопок для посылки
        {
            btnEditCond.Enabled = lvCond.SelectedItems.Count == 1;
            btnDeleteCond.Enabled = lvCond.SelectedItems.Count == 1;
            btnAddCond.Enabled = lvCond.SelectedItems.Count != 1;
        }

        private void lvConcl_SelectedIndexChanged(object sender, EventArgs e) //настроить доступ кнопок для заключения
        {
            btnEditConcl.Enabled = lvConcl.SelectedItems.Count == 1;
            btnDeleteConcl.Enabled = lvConcl.SelectedItems.Count == 1;
            btnAddConcl.Enabled = lvConcl.SelectedItems.Count != 1 && rule.conclusion == null;
        }

        private void RuleForm_Resize(object sender, EventArgs e)
        {
            ListViewResizeColumns(lvCond);
            ListViewResizeColumns(lvConcl);
        }

        private void rtbName_Click(object sender, EventArgs e)
        {
            lvCond.SelectedItems.Clear();
            lvConcl.SelectedItems.Clear();
        }

        private void lvCond_Click(object sender, EventArgs e)
        {
            lvConcl.SelectedItems.Clear();
        }

        private void lvConcl_Click(object sender, EventArgs e)
        {
            lvCond.SelectedItems.Clear();
        }

        private void rtbReason_Click(object sender, EventArgs e)
        {
            lvCond.SelectedItems.Clear();
            lvConcl.SelectedItems.Clear();
        }

        private void lvCond_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvCond.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void lvCond_DragDrop(object sender, DragEventArgs e)
        {
            int index = lvCond.InsertionMark.Index;

            if (index == -1) return;
            if (lvCond.InsertionMark.AppearsAfterItem && index != lvCond.Items.Count - 1) index++;

            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            List<string> list = item.Text.Split(" = ").ToList();

            var cond = rule.FindFact(list[0], list[1]);

            lvCond.Items.Remove(item);
            rule.condition.Remove(cond);
            lvCond.Items.Insert(index, item);
            rule.condition.Insert(index,  cond);
            lvCond.SelectedItems.Clear();
        }

        private void lvCond_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void lvCond_DragLeave(object sender, EventArgs e)
        {
            lvCond.InsertionMark.Index = -1;
        }

        private void lvCond_DragOver(object sender, DragEventArgs e)
        {
            Point point = lvCond.PointToClient(new Point(e.X, e.Y));
            int index = lvCond.InsertionMark.NearestIndex(point);
            if (index > -1)
            {
                Rectangle itemBounds = lvCond.GetItemRect(index);
                lvCond.InsertionMark.AppearsAfterItem = point.X > itemBounds.Left + (itemBounds.Width / 2);
            }
            lvCond.InsertionMark.Index = index;
        }
    }
}
