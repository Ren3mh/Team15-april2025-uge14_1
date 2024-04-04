using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme
{
	public class SorteringsAlgoritmer
	{
        public static void BubbleSort(List<Student> list)
        {
            int n = list.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if ((string.Compare(list[i - 1].FullName, list[i].FullName) < 0)&&(list[i-1].GroupNumber < list[i].GroupNumber))
                    {
                        Student temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            }
            while (swapped);
        }

		public static void SelectionSort(List<Student> list)
        {
			int n = list.Count;
			for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (list[j].GroupNumber < list[minIndex].GroupNumber)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                Student temp = list[minIndex];
                list[minIndex] = list[i];
                list[i] = temp;
                }
            }            
	    }
    }


//// One by one move boundary of unsorted subarray 
//for (int i = 0; i<n - 1; i++)
//{
//    // Find the minimum element in unsorted array 
//    int min_idx = i;
//    for (int j = i + 1; j<n; j++)
//        if (arr[j] < arr[min_idx])
//            min_idx = j;

//    // Swap the found minimum element with the first 
//    // element 
//    int temp = arr[min_idx];
//    arr[min_idx] = arr[i];
//    arr[i] = temp;	
}