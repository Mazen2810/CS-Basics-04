using System.Xml;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter the Number");
            //bool flag;
            //flag = int.TryParse(Console.ReadLine(),out int Number);
            //if (!flag)
            //{
            //    Console.WriteLine("Wrong Format Try again.");
            //}
            //else
            //{
            //    for (int i = 1; i <= Number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion
            #region Q2:Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            //Console.WriteLine("Enter the Number");
            //bool flag;
            //int Mul;
            //flag = int.TryParse(Console.ReadLine(), out int Number);
            //if (!flag)
            //{
            //    Console.WriteLine("Wrong Format Try again.");
            //}
            //else
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Mul = i * Number;
            //        Console.WriteLine(Mul);
            //    }
            //}

            #endregion

            #region Q3:Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter the Number");
            //bool flag;
            //flag = int.TryParse(Console.ReadLine(), out int Number);
            //if (!flag)
            //{
            //    Console.WriteLine("Wrong Format Try again.");
            //}
            //else
            //{
            //    for (int i = 1; i <= Number; i++)
            //    {
            //        if(i%2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            #endregion

            #region Q4: Write a program that takes two integers then prints the power.
            //Console.WriteLine("enter the number");
            //int Num = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the power number");
            //int pwr = int.Parse(Console.ReadLine());
            //int Result = 1;
            //for (int i = 1; i <= pwr; i++)
            //{
            //    Result = Result * Num;

            //}
            //Console.WriteLine(Result);

            #endregion

            #region Q5:  Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Enter the String");
            //string str = Console.ReadLine();
            //string reversed = "";

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    reversed += str[i];
            //}

            //Console.WriteLine(reversed);
            #endregion

            #region Q6: Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Enter the starting number: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Enter the ending number: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nPrime numbers between {start} and {end}:");

            //for (int n = start; n <= end; n++)
            //{
            //    bool isPrime = true;

            //    if (n <= 1)
            //        isPrime = false;
            //    else if (n == 2)
            //        isPrime = true;
            //    else if (n % 2 == 0)
            //        isPrime = false;
            //    else
            //    {
            //        // Check for divisibility from 3 to sqrt(n)
            //        for (int i = 3; i <= Math.Sqrt(n); i += 2)
            //        {
            //            if (n % i == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(n + " ");
            //    }
            //}
            #endregion

            #region Q7: Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a number to convert : ");
            //int num = int.Parse(Console.ReadLine());
            //string binary = "";

            //while (num > 0)
            //{
            //    binary = (num % 2) + binary;  
            //    num /= 2;
            //}

            //Console.WriteLine($"The Binary is {binary}.\r\n");
            #endregion

            #region Q8: Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nIdentity Matrix of size {n} x {n}:\n");

            //for (int i = 0; i < n; i++)  // Loop through rows
            //{
            //    for (int j = 0; j < n; j++)  // Loop through columns
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Q9: Write C# program that Extract a substring from a given string.
            //Console.Write("Enter the main string: ");
            //string mainString = Console.ReadLine();

            //Console.Write("Enter the starting index: ");
            //int startIndex = int.Parse(Console.ReadLine());

            //Console.Write("Enter the length of substring: ");
            //int length = int.Parse(Console.ReadLine());

            //if (startIndex >= 0 && startIndex < mainString.Length && length > 0 && (startIndex + length) <= mainString.Length)
            //{
            //    string substring = mainString.Substring(startIndex, length);
            //    Console.WriteLine($"\nExtracted Substring: {substring}");
            //}
            //else
            //{
            //    Console.WriteLine("\nInvalid index or length. Please ensure values are within the string range.");
            //}
            #endregion

            #region Q10:  Write C# program that take two string variables and print them as one variable 
            //Console.Write("Enter the first String: ");
            //string str1 = Console.ReadLine();
            //Console.Write("Enter the second String: ");
            //string str2 = Console.ReadLine();

            //string Combinedstr = str1 + str2;

            //Console.WriteLine($"Combined String : {Combinedstr}");
            #endregion

            #region Q11: Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nIdentity Matrix of size {n} x {n}:\n");

            //for (int i = 0; i < n; i++)  // Loop through rows
            //{
            //    for (int j = 0; j < n; j++)  // Loop through columns
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q12: Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //int Sum =0;
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Sum += Numbers[i];
            //}
            //Console.WriteLine(Sum);
            #endregion
            #region Q13: Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = { 1, 2, 3, 4 };
            //int[] arr2 = { 5, 6, 7, 8 };
            //int[] Combinedarr = [8];

            //arr1.CopyTo(Combinedarr, 0);
            //arr2.CopyTo(Combinedarr, arr1.Length);
            //Array.Sort(Combinedarr);


            #endregion
            #region Q14:  Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] array = { 1, 2, 2, 3, 4, 4, 4, 5 };
            //int n = array.Length;
            //bool[] counted = new bool[n];

            //Console.WriteLine("Element Frequencies:");

            //for (int i = 0; i < n; i++)
            //{
            //    if (counted[i])  // Skip if already counted
            //        continue;

            //    int count = 1;  // Count the current element

            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //            counted[j] = true;  // Mark duplicates as counted
            //        }
            //    }

            //    // Print the frequency of the element
            //    Console.WriteLine($"Element {array[i]} occurs {count} times");
            #endregion
            #region Q15:  Write a program in C# Sharp to find maximum and minimum element in an array
            // int[] Numbers = { 1, 2, 3, 4, 5, 12, 43, 12 };
            //int Max = Numbers.Max();
            // int Min = Numbers.Min();
            // Console.WriteLine(Max);
            // Console.WriteLine(Min);
            #endregion
            #region Q16:  Write a program in C# Sharp to find the second largest element in an array.
            //int[] Numbers = { 1, 2, 3, 4, 5, 12, 43, 12 };
            //Array.Sort(Numbers);
            //Array.Reverse(Numbers);
            //int SecLargest = Numbers[1];

            //Console.WriteLine(SecLargest);


            #endregion
            #region  Q17: write a program find the longest distance between Two equal cells.
            //Console.Write("Enter the size of the arrays: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];


            //Console.WriteLine("\nEnter elements for the first array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //int maxDistance = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            int distance = j - i - 1;  
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
            #endregion
            #region Q18: Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //int[,] Arr1 = new int[3, 3];
            //int[,] Arr2 = new int[3, 3];

            //for (int i = 0; i < Arr1.GetLength(0); i++)
            //{

            //    for (int j = 0; j < Arr1.GetLength(1);)
            //    {
            //        bool flag;
            //        Console.Write($"Enter Number of row {i + 1} and coloumn {j + 1} : ");
            //        flag = int.TryParse(Console.ReadLine(), out Arr1[i, j]);

            //        if (flag)
            //        {
            //            j++;
            //        }
            //    }
            //}

            //for (int i = 0; i< Arr2.GetLength(0); i++)
            //{
            //    for(int j = 0;j< Arr2.GetLength(1); j++)
            //    {
            //        Arr2[i, j] = Arr1[i, j];
            //    }
            //}


            //for (int i = 0; i < Arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr2.GetLength(1); j++)
            //    {
            //        Console.WriteLine(Arr2[i, j]);
            //    }
            //}
            #endregion
            #region Q19: Write a Program to Print One Dimensional Array in Reverse Order
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Array.Reverse(Numbers);
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            #endregion


        }
    }
}
