namespace SortingApplication
{
    internal class ShakerSort : ISort
    {
        public int Sort(int[] array)
        {
            int NumberOfSwaps = 0;
            Swap Swap = new Swap();
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        Swap.ArraySwap(i, i + 1, array);
                        NumberOfSwaps++;
                    }
                }

                if (!swapped) break;

                for (int i = array.Length - 2; i >= 0; --i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        Swap.ArraySwap(i, i + 1, array);
                        NumberOfSwaps++;
                    }
                }
            }
            return NumberOfSwaps;
        }
    }
}