using System.Text.RegularExpressions;

namespace WordCounter
{
    public class PathFounder
    {
        private string GetRootDirectory()
        {
            string dir = Directory.GetCurrentDirectory();
            Regex reg = new(".{0,}WordCounter");
            return reg.Match(dir).Captures.First().Value;
        }

        public string GetTextDirectory()
        {
            return GetRootDirectory() + "/Text";
        }

        public string GetLogDirectory()
        {
            return GetRootDirectory() + "/Log";
        }

        public string GetCounterDirectory()
        {
            return GetRootDirectory() + "/Counter";
        }
    }
}
