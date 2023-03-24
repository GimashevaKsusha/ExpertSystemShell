using ExpertSystemShell.Model;

namespace ExpertSystemShell
{
    public partial class MainForm : Form
    {
        private string filepath;
        private bool isSuccess;
        public MainForm()
        {
            InitializeComponent();
            ReloadDataToListView();
            lvRule.InsertionMark.Color = Color.DarkCyan;
        }

        //������������ ������ � ListView
        private void ReloadDataToListView()
        {
            lvDom.Items.Clear();
            foreach (var domain in Program.shell.kbase.domain)
                lvDom.Items.Add(domain.dname);

            lvVar.Items.Clear();
            foreach (var variable in Program.shell.kbase.variable)
            {
                string type = "";
                if (variable is RequestedVariable)
                    type = "�������������";
                if (variable is DerivedVariable)
                    type = "���������";
                if (variable is DerivedRequestedVariable)
                    type = "��������-�������������";
                ListViewItem item = new ListViewItem(new string[]{ variable.vname, type, variable.GetDomainName()});
                lvVar.Items.Add(item);
            }

            lvRule.Items.Clear();
            foreach (var rule in Program.shell.kbase.rules)
            {
                ListViewItem item = new ListViewItem(new string[] { rule.rname, rule.GetDescription() });
                lvRule.Items.Add(item);
            }

            ListViewResizeColumns(lvRule);
            ListViewResizeColumns(lvVar);
            ListViewResizeColumns(lvDom);
            ListViewResizeColumns(lvCondition);
            ListViewResizeColumns(lvConclusion);
            ListViewResizeColumns(lvDomValue);
            ListViewResizeColumns(lvVarValue);
        }

        //����������� ��� ������� Drag&Drop
        private void lvRule_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvRule.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void lvRule_DragDrop(object sender, DragEventArgs e)
        {
            int index = lvRule.InsertionMark.Index;

            if (index == -1) return;

            if (lvRule.InsertionMark.AppearsAfterItem && index != lvRule.Items.Count - 1) index++;

            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            var rule = Program.shell.kbase.FindRule(item.Text);

            lvRule.Items.Remove(item);
            Program.shell.kbase.rules.Remove(rule);
            lvRule.Items.Insert(index, item);
            Program.shell.kbase.rules.Insert(index, rule);
            lvRule.SelectedItems.Clear();
        }

        private void lvRule_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void lvRule_DragLeave(object sender, EventArgs e)
        {
            lvRule.InsertionMark.Index = -1;
        }

        private void lvRule_DragOver(object sender, DragEventArgs e)
        {
            Point point = lvRule.PointToClient(new Point(e.X, e.Y));
            int index = lvRule.InsertionMark.NearestIndex(point);
            if (index > -1)
            {
                Rectangle itemBounds = lvRule.GetItemRect(index);
                lvRule.InsertionMark.AppearsAfterItem = point.X > itemBounds.Left + (itemBounds.Width / 2);
            }
            lvRule.InsertionMark.Index = index;
        }

        private void ListViewResizeColumns(ListView lv) //��������� ������ ������� listview
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnAddRule_Click(object sender, EventArgs e) //�������� �������
        {
            int index = -1;
            if (lvRule.SelectedItems.Count != 0)
                index = lvRule.SelectedIndices[0];

            var addRule = new RuleForm(index, -1)
            {
                Text = "���������� �������"
            };
            addRule.ShowDialog();

            lvRule.SelectedItems.Clear();
            ReloadDataToListView();
        }

        private void btnEditRule_Click(object sender, EventArgs e) //�������� �������
        {
            int index = lvRule.SelectedIndices[0];
            var editRule = new RuleForm(-1, index)
            {
                Text = "��������� �������"
            };
            editRule.ShowDialog();

            lvRule.SelectedItems.Clear();
            ReloadDataToListView();
        }

        private void btnDeleteRule_Click(object sender, EventArgs e) //������� �������
        {
            int index = lvRule.SelectedIndices[0];
            Program.shell.kbase.DeleteRule(index);

            lvRule.SelectedItems.Clear();
            ReloadDataToListView();
        }

        private void btnAddVar_Click(object sender, EventArgs e) //�������� ����������
        {
            var addVar = new VariableForm()
            {
                Text = "���������� ����������"
            };
            addVar.ShowDialog();
            ReloadDataToListView();
        }

        private void btnEditVar_Click(object sender, EventArgs e) //�������� ����������
        {
            //���������, ������������ �� ��������� ����������
            int index = lvVar.SelectedIndices[0];
            var list = Program.shell.kbase.CheckUsedVariable(index);
            if (list.Count == 0)
            {
                var editVar = new VariableForm(0, index)
                {
                    Text = "��������� ����������"
                };
                editVar.ShowDialog();
            }
            else
            {
                string ruleStr = String.Join(", ", list);
                MessageBox.Show($"��������� ��������� ���������� ����������, ��� ��� ��� ������������ � ��������: {ruleStr}", "������!");
            }

            lvVar.SelectedItems.Clear();
            ReloadDataToListView();
        }

