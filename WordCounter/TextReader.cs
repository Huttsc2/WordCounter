namespace WordCounter
{
    public class TextReader
    {
        private string PathToFile { get; set; }

        public TextReader(string folder)
        {
            PathToFile = folder;
        }

        public string GetText()
        {
            string text;
            using (StreamReader reader = new(PathToFile))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
    }
}
