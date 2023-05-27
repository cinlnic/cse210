public class Reference
{
   private string _book;
   private string _chapter;
   private string _startVerse;
   private string _endVerse;

   public Reference()
   {
      _book = "";
      _chapter = "";
      _startVerse = "";
      _endVerse = "";
   }

   public Reference(string book, string chapter, string startVerse)
   {
      _book = book;
      _chapter = chapter;
      _startVerse = startVerse;
   }

   public Reference(string book, string chapter, string startVerse, string endVerse)
   {
      _book = book;
      _chapter = chapter;
      _startVerse = startVerse;
      _endVerse = endVerse;
   }

   public string GetRenderedText()
   {
      if (string.IsNullOrEmpty(_endVerse))
      {
         return $"{_book} {_chapter}:{_startVerse}";
      }
      return $"{_book} {_chapter}:{_startVerse} - {_endVerse}";
   }
}