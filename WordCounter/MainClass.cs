namespace WordCounter
{
    public class MainClass
    {
        public static void Main()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Select file to analyze\n");
                new AppRunner().Run();
                Console.WriteLine("\nDo you want to analyze another text? y/n\n");
                string temp = Console.ReadLine();
                if (temp.Contains('y'))
                {
                    Console.Clear();
                } 
                else if (temp.Contains('n'))
                {
                    isRunning = false;
                } 
            }
        }
    }
}
