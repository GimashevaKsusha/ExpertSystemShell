using ExpertSystemShell.Model;

namespace ExpertSystemShell
{
    internal static class Program
    {
        public static Model.ExpertSystemShell shell = new Model.ExpertSystemShell();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}