using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Extra_exercises_5___Generic_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Filter filter = new Filter();

            var nums1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10  };
            var nums2 = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            /*List<int> resultat = filter.GetNumbersBeetween5and10(nums1);

            foreach (var number in resultat)
            {
                Console.WriteLine( number);
            }
            

            Console.WriteLine("Högsta: " + filter.GetMaxValue(nums1));
            Console.WriteLine();
            Console.WriteLine("Summa: " + filter.Sum(nums1));

            */

            Console.WriteLine("Fem första: ");
            var count = filter.TakeFive(nums1);
            {
                foreach (var item in count)
                {
                    Console.WriteLine(item);
                }
	
            }


            Console.WriteLine();
            var RemoveDuplicates = filter.RemoveDuplicates(nums1);
            {
                foreach (var item in RemoveDuplicates)
                {
                    Console.WriteLine(item);
                }
	
            }
            Console.WriteLine("----------------");
            Console.WriteLine();
            var getcommon = filter.GetCommon(nums1, nums2);

            foreach (var item in getcommon)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");
            Console.WriteLine();
            var getDiff = filter.GetDifferences(nums1, nums2);

            foreach (var item in getDiff)
            {
                Console.WriteLine(item);
            }

        }

    }
}
