using System;
using System.Reflection.Metadata;
using System.Text;

namespace task3
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            #region problem 1
            Console.WriteLine("Enter a string to convert to an integer:");
            string userInput = Console.ReadLine();

            // Using int.Parse
            try
            {
                int resultParse = int.Parse(userInput);
                Console.WriteLine($"int.Parse conversion succeeded: {resultParse}");
            }
            catch (FormatException)
            {
                Console.WriteLine("int.Parse failed: Input is not a valid integer format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("int.Parse failed: Input is out of range for an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"int.Parse failed: {ex.Message}");
            }

            // Using Convert.ToInt32
            try
            {
                int resultConvert = Convert.ToInt32(userInput);
                Console.WriteLine($"Convert.ToInt32 conversion succeeded: {resultConvert}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert.ToInt32 failed: Input is not a valid integer format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Convert.ToInt32 failed: Input is out of range for an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Convert.ToInt32 failed: {ex.Message}");
            }
            #endregion

            #region question 1
            //The main difference between int.Parse and Convert.ToInt32 when handling null inputs is how they handle the absence of a value.
            //int.parse:Throws an exception when the input is null,Specifically, it throws a ArgumentNullException.
            //Convert.ToInt32:Returns 0 when the input is null,It does not throw an exception.
            #endregion

            #region problem 2
            Console.WriteLine("Enter a number:");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"You entered: {number}");
            }
            else
            {
                Console.WriteLine("That's not a valid number.");
            }
            #endregion

            #region question 2
            //TryParse is recommended over Parse in user-facing applications because it provides a safer and more user-friendly way to handle invalid inputs. 
            //No Exceptions on Invalid Input,Built-In Validation,Better User Experience,Performance.
            #endregion

            #region problem 3
            object obj;

            obj = 42;
            Console.WriteLine("Value: " + obj + ", HashCode: " + obj.GetHashCode());

            obj = "Hello";
            Console.WriteLine("Value: " + obj + ", HashCode: " + obj.GetHashCode());

            obj = 3.14;
            Console.WriteLine("Value: " + obj + ", HashCode: " + obj.GetHashCode());
            #endregion

            #region question 3
            //The GetHashCode() method is used to generate a hash code for an object in C#. A hash code is an integer value that serves as a quick way to compare objects, particularly in data structures like hash tables, dictionaries, or sets.
            #endregion

            #region problem 4
            Person person1 = new Person();
            person1.Name = "Ziad";

            //Create a second reference to the same object.
            Person person2 = person1;

            // Modify the value of the object using one reference.
            person1.Name = "Mohamed";

          
            Console.WriteLine("person1's name: " + person1.Name);  
            Console.WriteLine("person2's name: " + person2.Name);
            #endregion

            #region question 4
            //Reference equality in .NET refers to the comparison of two object references to determine whether they point to the same memory location
            //This concept is important for understanding how objects are handled in C# and other .NET languages, especially in the context of reference types (like classes, arrays, and delegates) versus value types (like structs and primitive types).
            #endregion

            #region Problem 5
            string myString = "Hello";

            // Print the initial GetHashCode() of the string
            Console.WriteLine("Before modification:");
            Console.WriteLine("HashCode: " + myString.GetHashCode());

            // Modify the string by concatenating additional text
            myString += " Hi Willy";

           
            Console.WriteLine("After modification:");
            Console.WriteLine("HashCode: " + myString.GetHashCode());

            #endregion

            #region question 5
            //In C#, strings are immutable by design. This means that once a string object is created, its value cannot be changed. 
            #endregion

            #region problem 6
            StringBuilder sb = new StringBuilder("Hi Willy");

            // Print the initial GetHashCode() of the StringBuilder instance
            Console.WriteLine("Before modification:");
            Console.WriteLine("HashCode: " + sb.GetHashCode());

            // Modify the StringBuilder by appending text
            sb.Append(" from C#");

            Console.WriteLine("After modification:");
            Console.WriteLine("HashCode: " + sb.GetHashCode());

            Console.WriteLine("Final String: " + sb.ToString());

            #endregion

            #region Question 6
            //StringBuilder addresses the inefficiencies of string concatenation by providing a mutable buffer to which strings can be appended, rather than creating a new string object each time a string is modified
            //some features : Mutability:This avoids the overhead of repeatedly allocating new memory and copying old data.
            //Efficient Memory Management:This dynamic resizing allows StringBuilder to handle string concatenations much more efficiently by reducing the need for memory reallocations and copies as frequently as with regular string concatenation.
            //Better Performance in Loops:For example, appending strings in a loop using StringBuilder is much faster than doing so with the + operator.
            #endregion

            #region Question 7
            //StringBuilder is faster for large-scale string modifications compared to using the + operator or string concatenation because of how it handles memory and string modifications internally. Let's break down the specific reasons why StringBuilder is more efficient in scenarios that involve frequent or large-scale string modifications.
            #endregion

            #region problem 7
            Console.Write("Enter the first number: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int input2 = int.Parse(Console.ReadLine());

            // Calculate the sum
            int sum = input1 + input2;

            // Method 1: Concatenation using + operator
            Console.WriteLine("Sum is " + input1 + "+" + input2 + " = " + sum);

            // Method 2: Composite formatting using string.Format
            Console.WriteLine(string.Format("Sum is {0}+{1} = {2}", input1, input2, sum));

            // Method 3: String interpolation using $
            Console.WriteLine($"Sum is {input1}+{input2} = {sum}");
            #endregion

            #region question 8
            //Among the three string formatting methods in C#, string interpolation ($) is the most commonly used method for string formatting
            //because of Readability,Concise Syntax,Type Safety,Better Performance (in most cases).
            #endregion

            #region problem 8
            StringBuilder sb1 = new StringBuilder("Hello, World!");

            // Append text
            sb.Append(" How are you?");
            Console.WriteLine("After Append: " + sb.ToString());

            // Replace a substring
            sb.Replace("World", "Universe");
            Console.WriteLine("After Replace: " + sb.ToString());

            // Insert a string at a specific position
            sb.Insert(13, " beautiful");
            Console.WriteLine("After Insert: " + sb.ToString());

            // Remove a portion of text
            sb.Remove(13, 10); 
            Console.WriteLine("After Remove: " + sb.ToString());
            #endregion

            #region question 9
            // string is immutable, meaning once a string is created, it cannot be changed. On the other hand, StringBuilder is designed to handle frequent modifications efficiently. The key difference lies in how memory is managed and how modifications are applied to the data.

            #endregion
        }
    }
}
