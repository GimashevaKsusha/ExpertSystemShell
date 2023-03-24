using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System;

namespace ExpertSystemShell.Model
{
    [Serializable]
    public class Domain
    {
        public string dname { get; set; } //имя домена
        public List<DomainValue> dvalue { get; set; } //список значений домена
        public Domain()
        {
            dvalue = new List<DomainValue>();
        }
        public Domain(Domain domain)
        {
            dname = domain.dname;
            dvalue = new List<DomainValue>();
            foreach(var dom in domain.dvalue)
                dvalue.Add(new DomainValue(dom.value));
        }
        public DomainValue FindDomainValue(string name)
        {
            return dvalue.Find(item => item.value == name);
        }
        public bool CheckReplays(string val) //проверить повторы значений в домене
        {
            return dvalue.Find(item => item.value == val) == null;
        }
    }
}
