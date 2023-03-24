namespace ExpertSystemShell.Model
{
    [Serializable]
    public class RequestedVariable : Variable //запрашиваевая
    {
        public string question { get; set; } //вопрос
        public RequestedVariable(string vname, Domain vdomain, string question) : base(vname, vdomain)
        {
            this.question = question;
        }
    }
}
