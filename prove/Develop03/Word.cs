public class Word
{
   private string _word;
   private bool _isVisible;

   public Word(string word)
   {
      _word = word;
      _isVisible = true;
   }

   public void Hide()
   {
      _isVisible = false;
   }

   public void Show()
   {
      _isVisible = true;
   }

   public bool IsHidden()
   {
      return _isVisible;
   }

   public string GetRenderedText()
   {
      if (_isVisible == false)
      {
         string blank = "";
         foreach (var letter in _word)
         {
            blank += "_";
         }
         return blank;
      }
      return _word;
   }
}