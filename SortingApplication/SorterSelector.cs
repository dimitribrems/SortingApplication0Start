namespace SortingApplication
{
    public class SorterSelector
    {
        public int Sort(SortingAlgorithm algorithm, int[] array)
        {
            BubbleSort bubbleSort = new BubbleSort();
            ShakerSort shakerSort = new ShakerSort();
            QuickSort quickSort = new QuickSort();

            switch (algorithm)
            {
                case SortingAlgorithm.BubbleSort:
                    return bubbleSort.Sort(array);

                case SortingAlgorithm.ShakerSort:
                    return shakerSort.Sort(array);

                case SortingAlgorithm.QuickSort:
                    return quickSort.Sort(array);

                default:
                    return 0;
            }
        }
    }
}