namespace WordCounter
{
    public class FileDisplay
    {
        private List<string> FilesInFolder {  get; set; }
        private string TargetFile { get; set; }

        public FileDisplay(List<string> files)
        {
            FilesInFolder = files;
        }

        public string GetFile()
        {
            DisplayFiles();
            ChooseFile();
            return TargetFile;
        }

        private void DisplayFiles()
        {
            int counter = 1;
            foreach (string file in FilesInFolder)
            {
                Console.WriteLine(counter + " " + file);
                counter++;
            }
            Console.WriteLine();
        }

        private void ChooseFile()
        {
            string key = Console.ReadLine();
            TargetFile = FilesInFolder[int.Parse(key) - 1];
        }
    }
}
