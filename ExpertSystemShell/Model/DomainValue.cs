namespace ExpertSystemShell.Model
{
    [Serializable]
    public class DomainValue
    {
        public string value { get; set; } //значение домена
        public DomainValue(string value)
        {
            this.value = value;
        }
    }
}
