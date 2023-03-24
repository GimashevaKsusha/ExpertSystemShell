using System.Runtime.Serialization.Formatters.Binary;

namespace ExpertSystemShell.Model
{
    [Serializable]
    public class KnowledgeBase
    {
        public string kbname { get; set; } //имя базы знаний
        public List<Rule> rules { get; set; } //список правил
        public List<Variable> variable { get; set; } //список переменной
        public List<Domain> domain { get; set; } //список доменов
        public KnowledgeBase() //создание пустой БЗ
        {
            domain = new List<Domain>();
            variable = new List<Variable>();
            rules = new List<Rule>();
        }
        public bool CheckReplaysVariable(string name) //проверить список переменных на повторы
        {
            return variable.Find(item => item.vname == name) == null;
        }
        public bool CheckReplaysDomain(string name) //проверить список доменов на повторы
        {
            return domain.Find(item => item.dname == name) == null;
        }
        public List<Variable> CheckUsedDomain(int index) //проверить, используется ли домен с указанным именем
        {
            string name = domain[index].dname;
            return variable.FindAll(item => item.GetDomainName() == name).ToList();
        }
        public void AddDomain(Domain dom)
        {
            domain.Add(dom);
        }
        public void EditDomain(Domain dom, int index)
        {
            domain[index] = dom;
        }
        public void DeleteDomain(int index)
        {
            domain.RemoveAt(index);
        }
        public Domain FindDomain(string name)
        {
            return domain.Find(item => item.dname == name);
        }
        public void AddVariable(Variable newVar)
        {
            variable.Add(newVar);
        }
        public void EditVariable(Variable newVar, int index)
        {
            variable[index] = newVar;
        }
        public void DeleteVariable(int index)
        {
            variable.RemoveAt(index);
        }
        public List<string> CheckUsedVariable(int index) //проверить, используется ли переменная с указанным именем
        {
            List<string> usedRule = new List<string>();
            string name = variable[index].vname;
            foreach (var rule in rules)
                if (rule.CheckVariable(name))
                    usedRule.Add(rule.rname);

            return usedRule;
        }
        public Variable FindVariable(string name)
        {
            return variable.Find(item => item.vname == name);
        }
        public void AddRule(Rule rule, int index)
        {
            if (index == -1 || index == rules.Count)
                rules.Add(rule);
            else
                rules.Insert(index + 1, rule);
        }
        public void EditRule(Rule rule, int index)
        {
            rules[index] = rule;
        }
        public void DeleteRule(int index)
        {
            rules.RemoveAt(index);
        }
        public bool CheckReplaysRule(string name) //проверить список правил на повторы
        {
            return rules.Find(item => item.rname == name) == null;
        }
        public Rule FindRule(string name)
        {
            return rules.Find(item => item.rname == name);
        }
        public void Serialize(string filepath)
        {
            var formatter = new BinaryFormatter();
            using (var fstream = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var list = new List<object>();
                list.Add(kbname);
                list.Add(rules);
                list.Add(variable);
                list.Add(domain);
                formatter.Serialize(fstream, list);
            }
        }
        public void Deserialize(string filepath)
        {
            var formatter = new BinaryFormatter();
            using (var fstream = File.OpenRead(filepath))
            {
                var list = (List<object>)formatter.Deserialize(fstream);
                kbname = (string)list[0];
                rules = (List<Rule>)list[1];
                variable = (List<Variable>)list[2];
                domain = (List<Domain>)list[3];
            }
        }
    }
}
