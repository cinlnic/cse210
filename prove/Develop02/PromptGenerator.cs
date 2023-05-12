using System.IO;

public class PromptGenerator
{
   public List<string> prompts;
   Random number = new Random();
   string filename = "prompts.txt";

   public string DisplayPrompt()
   {
      ReadFile();
      int index = number.Next(0, prompts.Count);
      Console.WriteLine(prompts[index]);

      return prompts[index];
   }

   public void AddPrompt(string prompt)
   {
      ReadFile();
      prompts.Add(prompt);

      SaveToFile(prompts);
   }

   private void SaveToFile(List<string> prompts)
   {
      using (StreamWriter outputFile = new StreamWriter(filename))
      {
         foreach (string p in prompts)
         {
            outputFile.WriteLine(p);
         }
      }
   }

   private void ReadFile()
   {
      prompts = new List<string>();

      string[] promptsList = System.IO.File.ReadAllLines(filename);

      foreach (string p in promptsList)
      {
         prompts.Add(p);
      }
   }

}