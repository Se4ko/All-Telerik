﻿using System;
using System.Linq;
using System.Diagnostics;
using System.Collections;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Input array is null");
        Debug.Assert(arr.Length != 0, "Input array length is 0");
        Debug.Assert(arr.Length != 1, "Elements in array are only 1!");

        for (int index = 0; index < arr.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array can not be null!");
        Debug.Assert(startIndex >= 0, "Start index can not be negative number!");
        Debug.Assert(endIndex >= 0, "End index can not be negative number!");
        Debug.Assert(endIndex < arr.Length, "End index can not be greater than array length!");
        Debug.Assert(startIndex <= endIndex, "Start index can not be greater than end index!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array can not be null!");
        Debug.Assert(arr.Length != 0, "Array can not be with length 0");
        Debug.Assert(IsArraySorted(arr), "Array is not sorted!");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static bool IsArraySorted<T>(T[] array) where T: IComparable<T>
    {
        bool isSorted = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i].CompareTo(array[i + 1]) > 0)
            {
                isSorted = false;
                break;
            }
        }

        return isSorted;
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array can not be null.");
        Debug.Assert(arr.Length > 0, "Array can not be empty!");
        Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Start index can not be negative number or greater than array length.");
        Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "Енд index can not be negative number or greater than array length.");
        Debug.Assert(startIndex <= endIndex, "Start index can not be greater than end index!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
