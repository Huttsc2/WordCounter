namespace WordCounter
{
    public class LogCounter
    {
        private const string CounterFile = "/counter.txt";
        private string CounterFilePath { get; set; }
        private string Counter { get; set; }

        public LogCounter()
        {
            CounterFilePath = new PathFounder().GetCounterDirectory() + CounterFile;
            SetCounter();
            IncreaseCounter();
            RewriteCounter();
        }

        private void SetCounter()
        {
            Counter = new TextReader(CounterFilePath).GetText();
        }

        private void IncreaseCounter()
        {
            Counter = (int.Parse(Counter) + 1).ToString();
        }

        private void RewriteCounter()
        {
            using StreamWriter writer = new(CounterFilePath);
            writer.WriteLine(Counter);
        }

        public string GetCouner()
        {
            return Counter;
        }
    }
}
