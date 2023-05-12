

class Journal
{
   public List<Entry> entries = new List<Entry>();

   public void AddEntry(Entry newEntry)
   {
      entries.Add(newEntry);
   }
   public void Display()
   {
      foreach (Entry entry in entries)
      {
         entry.DisplayEntry();
      }
   }

   public void Load(string filename)
   {
      string[] entryData = System.IO.File.ReadAllLines(filename);

      entries = new List<Entry>();

      foreach (string entry in entryData)
      {
         string[] parts = entry.Split("|");

         Entry newEntry = new Entry();
         newEntry.date = parts[0];
         newEntry.prompt = parts[1];
         newEntry.answer = parts[2];

         entries.Add(newEntry);
      }
   }


   public void Save(string filename)
   {

      using (StreamWriter outputFile = new StreamWriter(filename))
      {
         foreach (Entry e in entries)
         {
            outputFile.WriteLine($"{e.date}|{e.prompt}|{e.answer}");
         }
      }

   }
}