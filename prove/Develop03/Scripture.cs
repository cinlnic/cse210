public class Scripture
{
   private List<Word> _words = new List<Word>();
   private Reference _reference;
   private Random index = new Random();
   //private List<int> hiddenIndex = new List<int>();
   public Scripture() { }

   public Scripture(Reference reference, string text)
   {
      _reference = reference;

      string[] words = text.Split(" ");
      foreach (string word in words)
      {
         Word newWord = new Word(word);
         _words.Add(newWord);
      }
   }

   public void HideWords()
   {

      for (int i = 0; i < 3; i++)
      {
         int num = index.Next(_words.Count);
         _words[num].Hide();
      }
   }

   public void GetRenderedText()
   {
      string reference = $"{_reference.GetRenderedText()}";
      Console.Write(reference + "  ");

      foreach (Word word in _words)
      {
         Console.Write(word.GetRenderedText() + " ");
      }
   }

   public bool IsCompletelyHidden()
   {
      foreach (Word word in _words)
      {
         if (word.IsHidden())
         {
            return false;
         }
      }
      return true;
   }

}