using System.Text;

namespace StringBuilderDateType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Lorem ipsum";
            Console.WriteLine(ReverseSrt(word));

        }

        public static string ReverseSrt(string srt)
        {
            string[] words = srt.Split(' ');

            StringBuilder newWord = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    newWord.Append(word[i]); // 
                }
                newWord.Append(' ');    
            }
            return newWord.ToString().Trim();
        }

        public static string ReverseSrt1(string srt)
        {
            string[] words = srt.Split(' ');
            string newWord = string.Empty;

            foreach (string word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    newWord += word[i];
                }
                newWord += " ";
            }
            return newWord.Trim();          
        }
    }
}
