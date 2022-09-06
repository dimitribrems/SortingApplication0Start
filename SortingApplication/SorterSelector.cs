namespace SortingApplication
{
    public class SorterSelector
    {
        public int Sort(SortingAlgorithm algorithm, int[] array)
        {
            SorterFactory factory = new SorterFactory();

            ISort sorter = factory.CreateSorter(algorithm);

            return sorter.Sort(array);
        }
    }
}