        private void btnDeleteVar_Click(object sender, EventArgs e) //������� ����������
        {
            //���������, ������������ �� ��������� ����������
            int index = lvVar.SelectedIndices[0];
            var list = Program.shell.kbase.CheckUsedVariable(index);
            if (list.Count == 0)
                Program.shell.kbase.DeleteVariable(index);
            else
            {
                string ruleStr = String.Join(", ", list);
                MessageBox.Show($"�������� ��������� ���������� ����������, ��� ��� ��� ������������ � ��������: {ruleStr}", "������!");
            }
            

            lvVar.SelectedItems.Clear();
            ReloadDataToListView();
        }

        private void btnAddDom_Click(object sender, EventArgs e) //�������� �����
        {
            var addDom = new DomainForm()
            {
                Text = "���������� ������"
            };
            addDom.ShowDialog();
            ReloadDataToListView();
        }

        private void btnEditDom_Click(object sender, EventArgs e) //�������� �����
        {
            //���������, ������������ �� ��������� �����
            int index = lvDom.SelectedIndices[0];
            var list = Program.shell.kbase.CheckUsedDomain(index);
            if (list.Count == 0)
            {
                var editDom = new DomainForm(index)
                {
                    Text = "��������� ������"
                };
                editDom.ShowDialog();
            }
            else
            {
                string varStr = String.Join(", ", list.Select(item => item.vname));
                MessageBox.Show($"��������� ���������� ������ ����������, ��� ��� �� ������������ � ����������: {varStr}", "������!");
            }
            
            lvDom.SelectedItems.Clear();
            ReloadDataToListView();
        }

        private void btnDeleteDom_Click(object sender, EventArgs e) //������� �����
        {
            //���������, ������������ �� ��������� �����
            int index = lvDom.SelectedIndices[0];
            var list = Program.shell.kbase.CheckUsedDomain(index);
            if (list.Count == 0)
                Program.shell.kbase.DeleteDomain(index);
            else
            {
                string varStr = String.Join(", ", list.Select(item => item.vname));
                MessageBox.Show($"�������� ���������� ������ ����������, ��� ��� �� ������������ � ����������: {varStr}", "������!");
            }
            lvDom.SelectedItems.Clear();
            ReloadDataToListView();
        }

        private void tsmi������������������_Click(object sender, EventArgs e) //������ ������������
        {
            if (Program.shell.kbase.rules.Count == 0)
            {
                MessageBox.Show("���������� �������� ������������, ��� ��� � ���� ������ ��� ������!", "������!");
                return;
            }

            Program.shell.memory = new WorkingMemory();

            var consult = new ConsultationForm();
            consult.ShowDialog();

            isSuccess = consult.DialogResult == DialogResult.OK;
        }

        private void tsmi������������������_Click(object sender, EventArgs e) //�������� ����������
        {
            if (Program.shell.memory.usedRule.Count == 0)
            {
                MessageBox.Show("���������� �������� ������������!", "������!");
                return;
            }
            var reason = new ReasoningForm(isSuccess);
            reason.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) //����������� ������� ������
        {
            if (e.Control && e.KeyCode == Keys.S) //���������
            {
                tsmi���������_Click(sender, e);
                return;
            }

            if (e.Control && e.KeyCode == Keys.O) //�������
            {
                tsmi�������_Click(sender, e);
                return;
            }

            if (e.Control && e.KeyCode == Keys.N) //�����
            {
                tsmi�����_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.F5) //������ ������������
            {
                tsmi������������������_Click(sender, e);
                return;
            }
        }

        private void tsmi�����_Click(object sender, EventArgs e) //����� ��� ������� ���������
        {
            Close();
        }

        private void tsmi�����_Click(object sender, EventArgs e) //����� ����
        {
            filepath = string.Empty;
            Text = "����� ���������� �������";
            Program.shell = new Model.ExpertSystemShell();
            lvRule.SelectedItems.Clear();
            lvVar.SelectedItems.Clear();
            lvDom.SelectedItems.Clear();
            ReloadDataToListView();
        }

        private void tsmi�������_Click(object sender, EventArgs e) //������� ������������ ����
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\gimas\";
                openFileDialog.Filter = "bin files (*.bin)|*.bin";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                filepath = openFileDialog.FileName;
                Program.shell.kbase.kbname = Path.GetFileNameWithoutExtension(filepath);
                Text = Program.shell.kbase.kbname;

