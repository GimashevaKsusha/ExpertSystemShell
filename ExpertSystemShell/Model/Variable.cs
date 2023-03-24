namespace ExpertSystemShell.Model
{
    [Serializable]
    public class Variable
    {
        public string vname { get; set; } //имя переменной
        public Domain vdomain { get; set; } //домен переменной
        public Variable(string vname, Domain vdomain)
        {
            this.vname = vname;
            this.vdomain = vdomain;
        }
        public string GetDomainName() 
        {
            return vdomain.dname;
        }
        public DomainValue GetDomainValue(string name)
        {
            return vdomain.dvalue.Find(item => item.value == name);
        }
    }
}
