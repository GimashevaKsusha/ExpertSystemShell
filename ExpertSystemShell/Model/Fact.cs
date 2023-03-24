using System.DirectoryServices.ActiveDirectory;

namespace ExpertSystemShell.Model
{
    [Serializable]
    public class Fact
    {
        public Variable variable { get; set; } //переменная
        public DomainValue value { get; set; } //значение переменной
        public Fact(Variable variable, DomainValue value)
        {
            this.variable = variable;
            this.value = value;
        }
        public string GetVariableName()
        {
            return variable.vname;
        }
        public string GetInfo()
        {
            return $"{variable.vname} = {value.value}";
        }
    }
}
