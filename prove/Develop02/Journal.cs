namespace Develop02
{
    public class Journal
    {
        public List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

        public List<Entry> GetEntries()
        {
            return _entries;
        }

        public void StoreEntry(Entry entry)
        {
            if(!_entries.Contains(entry))
            {
                _entries.Add(entry);
            }
        }
    }
}