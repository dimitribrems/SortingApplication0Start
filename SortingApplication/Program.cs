namespace SortingApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SorterFactory factory = new SorterFactory();
            SorterSelector sorterSelector = new SorterSelector(factory);
            SortingAlgorithmTester tester = new SortingAlgorithmTester(sorterSelector);
            tester.Test();
        }
    }
}