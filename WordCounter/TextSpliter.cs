using System.Text.RegularExpressions;

namespace WordCounter
{
    public class TextSpliter
    {
        private List<string> Words { get; set; }

        public TextSpliter(string text)
        {
            text = text.ToLower();
            text = Regex.Replace(text, @"\d|\W", " ");
            text = Regex.Replace(text, @"\s{1,}", " ");
            text = Regex.Replace(text, @"^\s*|\s*$", "");
            string[] word = text.Split(' ');
            Words = word.ToList();
        }

        public List<string> GetSpilitedText()
        {
            return Words;
        }
    }
}
