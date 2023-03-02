using System;
/*
Given 2 array, create a function that lets user know
(true/false)
whether this array consist of any common elements

example1:
string[] array1 = {"a", "b","c","d","e"};
string[] array2 = {"x","y","z"};

example2:
string[] array3 = {"a", "b", "x", "d"};
string[] array4 = {"z", "y", "x"};
*/

// function returns bool
// input array

//

/*
class UserDefinedClasses{
   
  public bool CompareArrayElements(string[] arr, string[] ayy) 
  {
    for (int i=0; i < arr.Length; i++)
    {
      for (int j=0; j< ayy.Length; j++)
      {
        if(arr[i] == ayy[j])
           return true;
      }
    }
   return false;
  }
}

class Program
{
   
  public static void Main (string[] args) {
    UserDefinedClasses ub = new UserDefinedClasses();
    string[] array1 = {"a", "b","c","d","e"};
    string[] array2 = {"x","y","z"};

    string[] array3 = {"a", "b", "x", "d"};
    string[] array4 = {"z", "y", "x"};
    Console.WriteLine ("Hello World");
    Console.WriteLine("Compare Array1 & Array2 Elements ");
    bool result = ub.CompareArrayElements(array1 , array2);
    Console.WriteLine("Results are " + result);

    Console.WriteLine("Compare Array3 & Array4 Elements ");
    bool result1 = ub.CompareArrayElements(array3 , array4);
    Console.WriteLine("Results are " + result1);
  }
}



class Program
{
   
public static void Main (string[] args) 
{
int[] tempArr = new int[5];
int[] array1 = {10,20,30,40,50};

 for (int i = 0; i< array1.Length ; i++)
  {
    Console.WriteLine(array1[i]);
  }

 for(int i =0;  i< array1.Length; i++)
  {
    tempArr[i] = array1[i];
  }
  
  for (int i = 0; i< tempArr.Length ; i++)
  {
    Console.WriteLine(tempArr[i]);
  }
  
//             0 1  2  3  4
// reverse the array
//int[] tempArr = new int[5];
  //
 // for (int j = array1.Length - 1; j <= 0 ; j--)
 // {
 //   tempArr = array1[j];
 // }
   
  // for (int k = 0 ; k < tempArr.Length ; k++)
  //  {
  //    Console.WriteLine("Results are " + tempArr[k]);
  //  }
 
  }
}

*/



// C# program to implement Array
/*  Implement Array
 push element 
 pop element
 delete element(index)

*/
/*

class MyArray
{
    int length;
    object[] data;

    MyArray()
    {
        this.length = 0;
        this.data = new object[1];
    }

    public object getArray(int index)
    {
        //Console.WriteLine(data);
        return data[index];

    }

    public object[] pushElement(object item)
    {
         if (this.data.Length == this.length)
          {
           Object[] temp = new Object[this.length];
            // creates a temp array 
           Array.Copy(this.data, temp, length); 
            //copies all data to temp array     
           this.data = new Object[length + 1];
            //increases size of temp array
            Array.Copy(temp, this.data, length);
            }
        this.data[this.length] = item;
        this.length++;
        //Console.WriteLine("Length " + this.length);
        //Console.WriteLine("Data  " + this.data);
        return this.data;

    }

   public object pop()
  {
   object item = this.data[this.length - 1] ;
    item = null;
    this.length --;
    return item;
  }

    public static void Main(string[] args)
    {
        MyArray arr = new MyArray();
        arr.getArray(0);
        arr.pushElement("hi");
        arr.pushElement("Hello");
        arr.pushElement("!");
        arr.pop();

       for(int i= 0; i < arr.length; i++)
      {
        Console.WriteLine(arr.getArray(i));
      }
    }
}
*/

/*
// Array of int {1,3,5,7,8}
// index = start (0), end(3)
// add elements from start to end index
// return sum;

class MyArray
{
public static void Main(string[] args)
 { 
   int[] array1 = {1,3,5,7,8};
           // 0,1,2,3,4
   int sum;
   int startIndex = 0;
   int endIndex = 3; // function rangeofIndex(start , end)
   int temp=0;
    for(int i = startIndex; i <= endIndex; i++) 
     {
         //Console.WriteLine(sum = array1[i] + array1[i+1]); // 1+ 7  
       sum = array1[i] + array1[endIndex];
       Console.WriteLine( "sum " + sum);
       temp = temp + sum;
       Console.WriteLine( "temp " + temp);
       endIndex--;
       
       //startIndex++;
      }
   }
}

*/

