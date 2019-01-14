using System;

namespace scratch
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
    static int doubleInteger(int num)
    {
      // num will be an integer. Double it and return it. (ex 12 => 24)
      int res = num * 2;
      return res;
    }

    static bool isNumberEven(int num)
    {
      //num will be an integer. Return true if it’s even, and false if it isn’t.
      return num % 2 == 0;
    }

    static string getFileExtension(string str)
    {
      // str will be a string, but it may not have a file extension.
      // return the file extension (with no period) if it has one, otherwise false
      if (str.Contains('.'))
      {
        var strArray = str.Split('.');
        return strArray[strArray.Length - 1];
      }
      return null;
    }

    static string longestString(string[] arr)
    {
      // arr will be an array. Return the longest string in the array
      string longest = arr[0];
      for (int i = 1; i < arr.Length; i++)
      {
        if (arr[i].Length > longest.Length)
        {
          longest = arr[i];
        }
      }
      return longest;
    }

    static float arraySum(float[] arr)
    {
      //given an array return the sum of all its values
      float total = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        total += arr[i];
      }
      return total;
    }

















    //DO NOT MODIFY
    test.doubleInteger = doubleInteger
    test.isNumberEven = isNumberEven
    test.getFileExtension = getFileExtension
    test.longestString = longestString
    test.arraySum = arraySum


    }
}
