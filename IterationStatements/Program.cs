using System.ComponentModel.Design;
using System.Net.Security;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintNumbers999()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static void AreNumbersEqual()
        {
            int num1 = 6;
            int num2 = 5;

            if (num1 == num2)
            {
                Console.WriteLine(true);
            }
            else if (num1 != num2)
            {
                Console.WriteLine(false);
            }
        }
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static void IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("Odd");
            }
        }
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static void IsPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanVote()
        {
            Console.WriteLine("Hello, what is your age?");
            var canParse = int.TryParse(Console.ReadLine(), out int age);
            //int age = int.Parse(Console.ReadLine());

            while (canParse == false)
            {
                Console.WriteLine("Please enter a number and try again.");
                canParse = int.TryParse(Console.ReadLine(), out age);
            }
            
            if (age >= 18)
            {
                Console.WriteLine("You can vote! Choose wisely!");
            }
            else if (age < 18)
            {
                Console.WriteLine("You can not vote! Go get older!");
            }
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static void IsInRange()
        {
            Console.WriteLine("Hello, type a number between -10 and 10.");
            var canParse = int.TryParse(Console.ReadLine(), out int number);

            while (canParse == false)
            {
                Console.WriteLine("Please enter a number and try again.");
                canParse = int.TryParse(Console.ReadLine(), out number);
            }
            
            //int number = int.Parse(Console.ReadLine());

            if (number <= 10 && number >= -10)
            {
                Console.WriteLine($"True! {number} is within 10 and -10.");
            }
            else if (number > 10)
            {
                Console.WriteLine($"False! {number} is greater than 10");
            }
            else if (number < 10)
            {
                Console.WriteLine($"False! {number} is less than -10");
            }
            //else
            {
                Console.WriteLine($"false! {number} is not in the range!");
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplicationTable(int number)
        {
            //Console.WriteLine("Type a number that you would like to see the multiplication table for!");
           // var canParse = int.TryParse(Console.ReadLine(), out int number);

           // while (canParse == false)
            {
                //Console.WriteLine("Please enter a number and try again.");
                //canParse = int.TryParse(Console.ReadLine(), out number);
            }

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i*number}");
            }
            
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //PrintNumbers1000();
            //PrintNumbers999();
            //AreNumbersEqual();
            //IsEven();
            //IsPositive();
            //CanVote();
            //IsInRange();
            //DisplayMultiplicationTable();
        }
    }
}