/*
// string Reverse without using Reverse()
// string input = Mangesh
// String output = hsegnaM

class Program
{

    public static void Main(String[] args)
    {
        string input = "My Name is Mangesh";
        string output = string.Empty;
        Console.WriteLine("Input is " + input);

        char[] reverse = input.ToCharArray();

        for (int i = reverse.Length - 1; i >= 0; i--)
        {
          //output += reverse[i];
            Console.WriteLine("Reverse String is " + reverse[i]);
        }
        //Console.WriteLine(output);
    }
}
*/

/*
// String examples
// Reverse a string
// input : Hi My Name is Mangesh
// output : hsegnaM si emaN yM iH

class Program
{
public string reverseString(string[] inp)
{
  for (int i = 0 ; i < inp.Length ; i++)
  {
    return(inp[i]); // hi 
    //string[] temp = 
  
  }
 // return inp;

}
public static void Main(string[] args)
{
  string[] input = {"Hi", "My", "Name", "is", "Mangesh"};
  string output;
  output = reverseString(input);
  Console.WriteLine("Reverse String is : " + output);

}

}

*/

/*
class Program
{
    static void Main() {
        string str = "I am Anirban";
        reverseString(str);
    }
    
    static void reverseString(string str){
        string result = string.Empty;
        for(int i = str.Length-1; i>= 0; i--){
            result += str[i];
        }
        
        Console.WriteLine(result);
    }
}

*/

/*

// reverse string using function
// input = "My Name is Mangesh"
// output = "hsegnaM si emaN yM"

class Program
{
   static void ReverseString(string str)
    {
      string output = String.Empty;
      for ( int i= str.Length -1 ; i >= 0; i--)
          {
             output += str[i];
          } 
      Console.WriteLine(output);
    }
  
   public static void Main(string[] args)
  { 
      string input = "My Name is Mangesh";
       ReverseString(input);
    }
 }
*/

/*
// check sum of 2 values in array is equal to target value and return an indexes of it.

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
class Program
{
  public static void Main(string[] args)
 {
   int[] nums = {2,7,11,15};
   //int[] nums = {3,2,4};
   //int[] nums = {3,3};
   int target = 9;
   int startindex = 0;
   int end = 3;
    for(int i = startindex ; i < nums.Length  ; i++) // i = 0
    {
      for (int j = end ; j > startindex  ; j--)
      {
       int sum = nums[i] + nums[j];
       Console.WriteLine("Sum are " + sum);
       if( sum == target)
       {
         //returns(nums[i],nums[j]);
         Console.WriteLine("Values are "+nums[i]+ " and " +nums[j]);
         goto end;
       }
      }
      
    }
    end: 
     Console.WriteLine("End");
  }
}

*/

/*
// Google Question
// 1st recurrance item/element
// given an array1 = [2,5,1,2,3,5,1,2,4];
// it should return 2

// ex2 array2 = [2,1,1,2,3,5,1,2,4];
// return 1

// ex3 array3 = [2,3,4,5];
// return undefined;

//#1 brute force approach using array
using System.Collections;
class Program
{
 public static void Main()
 {

   MyProgram my = new MyProgram();
   
   int[] arr1 = {2,2,5,11,12,3,15,1,7,4};
   int index = my.RecursiveFunctionWithArray(arr1);
    Console.WriteLine("Repeated values in Array are "+ index);

   int key = my.RecursiveFunctionWithHash(arr1);
   Console.WriteLine("Repeated Values in Hash are "+ key);
 }
}
 
 class MyProgram
 {    
   public int RecursiveFunctionWithArray(int[] arr1)
   {
    for (int i=0; i< arr1.Length ; i++)
      {
        for (int j=i+1 ; j < arr1.Length ; j++)
	         {
              if ( arr1[i] == arr1[j])
	             {
                  return (arr1[i]);
	      	     }
            }  
      }
        return 0;
    }
  // using Hashtables
   public int RecursiveFunctionWithHash(int[] arr1)
   {
     Hashtable hash = new Hashtable();

     for (int i=0; i< arr1.Length; i++)
     {
       if(hash.ContainsKey(arr1[i]))
       {
         return arr1[i];
       }
       hash[arr1[i]] = arr1[i];
       
     }
     
     return 0;
   }
}

*/

/*

// check sum of 2 values in array is equal to target value and return an indexes of it.

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].


// using Brute Force with Array

class Program
{
  public static void Main(string[] args)
  {
    int[] nums = {2,17,11,15,2,4,5};
    int target = 9;
    int[] indexes = AdditionOfTwoElements(nums, target);
    for(int i=0; i< indexes.Length; i++)
    {
      Console.WriteLine("indexes " + indexes[i]);
    }    
  }
  static int[] AdditionOfTwoElements(int[] n1, int target)
  {
    for(int i=0; i< n1.Length; i++)
    {
      for(int j = i+1; j< n1.Length; j++)
      {
        if(n1[i] + n1[j] == target)
          return new int[]{i,j};        
      }
    }
    return null;
  }
}

*/

