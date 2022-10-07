using System;
using System.Collections.Generic;

class List {

    static void Main(string[] args) {

        List<int> myList = test(new List<int> (new int[] {10, 20, 35, 65, 53, 48, 5, 1}));

        Console.WriteLine("10 20 35 65 53 48 5 1");
        foreach(var i in myList)
        {
            Console.Write(i.ToString() + " ");
        }
    }

    public static List<int> test(List<int> nums)
    {
        return nums.Where(n => n % 10 < 5).ToList();
    }
}