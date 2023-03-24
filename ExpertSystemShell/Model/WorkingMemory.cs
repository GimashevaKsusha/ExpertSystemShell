namespace ExpertSystemShell.Model
{
    public class WorkingMemory
    {
        public Variable goal { get; set; }
        public Dictionary<string, Rule> usedRule { get; set; } //список использованных правил
        public List<Fact> usedVar { get; set; } //список использованных переменных
        public Dictionary<string, string> askVar { get; set; } //список запрашиваемых переменных
        public WorkingMemory()
        {
            usedRule = new Dictionary<string, Rule>();
            usedVar = new List<Fact>();
            askVar = new Dictionary<string, string>();
        }
        public void AddUsedRules(Rule rule, Variable goal)
        {
            foreach (var c in rule.condition)
                AddUsedVariable(c);

            if (!usedRule.ContainsKey(goal.vname))
            {
                usedRule.Add(goal.vname, rule);
                AddUsedVariable(rule.conclusion);
            }
        }
        public bool FindUsedVariable(Variable goal)
        {
            return usedVar.Find(item => item.variable.vname == goal.vname) != null;
        }
        public string FindGoalResult()
        {
            if (usedRule.ContainsKey(goal.vname))
                return usedRule[goal.vname].conclusion.value.value;
            else
                return askVar[goal.vname];
        }
        public void AddUsedVariable(Fact fact)
        {
            if (usedVar.Find(item => item.variable.vname == fact.variable.vname && item.value.value == fact.value.value) == null)
                usedVar.Add(fact);
        }
        public void AddAskVariable(string goal, string value)
        {
            askVar.Add(goal, value);
        }
    }
}
