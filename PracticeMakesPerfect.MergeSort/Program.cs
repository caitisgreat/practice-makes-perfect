using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMakesPerfect.MergeSort
{
    class Program
    {
        public static int[] InitializeIntegerArray()
        {
            System.Console.WriteLine("Please enter a set of integers in any order seperated by commas.");
            string numString = System.Console.ReadLine();

            string[] arrOfNumStrings = numString.Split(',');
            int[] arrOfNumbers = new int[arrOfNumStrings.Count()];
            for (int i = 0; i < arrOfNumStrings.Count(); i++)
            {
                arrOfNumbers[i] = Convert.ToInt32(arrOfNumStrings[i]);
            }

            return arrOfNumbers;
        }

        public static void Merge (int [] numbers, int l, int m, int r)
        {
            int leftSize = m - l + 1;
            int rightSize = r - m;

            // split the parent array into child arrays
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            // copy over elements from the parent array into the child arrays
            for (int a = 0; a < leftSize; a++)
            {
                left[a] = numbers[l + a];
            }
            for (int b = 0; b < rightSize; b++)
            {
                right[b] = numbers[(m + 1 + b)];
            }

            // declare sub array indexes
            int i = 0, j = 0, k = l;

            // evaluate the values
            while (i < leftSize && j < rightSize)
            {
                if(left[i] <= right[j])
                {
                    numbers[k] = left[i];
                    i++;
                }
                else
                {
                    numbers[k] = right[j];
                    j++;
                }
                k++;
            }

            // copy remaining elements from left, if any
            while (i < leftSize)
            {
                numbers[k] = left[i];
                i++;
                k++;
            }

            // copy remaining elements from right, if any
            while (j < rightSize)
            {
                numbers[k] = right[j];
                j++;
                k++;
            }

        }

        public static void Sort(int[] numbers, int l, int r)
        {
            if( l < r ) {
                int middle = (l + (r - l)) / 2;
                Sort(numbers, l, middle);
                Sort(numbers, (middle + 1), r);
                Merge(numbers, l, middle, r);
            }
            
        }
        
        public static void Main(string[] args)
        {
            int[] numbers = InitializeIntegerArray();
            
            Sort(numbers, 0, numbers.Count());
            
            System.Console.ReadLine();
        }
    }
}
