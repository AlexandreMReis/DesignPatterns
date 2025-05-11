using System.Diagnostics;

namespace DesignPatterns.SingleResponsability
{
    public class Demo : IDemo
    {
        public void Execute()
        {
            var journal = new Journal();
            var persistance = new PersistanceManager();
            journal.AddEntry("I learned about the Singleton pattern.");
            journal.AddEntry("I learned about the Factory pattern.");
            journal.AddEntry("I learned about the Observer pattern.");
            Console.WriteLine("Journal Entries:");
            Console.WriteLine(journal.ToString());

            string filePath = @"C:\journal.txt";
            persistance.SaveToFile(journal, filePath, true);
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }
    }
}
