using ExpertSystemShell.Model;
using System.DirectoryServices.ActiveDirectory;

namespace ExpertSystemShell
{
    public partial class FactForm : Form
    {
        private int type; //посылка - 1, заключение - 2
        public Fact? newFact { get; set; } //факт посылки или заключения
        public FactForm(int type, Fact fact = null)
        {
            InitializeComponent();
            this.type = type;
            newFact = fact;
            LoadVariable();
            if (newFact != null)
                SetFact();
        }
        private void SetFact()
        {
            int indexVar = cbVar.Items.IndexOf(newFact.variable.vname);
            cbVar.SelectedIndex = indexVar;
            int indexVal = cbVal.Items.IndexOf(newFact.value.value);
            cbVal.SelectedIndex = indexVal;
        }
        private void LoadVariable()
        {
            cbVar.Items.Clear();
            if (type == 1)
            {
                foreach (var variable in Program.shell.kbase.variable)
                {
                    cbVar.Items.Add(variable.vname);
                }
            }

            if (type == 2)
            {
                foreach (var variable in Program.shell.kbase.variable)
                {
                    if (variable is not RequestedVariable)
                        cbVar.Items.Add(variable.vname);
                }
            }

            if (cbVar.Items.Count > 0)
            {
                cbVar.SelectedIndex = 0;
                cbVar.Enabled = true;
                cbVal.Enabled = true;
            }
            else
            {
                cbVar.Enabled = false;
                cbVal.Enabled = false;
            }

            btnSave.Enabled = cbVar.Enabled;
        }

        private void btnAddVar_Click(object sender, EventArgs e) //добавить факт посылки или заключения
        {
            var addVar = new VariableForm(type)
            {
                Text = "Добавление переменной"
            };

            if (addVar.ShowDialog() == DialogResult.OK)
            {
                LoadVariable();
                cbVar.SelectedIndex = cbVar.Items.Count - 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var variable = Program.shell.kbase.FindVariable(cbVar.SelectedItem.ToString());
            var value = variable.GetDomainValue(cbVal.SelectedItem.ToString());
            newFact = new Fact(variable, value);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Заполненные данные не будут сохранены. " +
                "Вы действительно хотите закрыть форму?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void cbVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string varName = cbVar.SelectedItem.ToString();
            var variable = Program.shell.kbase.FindVariable(varName);
            cbVal.Items.Clear();
            foreach (var val in variable.vdomain.dvalue) 
            {
                cbVal.Items.Add(val.value);
            }
            cbVal.SelectedIndex = 0;
        }
    }
}
