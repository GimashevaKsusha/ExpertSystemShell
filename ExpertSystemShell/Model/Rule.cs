using System;
using System.Reflection;
using System.Xml.Linq;

namespace ExpertSystemShell.Model
{
    [Serializable]
    public class Rule
    {
        public string rname { get; set; } //имя правила
        public List<Fact> condition { get; set; } //посылка правила
        public Fact conclusion { get; set; } //заключение правила
        public string reason { get; set; } //пояснение правила
        public Rule()
        {
            condition = new List<Fact>();
        }
        public Rule(Rule rule)
        {
            rname = rule.rname;
            reason = rule.reason;
            conclusion = new Fact(rule.conclusion.variable, rule.conclusion.value);
            condition = new List<Fact>();
            foreach(var cond in rule.condition)
                condition.Add(new Fact(cond.variable, cond.value));
        }
        public void AddCondition(Fact fact)
        {
            condition.Add(fact);
        }
        public void EditCondition(Fact fact, int index)
        {
            condition[index] = fact;
        }
        public void DeleteCondition(int index)
        {
            condition.RemoveAt(index);
        }
        public void AddConclusion(Fact fact)
        {
            conclusion = fact;
        }
        public void EditConclusion(Fact fact)
        {
            conclusion = fact;
        }
        public void DeleteConclusion()
        {
            conclusion = null;
        }
        public bool CheckVariable(string name)
        {
            foreach(var fact in condition)
                if (fact.GetVariableName() == name) 
                    return true;

            if (conclusion.GetVariableName() == name)
                return true;

            return false;
        }
        public bool CheckReplays(Fact fact)
        {
            foreach(var cond in condition)
            {
                if (cond.variable.vname == fact.variable.vname && cond.value.value == fact.value.value)
                    return true;
            }
            return false;
        }
        public string GetDescription()
        {
            string cond = string.Empty;

            if (condition.Count > 0)
            {
                for (int i = 0; i < condition.Count - 1; i++)
                    cond += $"{condition[i].GetInfo()} И ";

                cond += $"{condition[condition.Count - 1].GetInfo()}";
            }

            string concl = $"{conclusion.GetInfo()}";

            string description = $"ЕСЛИ {cond}, ТО {concl}";

            return description;
        }
        public string GetCondition()
        {
            string cond = string.Empty;

            if (condition.Count > 0)
            {
                for (int i = 0; i < condition.Count - 1; i++)
                    cond += $"{condition[i].GetInfo()} И ";

                cond += $"{condition[condition.Count - 1].GetInfo()}";
            }

            return cond;
        }
        public Fact FindFact(string name, string value)
        {
            return condition.Find(item => item.variable.vname == name && item.value.value == value);
        }
        public bool CheckRule(List<Fact> facts)
        {
            foreach (var c in condition)
            {
                if (facts.Find(item => item.variable.vname == c.variable.vname && item.value.value == c.value.value) == null)
                    return false;
            }
            return true;
        }
    }
}