                try
                {
                    Program.shell.kbase.Deserialize(filepath);
                    Program.shell.ClearWorkingMemory();
                    lvRule.SelectedItems.Clear();
                    lvVar.SelectedItems.Clear();
                    lvDom.SelectedItems.Clear();
                }
                catch
                {
                    MessageBox.Show("�� ������� ������������ ���� ������ �� �����!", "������!");
                }
            }
            ReloadDataToListView();
        }

        private void tsmi���������_Click(object sender, EventArgs e) //��������� ������� ����
        {
            if (string.IsNullOrEmpty(filepath))
                tsmi������������_Click(sender, e);
            else
            {
                try
                {
                    Program.shell.kbase.Serialize(filepath);
                    MessageBox.Show("���� ��������!", "��������������!");
                }
                catch
                {
                    MessageBox.Show("�� ������� ��������� ����!", "������!");
                    return;
                }
            }
        }

        private void tsmi������������_Click(object sender, EventArgs e) //��������� ���� � ��������� ������� � ��������������
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\Users\gimas\";
                saveFileDialog.Filter = "bin files (*.bin)|*.bin";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                filepath = saveFileDialog.FileName;
                Program.shell.kbase.kbname = Path.GetFileNameWithoutExtension(filepath);
                Text = Program.shell.kbase.kbname;

                try
                {
                    Program.shell.kbase.Serialize(filepath);
                    MessageBox.Show("���� ��������!", "��������������!");
                }
                catch
                {
                    MessageBox.Show("�� ������� ��������� ����!", "������!");
                    return;
                }
            }
        }

        private void lvRule_SelectedIndexChanged(object sender, EventArgs e) //��������� ������ ������� listview � ���������
        {
            btnEditRule.Enabled = lvRule.SelectedItems.Count == 1;
            btnDeleteRule.Enabled = lvRule.SelectedItems.Count == 1;
            if (lvRule.SelectedItems.Count == 1)
            {
                string name = lvRule.SelectedItems[0].Text;
                var rule = Program.shell.kbase.FindRule(name);

                if (rule != null)
                {
                    foreach (var cond in rule.condition)
                        lvCondition.Items.Add(cond.GetInfo());

                    lvConclusion.Items.Add(rule.conclusion.GetInfo());

                    rtbReason.Text = rule.reason;
                }
            }
            else
            {
                lvCondition.Items.Clear();
                lvConclusion.Items.Clear();
                rtbReason.Text = string.Empty;
            }
        }

        private void lvVar_SelectedIndexChanged(object sender, EventArgs e) //��������� ������ ������� listview � �����������
        {
            btnEditVar.Enabled = lvVar.SelectedItems.Count == 1;
            btnDeleteVar.Enabled = lvVar.SelectedItems.Count == 1;
            btnAddVar.Enabled = lvVar.SelectedItems.Count != 1;
            if (lvVar.SelectedItems.Count == 1)
            {
                int index = lvVar.SelectedIndices[0];
                var checkVar = Program.shell.kbase.variable[index];
                if (checkVar is RequestedVariable)
                    rtbQuestion.Text = (checkVar as RequestedVariable).question;
                if (checkVar is DerivedVariable)
                    rtbQuestion.Enabled = false;
                if (checkVar is DerivedRequestedVariable)
                    rtbQuestion.Text = (checkVar as DerivedRequestedVariable).question;

                var values = checkVar.vdomain.dvalue;
                foreach (var val in values)
                {
                    lvVarValue.Items.Add(val.value);
                }
            }
            else
            {
                rtbQuestion.Text = string.Empty;
                rtbQuestion.Enabled = true;
                lvVarValue.Items.Clear();
            }
        }

        private void lvDom_SelectedIndexChanged(object sender, EventArgs e) //��������� ������ ������� listview � ��������
        {    
            btnEditDom.Enabled = lvDom.SelectedItems.Count == 1;
            btnDeleteDom.Enabled = lvDom.SelectedItems.Count == 1;
            btnAddDom.Enabled = lvDom.SelectedItems.Count != 1;
            if (lvDom.SelectedItems.Count == 1)
            {
                int index = lvDom.SelectedIndices[0];
                var values = Program.shell.kbase.domain[index];
                foreach (var val in values.dvalue)
                {
                    lvDomValue.Items.Add(val.value);
                }
            }
            else
            {
                lvDomValue.Items.Clear();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e) //��������� ������ ������� listview ��� ��������� ������� ������
        {
            ListViewResizeColumns(lvRule);
            ListViewResizeColumns(lvVar);
            ListViewResizeColumns(lvDom);
            ListViewResizeColumns(lvCondition);
            ListViewResizeColumns(lvConclusion);
            ListViewResizeColumns(lvDomValue);
            ListViewResizeColumns(lvVarValue);
        }
    }
}