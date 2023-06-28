namespace WordCounter
{
    public class AppRunner
    {
        public void Run()
        {
            string folderPath = new PathFounder().GetTextDirectory();
            List<string> files = new ListOfFiles(folderPath).GetFilesInFolder();
            string file = new FileDisplay(files).GetFile();
            string fullPathToFile = new FullPathToFile(folderPath, file).GetFullPath();
            string textToCount = new TextReader(fullPathToFile).GetText();
            List<string> listOfWords = new TextSpliter(textToCount).GetSpilitedText();
            Dictionary<string, int> countedWords = new WordCounter(listOfWords).GetCountedDictionaryOfWords();
            List<KeyValuePair<string, int>> sortedDictionary = new Sorter(countedWords).GetSortedByNumbersOfWordsDictionary();
            LogWriter logWriter = new(file, sortedDictionary);
            logWriter.WriteLog();
            Console.WriteLine("\nYou can find the parsed text data ");
            Console.WriteLine("in the Log folder in the file - " + logWriter.GetLogFileName());
        }
    }
}
