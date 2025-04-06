using DesignPatterns.SingleResponsability.Pattern;

namespace DesignPatterns
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
    }

    public class PersistanceManager
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, journal.ToString());
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var singleResponsabilityDemo = new Demo();
            singleResponsabilityDemo.Execute();
        }
    }
}
