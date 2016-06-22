using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch_iterative_
{
    class Program
    {
        //useless comment
        static void Main(string[] args)
        {
            //nothing much 
            Console.WriteLine("Enter the array size : ");
            int size = Convert.ToInt16(Console.ReadLine());

            int[] myArray = new int[size];

            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < size; i++)
            {
                myArray[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Enter the number you want to search in array: ");
            int search = Convert.ToInt16(Console.ReadLine());

            Array.Sort(myArray);

            Console.WriteLine(".....sorted array.............");
            for (int i = 0; i < size; i++)
            {
                Console.Write(myArray[i].ToString() + "\t");
            }

            Console.WriteLine();


            Console.WriteLine("Found elemnt at: " + (NonRecursivebinarySearch(myArray, size, search)+1));

            Console.ReadLine();


        }

        public static int NonRecursivebinarySearch(int [] A, int itsSize, int key)
        {
            int mid;
            int low = 0;
            int high = itsSize - 1;
            while (low <= high)
            {
                mid = low + ((high - low) / 2);
                if (key == A[mid])
                {
                    return mid;
                }

                else if (key< A[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            }

            return -1;
        }

    }
}
