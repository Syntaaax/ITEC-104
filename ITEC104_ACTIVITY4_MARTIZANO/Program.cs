using System;  
public class ArrayProgram 
{  
    public static void Main() 
 {
	int[] arr1 = new int[5];
	int[] arr2 = new int[5];
	int[] arr3 = new int[5];
    int i,j=0,k=0;
	
       Console.WriteLine("\n==ARRAY PROGRAM==\n");
       //Enter number elements
       for(i = 0; i < arr1.Length; i++)
        {
	      Console.Write("Enter element[{0}]: ",i);
    	  arr1[i] = Convert.ToInt32(Console.ReadLine()); 		  
	    }
        
        for(i = 0; i < arr1.Length; i++)
        {
            if (arr1[i]%2 == 0)
            {
                arr2[j] = arr1[i];
                j++;
            }
            else
            {
                arr3[k] = arr1[i];
                k++;
            }
        }
        //Identify Odd Numbers
        Console.Write("\nOdd Numbers: ");
        for(i = 0; i < k; i++)
        {
            Console.Write("{0}, ", arr3[i]);
        }
        //Identify Even Numbers
        Console.Write("\nEven Numbers: ");
        for(i = 0; i < j; i++)
        {
            Console.Write("{0}, ",arr2[i]);
        }	
    }	
 }