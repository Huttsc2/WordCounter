namespace WordCounter
{
    public class LogWriter
    {
        private string PathToLog { get; set; }
        private string LogFileName { get; set; }
        private List<KeyValuePair<string, int>> SortedDictionary { get; set; }

        public LogWriter(string targetFile, List<KeyValuePair<string, int>> sortedDictionary)
        {
            LogFileName = "\\log_"+ new LogCounter().GetCouner() + "_" + targetFile;
            PathToLog = new PathFounder().GetLogDirectory() + LogFileName;
            SortedDictionary = sortedDictionary;
        }

        public void WriteLog()
        {
            using StreamWriter writer = new(PathToLog);
            foreach (KeyValuePair<string, int> line in SortedDictionary)
            {
                writer.WriteLine(line.Key + " - " + line.Value);
            }
        }

        public string GetLogFileName()
        {
            return LogFileName;
        }
    }
}
