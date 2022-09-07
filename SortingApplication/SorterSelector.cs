namespace SortingApplication
{
    public class SorterSelector
    {
        public SorterFactory _sorterFactory { get; set; }

        public SorterSelector(SorterFactory sorterFactory)
        {
            _sorterFactory = sorterFactory;
        }

        public int Sort(SortingAlgorithm algorithm, int[] array)
        {
            ISort sorter = _sorterFactory.CreateSorter(algorithm);

            return sorter.Sort(array);
        }
    }
}