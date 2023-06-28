namespace WordCounter
{
    public class FullPathToFile
    {
        private string File { get; set; }

        public FullPathToFile(string path, string file)
        {
            File = path + "/" + file;
        }

        public string GetFullPath()
        {
            return File;
        }
    }
}