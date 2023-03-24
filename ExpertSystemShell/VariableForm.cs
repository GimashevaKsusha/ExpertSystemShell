using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using ExpertSystemShell.Model;

namespace ExpertSystemShell
{
    public partial class VariableForm : Form
    {
        private int type;
        //добавление переменной - 0 (любой тип)
        //добавление переменной из посылки - 1 (любой тип)
        //добавление переменной из заключения - 2 (только выводимая или выводимо-запрашиваемая)
        private int edit;
        private Variable variable;
        public VariableForm(int type = 0, int edit = -1)
        {
            InitializeComponent();
            this.type = type;
            this.edit = edit;
            if (edit != -1)
            {
                variable = Program.shell.kbase.variable[edit];
                LoadDomain();
                SetVariable();
            }
            else
            {
                rtbName.Text = $"Variable{Program.shell.kbase.variable.Count + 1}";
                rtbQuestion.Text =  $"{rtbName.Text.Trim()}?";
                LoadDomain();
                CorrectForm();
            }
        }

        private void SetVariable()
        {
            rtbName.Text = variable.vname;
            int index = FindDomainIndex(variable.GetDomainName());
            cbDomain.SelectedIndex = index;
            btnSave.Enabled = true;

            rbR.Checked = variable is RequestedVariable;
            rbD.Checked = variable is DerivedVariable;
            rbDR.Checked = variable is DerivedRequestedVariable;

            if (variable is RequestedVariable)
                rtbQuestion.Text = (variable as RequestedVariable).question;

            if (variable is DerivedRequestedVariable)
                rtbQuestion.Text = (variable as DerivedRequestedVariable).question;
        }

        private int FindDomainIndex(string dom)
        {
            return cbDomain.Items.IndexOf(dom);
        }

        private void LoadDomain()
        {
            cbDomain.Items.Clear();
            foreach(var dom in Program.shell.kbase.domain)
            {
                cbDomain.Items.Add(dom.dname);
            }
            if (cbDomain.Items.Count > 0)
            {
                cbDomain.SelectedIndex = 0;
                cbDomain.Enabled = true;
            }
            else
                cbDomain.Enabled = false;

            btnSave.Enabled = cbDomain.Enabled && !string.IsNullOrEmpty(rtbName.Text);
        }

        public void CorrectForm() //настроить доступ к элементам формы в зависимости от типа
        {
            if (type == 2)
            {
                rbD.Checked = true;
                rbR.Enabled = false;
            }
            else
            {
                rbR.Checked = true;
            }
        }

        private void btnAddDom_Click(object sender, EventArgs e) //добавить домен
        {
            var addDom = new DomainForm()
            {
                Text = "Добавление домена"
            };
            if (addDom.ShowDialog() == DialogResult.OK)
            {
                LoadDomain();
                cbDomain.SelectedIndex = cbDomain.Items.Count - 1;
            }   
        }

        private void btnSave_Click(object sender, EventArgs e) //сохранить изменения
        {

            if (!Program.shell.kbase.CheckReplaysVariable(rtbName.Text.Trim()) && variable.vname != rtbName.Text)
            {
                MessageBox.Show("Переменная с указанным именем уже существует!", "Ошибка!");
                return;
            }

            string question = rtbQuestion.Text.Trim();

            if (string.IsNullOrEmpty(rtbQuestion.Text.Trim()) || rtbQuestion.Text.Trim() == "?")
            {
                MessageBox.Show("Выбранный тип переменной должен содержать не пустой вопрос", "Ошибка!");
                return;
            }

            if (!question.Contains("?"))
                question += "?";

            var dom = Program.shell.kbase.FindDomain(cbDomain.SelectedItem.ToString());

            if (rbR.Checked)
            {
                variable = new RequestedVariable(rtbName.Text.Trim(), dom, question);
            }

            if (rbD.Checked)
            {
                variable = new DerivedVariable(rtbName.Text.Trim(), dom);
            }

            if (rbDR.Checked)
            {
                variable = new DerivedRequestedVariable(rtbName.Text.Trim(), dom, question);
            }

            if (edit == -1)
                Program.shell.kbase.AddVariable(variable);
            else
                Program.shell.kbase.EditVariable(variable, edit);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnExit_Click(object sender, EventArgs e) //отменить изменения
        {
            if (MessageBox.Show("Заполненные данные не будут сохранены. " +
                "Вы действительно хотите закрыть форму?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void rbD_CheckedChanged(object sender, EventArgs e) //настроить доступ к полю "Текст вопроса"
        {
            rtbQuestion.Enabled = !rbD.Checked;
            rtbQuestion.ForeColor = !rbD.Checked ? Color.Black : gbType.BackColor;
        }

        private void rtbName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = cbDomain.Enabled && !string.IsNullOrEmpty(rtbName.Text);
        }
    }
}
