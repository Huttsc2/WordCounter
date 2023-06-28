namespace WordCounter
{
    public class WordCounter
    {
        private Dictionary<string, int> Words {  get; set; }

        public WordCounter(List<string> words)
        {
            Words = new();
            foreach (string word in words)
            {
                if (Words.ContainsKey(word))
                {
                    Words[word]++;
                }
                else
                {
                    Words.Add(word, 1);
                }
            }
        }

        public Dictionary<string, int> GetCountedDictionaryOfWords()
        {
            return Words;
        }
    }
}
