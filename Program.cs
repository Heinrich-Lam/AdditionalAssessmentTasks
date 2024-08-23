using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalAssessmentTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This will demonstrate a Bubble Sort in C#: \n");
                //Creating an integer Array to store the numbers that I want to Sort.
                int[] numbers = { 28, 15, 43, 7, 34, 22, 9 };
                Console.WriteLine("Original Array: ");
                //Calling the method to print the numbers in the console.
                DisplayArray(numbers);

                //Calling my sorting method, I am using Bubble Sort.
                BubbleSort(numbers);
                Console.WriteLine("\nSorted Array: ");
                //Calling the method to print the numbers in the console.
                DisplayArray(numbers);

                Console.WriteLine("\n");
                Console.WriteLine("The following section is to calculate the fatorial of a provided number.");
                //Asking the user to enter a number and then press enter.
                Console.WriteLine("Enter any number that you want to calculate the Factorial for: ");
                //Saving the User input value to my int variable.
                int number = int.Parse(Console.ReadLine());
                //using a long variable to call the Factorial method.
                long result = Factorial(number);
                Console.WriteLine($"The Favtorial of {number} is: {result}");

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }

        }

        static void BubbleSort(int[] array)
        {
            // Creating an int value 'i' to store the length of the array.
            int i = array.Length;

            // Outer loop to iterate over the entire array, reducing the range after each pass.
            for (int j = 0; j < i - 1; j++)
            {
                // Inner loop to compare adjacent elements. The range of this loop reduces as
                // the largest unsorted element is placed at the end of the array after each pass.
                for (int k = 0; k < i - j - 1; k++)
                {
                    // If the current element is greater than the next element,
                    // swap them to order them correctly.
                    if (array[k] > array[k + 1])
                    {
                        // Temporarily store the value of the current element.
                        int temp = array[k];

                        // Assign the next element's value to the current position.
                        array[k] = array[k + 1];

                        // Assign the temporarily stored value to the next position.
                        // This completes the swap.
                        array[k + 1] = temp;
                    }
                }
            }

        }

        static void DisplayArray(int[] array)
        {
            //Looping through all the items in the array and displaying it in the console.
            foreach (var item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }

        static long Factorial(int i)
        {
            // This is because the factorial of 0 (0!) and the factorial of 1 (1!) are both defined to be 1.
            if (i == 0 || i == 1)
            {
                return 1;
            }
            else
            {
                // Recursive case: If 'i' is greater than 1, return 'i' multiplied by the factorial of 'i - 1'.
                return i * Factorial(i - 1);
            }

        }

    }
}
