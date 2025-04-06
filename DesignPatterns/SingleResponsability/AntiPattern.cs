namespace DesignPatterns.SingleResponsability.AntiPattern
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int _count = 0;
        public void AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
        }
        public void RemoveEntry(int index)
        {
            if (index >= 0 && index < _entries.Count)
            {
                _entries.RemoveAt(index);
            }
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }

        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, journal.ToString());
            }
        }
    }

    public class Demo
    {
        public void Execute()
        {
            var journal = new Journal();
            journal.AddEntry("I learned about the Singleton pattern.");
            journal.AddEntry("I learned about the Factory pattern.");
            journal.AddEntry("I learned about the Observer pattern.");
            Console.WriteLine("Journal Entries:");
            Console.WriteLine(journal.ToString());
            string filePath = @"C:\journal.txt";
            journal.SaveToFile(journal, filePath, true);
        }
    }
}
