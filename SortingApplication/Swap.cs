namespace SortingApplication
{
    public class Swap
    {

        public void ArraySwap(int index1, int index2, int[] array)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}