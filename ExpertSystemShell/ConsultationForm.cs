using ExpertSystemShell.Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystemShell
{
    public partial class ConsultationForm : Form
    {
        public string answer { get; set; }
        public bool pressed { get; set; }

        private bool isSuccess;
        private bool isClosed = true;
        public ConsultationForm()
        {
            InitializeComponent();
            SetGoal();
        }

        private void DisableAnswerPanel()
        {
            cbAnswer.Invoke(new Action(() => cbAnswer.Items.Clear()));
            cbAnswer.Invoke(new Action(() => cbAnswer.Enabled = false));
            btnAnswer.Invoke(new Action(() => btnAnswer.Text = "Показать объяснение"));
        }

        public void PrintNegativeResult()
        {
            rtbConsultation.Invoke(new Action(() => rtbConsultation.Text += $"Консультант: К сожалению, цель консультации не удалось достигнуть :(\n\n"));
            rtbConsultation.Invoke(new Action(() => rtbConsultation.SelectionStart = rtbConsultation.Text.Length));
            rtbConsultation.Invoke(new Action(() => rtbConsultation.ScrollToCaret()));
            DisableAnswerPanel();
            isSuccess = false;
            isClosed = false;
        }

        public void PrintPositiveResult()
        {
            rtbConsultation.Invoke(new Action(() => rtbConsultation.Text += $"Консультант: УРА! Цель консультации достигнута!\n\n"));
            rtbConsultation.Invoke(new Action(() => rtbConsultation.Text += 
                $"Консультант: Цель консультации {Program.shell.memory.goal.vname} = {Program.shell.memory.FindGoalResult()}\n\n"));
            rtbConsultation.Invoke(new Action(() => rtbConsultation.SelectionStart = rtbConsultation.Text.Length));
            rtbConsultation.Invoke(new Action(() => rtbConsultation.ScrollToCaret()));
            DisableAnswerPanel();
            isSuccess = true;
            isClosed = false;
        }

        public void SetGoal()
        {
            cbAnswer.Items.Clear();
            foreach (var variable in Program.shell.kbase.variable)
            {
                if (variable is not RequestedVariable)
                    cbAnswer.Items.Add(variable.vname);
            }
            cbAnswer.SelectedIndex = 0;
            rtbConsultation.Text += "Консультант: Выберите цель консультации\n\n";
        }

        private void SetVariable(Variable goal)
        {
            cbAnswer.Invoke(new Action(() => cbAnswer.Items.Clear()));
            foreach (var value in goal.vdomain.dvalue)
            {
                cbAnswer.Invoke(new Action(() => cbAnswer.Items.Add(value.value)));
            }
            cbAnswer.Invoke(new Action(() => cbAnswer.SelectedIndex = 0));
        }

        public void PrintQuestion(Variable goal)
        {
            SetVariable(goal);

            string question = "";
            if (goal is RequestedVariable)
                question = ((RequestedVariable)goal).question;

            if (goal is DerivedRequestedVariable)
                question = ((DerivedRequestedVariable)goal).question;

            rtbConsultation.Invoke(new Action(() => rtbConsultation.Text += $"Консультант: {question}\n\n"));
            rtbConsultation.Invoke(new Action(() => rtbConsultation.SelectionStart = rtbConsultation.Text.Length));
            rtbConsultation.Invoke(new Action(() => rtbConsultation.ScrollToCaret()));
        }

        private void btnAnswer_Click(object sender, EventArgs e) //ответить на вопрос
        {
            if (btnAnswer.Text == "Показать объяснение")
            {
                var reason = new ReasoningForm(isSuccess);
                reason.ShowDialog();
            }
            else
            {
                rtbConsultation.Invoke(new Action(() => rtbConsultation.Text += $"Пользователь: {cbAnswer.SelectedItem}\n\n"));
                rtbConsultation.Invoke(new Action(() => rtbConsultation.SelectionStart = rtbConsultation.Text.Length));
                rtbConsultation.Invoke(new Action(() => rtbConsultation.ScrollToCaret()));

                if (Program.shell.memory.goal == null)
                {
                    Program.shell.memory.goal = Program.shell.kbase.FindVariable(cbAnswer.SelectedItem.ToString());
                    Program.shell.engine.StartConsultation(this);
                }
                else
                {
                    answer = cbAnswer.SelectedItem.ToString();
                    pressed = true;
                }
            }
        }
        private void ConsultationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isSuccess)
            {
                DialogResult = DialogResult.OK;
            }
            if (!isClosed)
            {
                Close();
                return;
            }
            if (MessageBox.Show("Консультация будет завершена " +
                "Вы действительно хотите закрыть форму?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}
