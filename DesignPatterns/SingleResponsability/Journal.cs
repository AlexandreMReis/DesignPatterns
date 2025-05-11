namespace DesignPatterns.SingleResponsability
{
    public class Journal
    {
        private readonly List<string> _entries = [];
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
}
