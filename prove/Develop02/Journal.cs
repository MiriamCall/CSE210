
class Journal
{
    private List<Entry> _entries = new List<Entry>();

public void AddEntry(Entry entry)
{
    _entries.Add(entry);
}

public Entry GetEntry (Entry entry)
{
    return entry;
}

public void DisplayEntries()
{
    foreach (Entry entry in _entries)
    {
        entry.DisplayEntry();
    }
}
public void SaveJournal()
{

}
public void LoadJournal()
{

}

}