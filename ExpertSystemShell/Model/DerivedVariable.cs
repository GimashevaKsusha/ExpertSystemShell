namespace ExpertSystemShell.Model
{
    [Serializable]
    public class DerivedVariable : Variable //выводимая
    {
        public DerivedVariable(string vname, Domain vdomain) : base(vname, vdomain) { }
    }
}
