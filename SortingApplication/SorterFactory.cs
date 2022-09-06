using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    public class SorterFactory
    {
        public ISort CreateSorter(SortingAlgorithm algotithm)
        {
            try
            {
                ISort sorter = (ISort)Activator.CreateInstance(Type.GetType($"SortingApplication.{algotithm}"), new Object[] {});
                return sorter;
            }
            catch(Exception e)
            {
                return new NullSort();
            }
        }
    }
}
