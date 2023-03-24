namespace ExpertSystemShell.Model
{
    public class ExpertSystemShell
    {
        public KnowledgeBase kbase { get; set; }
        public WorkingMemory memory { get; set; }
        public InferenceEngine engine { get; set; }

        public ExpertSystemShell()
        {
            kbase = new KnowledgeBase();
            memory = new WorkingMemory();
            engine = new InferenceEngine();
        }
        public void ClearWorkingMemory()
        {
            memory = new WorkingMemory();
        }
    }
}
