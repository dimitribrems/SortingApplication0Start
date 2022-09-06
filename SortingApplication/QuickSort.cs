namespace SortingApplication
{
    public class QuickSort
    {
        public int NumberOfSwaps { get; set; } = 0;
        public int Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            return NumberOfSwaps;
        }

        public void Sort(int[] array, int Left, int Right)
        {
            Swap Swap = new Swap();
            int L = Left;
            int R = Right;
            int pivotValue = array[(Left + Right) / 2];

            do
            {
                while (array[L] < pivotValue)
                {
                    L++;
                }
                while (pivotValue < array[R])
                {
                    R--;
                }

                if (L <= R)
                {
                    Swap.ArraySwap(L, R, array);
                    NumberOfSwaps++;
                    L++;
                    R--;
                }
            } while (L < R);

            if (Left < R)
            {
                Sort(array, Left, R);
            }
            if (L < Right)
            {
                Sort(array, L, Right);
            }
        }
    }
}