namespace ExpertSystemShell.Model
{
    [Serializable]
    public class DerivedRequestedVariable : Variable //выводим-запрашиваемая
    {
        public string question { get; set; } //вопрос
        public DerivedRequestedVariable(string vname, Domain vdomain, string question) : base(vname, vdomain)
        {
            this.question = question;
        }
    }
}