/*
// using Hashtables

using System.Collections;
class Program
{
  public static void Main(string[] args)
  {
    int target = 9;
    int[] nums = {2,17,11,15,2,3,5,4};
    Hashtable hash = new Hashtable();
    for (int i= 0 ; i < nums.Length -1; i++)
    {
      //hash[nums[i]] = nums[i];
      
      if(nums[i]+nums[i+1] == target)
         Console.WriteLine("Found match with Target " + nums[i]);
      else
        hash.Add(nums[i],i);
      //Console.WriteLine(hash[i]);      
    }
    
  }
}

*/


/*
class Program
{
  
public static void Main(string[] args)
{
 string[] input = {"My Name is Mangesh"};
 string output = String.Empty;
 
 for(int i = input.Length -1 ; i > 0; i--)
 {
  output += input[i];
  Console.WriteLine(output);
 
 }

}
}

*/

/*

// Program to find minimum integer among given integers
// input = [4,7,9,1,8,22]
// output = 1

class Program
{
  public static void Main(string[] args)
  {
    int[] inputArr = {4,7,9,1,8,22};
    int output;

    for(int i=0; i<= inputArr.Length -1; i++)
    {
      for(int j=i+1; j<= inputArr.Length -1; j++)
      { 
        if(inputArr[i] < inputArr[j])
          {
            output = inputArr[i];
            Console.WriteLine( output);
           }
        else {
             output = inputArr[j];
             Console.WriteLine( output);
           }
        }
    }
  }
 }


*/

/*
// fibonicci's series

class Program
{
  public static void Main(string[] args)
  {
    int a =0, b=1, length =7;
    int c;
    for (int i = 0; i< length; i++)
    {
      c = a + b;
      Console.WriteLine(" a : {0} b : {1} c : {2} ", a,b,c);
      a = b;
      b = c;
     
    }   
  }  
}

*/

// Swap 2 int numbers using 3rd number

/*
class Program
{
  public static void Main(string[] args)
  {
    int a =20 , b=10;
    int temp;
    if(a > b)  // swap if a is greater
    {
      temp = a; // temp = 20
      a = b; // a = 10
      b = temp; // b = 20
    }
    Console.WriteLine(" a : {0} b : {1} ", a , b);
  }
}
*/

/*
class Program
{
  static int[] FindSmallestNumber(int a, int b)
  {
    if ( a > b)
    {
      int temp = a;
      a = b;
      b = temp;
      
    }
    return new int[] {a,b};
  }
  public static void Main(string[] args)
  {
    int num1 = 50, num2 = 20;
   int[] smallElement = FindSmallestNumber(num1,num2);
    Console.WriteLine($"Before SWapping num1= {num1}, num2 = {num2}");
    

    foreach(int items in smallElement)
      {
      Console.WriteLine(items);
      }
  }
}

*/

/*

// swapping  2 nums without 3rd number

class Program
{
 public static void Main()
  {
    int num1 = 25, num2 = 35;
    Console.WriteLine($"numbers before Swapping num1 : {num1} , num2 : {num2}");
    num1 = num1 + num2;  // 25 + 35 = 60
    num2 = num1 - num2 ; // 60 - 35 = 25
    num1 = num1 - num2; // 60 - 25 = 35
    Console.WriteLine($"numbers after Swapping num1 : {num1}, num2 : {num2}");
    
    string firstName = "Mangesh"; // length = 7
    string lastName = "Deshmane"; // length = 8 

    Console.WriteLine($" Strings before Swapping firstName : {firstName}, lastName : {lastName}");

    firstName = firstName + lastName; // firstName = MangeshDeshmane, length 15
    lastName = firstName.Substring(0, firstName.Length - lastName .Length); 
   // 15 - 8 =7
    firstName = firstName.Substring(lastName.Length); // MangeshDeshmane.substring(7) = Deshmane

    //Console.WriteLine("lengths are {0} {1} ",firstName.Length - lastName.Length,lastName.Length);
    
     Console.WriteLine($" Strings after Swapping firstName : {firstName}, lastName : {lastName}");
  
  }  
}

// prime number

class Program
{
 public static void Main()
 {
   int number;
   int divisor = 0;
   
   Console.WriteLine("Please input the number to find whether it is Prime or Not");
   number = int.Parse(Console.ReadLine());
   
   for(int i = 1; i<= number ; i++)
   {
    if( number % i == 0)
	  divisor++;
   }
   
   if( divisor == 2)
    Console.WriteLine("Number is prime");
   else 
    Console.WriteLine("Number is not prime");
 
 }

}