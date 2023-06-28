using System.Text.RegularExpressions;

namespace WordCounter
{
    public class ListOfFiles
    {
        private string TargetFolder { get; set; }
        private List<string> FilesInFolder { get; set; }

        public ListOfFiles(string targetFolder)
        {
            TargetFolder = targetFolder;
            FilesInFolder = new List<string>();
            SetFilesInFolder();
        }

        private void SetFilesInFolder()
        {
            string[] files = Directory.GetFiles(TargetFolder);
            foreach (string file in files)
            {
                string pattern = @"[^\\]*\.\w*$";
                string? result = null;

                Match match = Regex.Match(file, pattern);

                if (match.Success)
                {
                    result = match.Value;
                }
                if (result != null)
                {
                    FilesInFolder.Add(result);
                }
            }
        }

        public List<string> GetFilesInFolder()
        {
            return FilesInFolder;
        }
    }
}
