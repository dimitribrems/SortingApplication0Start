using System;

namespace SortingApplication
{
    public class SortingAlgorithmTester
    {
        public SorterSelector _selector { get; set; }

        public SortingAlgorithmTester(SorterSelector selector)
        {
            _selector = selector;
        }

        public void Test()
        {
            var values = (SortingAlgorithm[])Enum.GetValues(typeof(SortingAlgorithm));
            foreach (var algorithm in values)
            {
                //swapped = 0;
                int[] array = { 88, 12, 55, 105, 48, 84, 66, 35, 57, 89, 74, 106, 200, 541, 1, 9, 7, 55, 405, 13 };
                int swapped = _selector.Sort(algorithm, array);
                Console.WriteLine($"sorting done using {algorithm}, needed {swapped} swaps to sort the array");
            }
            Console.ReadKey();
        }
    }
}