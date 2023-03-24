using System.Windows.Forms;

namespace ExpertSystemShell.Model
{
    public class InferenceEngine
    {
        public InferenceEngine() { }
        public void StartConsultation(ConsultationForm consult)
        {
            var thread = new Thread(new ParameterizedThreadStart(Consultate));
            thread.IsBackground = true;
            thread.Start(consult);
        }
        public void Consultate(object _consult)
        {
            var consult = (ConsultationForm)_consult;

            if (TryToProve(Program.shell.memory.goal, 0, consult))
            {
                consult.PrintPositiveResult();
            }
            else
            {
                consult.PrintNegativeResult();
            }
        }
        private bool TryToProve(Variable goal, int startIndex, ConsultationForm consult)
        {
            var rules = Program.shell.kbase.rules;

            //пройти по всем правилам
            for(int i = startIndex; i < rules.Count; i++)
            {
                //если в заключении есть целевая переменная, проверить правило
                if (rules[i].conclusion.variable.vname == goal.vname)
                {
                    //попытаться доказать факты посылки правила
                    foreach (var c in rules[i].condition)
                    {
                        if (!TryToProve(c.variable, i, consult))
                            break;
                    }

                    //проверить, доказаны ли все посылки правила
                    if (rules[i].CheckRule(Program.shell.memory.usedVar))
                    {
                        //правило выполняется
                        Program.shell.memory.AddUsedRules(rules[i], goal);
                        return true;
                    }
                }
            }

            if (goal is not DerivedVariable)
            {
                return AskVariable(goal, consult);
            }
            return false;
        }

        private bool AskVariable(Variable goal, ConsultationForm consult)
        {
            if (Program.shell.memory.FindUsedVariable(goal))
                return true;

            consult.PrintQuestion(goal);

            consult.pressed = false;
            while (!consult.pressed)
                Thread.Sleep(200);


            string answer = consult.answer;
            DomainValue value = new DomainValue(answer);
            Program.shell.memory.AddUsedVariable(new Fact(goal, value));
            Program.shell.memory.AddAskVariable(goal.vname, answer);
            return true;
        }
    }
}
