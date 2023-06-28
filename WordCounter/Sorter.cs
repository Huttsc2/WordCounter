namespace WordCounter
{
    public class Sorter
    {

        private List<KeyValuePair<string, int>> SortedDictionary { get; set; }
        private Dictionary<string, int>  UnsortedDictionary { get; set; }

        public Sorter(Dictionary<string, int> unSortedDictionary)
        {
            UnsortedDictionary = unSortedDictionary;
        }

        public void SortByNumbersOfWords()
        {
            SortedDictionary = UnsortedDictionary.OrderBy(x => x.Value).ToList();
            SortedDictionary.Reverse();
        }

        public void SortByAlphabet()
        {
            SortedDictionary = UnsortedDictionary.OrderBy(x => x.Key).ToList();
        }

        public List<KeyValuePair<string, int>> GetSortedByAlphabetDictionary()
        {
            SortByAlphabet();
            return SortedDictionary;
        }

        public List<KeyValuePair<string, int>> GetSortedByNumbersOfWordsDictionary()
        {
            SortByNumbersOfWords();
            return SortedDictionary;
        }

    }
}
