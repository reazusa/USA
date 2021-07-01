using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Basic_Programs
    {   //https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-1.php
        public static void printHeloName()
        {   //1. Write a C# Sharp program to print Hello and your name in a separate line.
            Console.WriteLine("Hello \nReaz U Ahmed");
        }

        public static void sumOf2Numbers()
        {   //2. Write a C# Sharp program to print the sum of two numbers
            Console.Write("Enter first number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            Console.WriteLine("The sum of two numbers : " + sum);
            Console.WriteLine();
            sumOf2Numbers();
        }

        public static void divide2Numbers()
        {   //3. Write a C# Sharp program to print the result of dividing two numbers.
            Console.Write("Enter first number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int division = Convert.ToInt32(firstNumber / secondNumber);

            Console.WriteLine("The division of two numbers : " + division);
        }

        public static void printAsAsked()
        {   //4. Write a C# Sharp program to print the result of the specified operations.
            Console.WriteLine("Expected Output : ");
            Console.WriteLine("-1 + 4 * 6 = " + (-1 + 4 * 6));
            Console.WriteLine("( 35+ 5 ) % 7 = " + ((35 + 5) % 7));
            Console.WriteLine("14 + -4 * 6 / 11 = " + (14 + -4 * 6 / 11));
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + (2 + 15 / 6 * 1 - 7 % 2));
        }

        //Note: poor programming
        public static void swap2Numbers()
        {   //5. Write a C# Sharp program to swap two numbers.
            Console.Write("First number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The 2 numbers are : " + firstNumber + " & " + secondNumber);
            Console.WriteLine("After swaping the numbers will be : " + secondNumber + " & " + firstNumber);
        }
        //Note: strong programming
        public static void swap2Numbers1()
        {   //5. Write a C# Sharp program to swap two numbers.
            int temp, num1, num2;
            Console.Write("Enter num1 : ");
            num1 = int.Parse(Console.ReadLine());
            temp = num1;
            Console.Write("Enter num2 : ");
            num2 = int.Parse(Console.ReadLine());
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfter swaping : ");
            Console.WriteLine("First number : " + num1);
            Console.WriteLine("Second number : " + num2);
            Console.Read();
        }
        //Note: stronger programming
        public static void swap2Numbers2(int num1, int num2)
        {   //5. Write a C# Sharp program to swap two numbers.
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.Write("After swaping : \n");
            Console.Write("First number : " + num1);
            Console.Write("\nSecond number : " + num2);
        }

        public static void multiplicationOf3Numbers()
        {   //6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
            Console.Write("Input the first number to multiply : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply : ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Expected Output : \n");
            Console.Write(firstNumber + " X " + secondNumber + " X " + thirdNumber + " = " + firstNumber * secondNumber * thirdNumber);
        }

        public static void calculate2Numbers()
        {   //7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
            int num1, num2, add, sub, mult, div, mod;

            Console.Write("Input the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2;
            sub = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            mod = num1 % num2;

            Console.Write("\nExpected Output : \n");
            Console.WriteLine(num1 + " + " + num2 + " = " + add);
            Console.WriteLine(num1 + " - " + num2 + " = " + sub);
            Console.WriteLine(num1 + " X " + num2 + " = " + mult);
            Console.WriteLine(num1 + " / " + num2 + " = " + div);
            Console.WriteLine(num1 + " % " + num2 + " = " + mod);
        }

        public static void multiplicationTable()
        {   //8. Write a C# Sharp program that takes a number as input and print its multiplication table.
            Console.Write("Enter the number : ");
            int input = Convert.ToInt32(Console.ReadLine());                            
            Console.WriteLine("Multiplication table of : " + input);
            Console.WriteLine("===========================");

            //for (int i = 0; i<=input; i++)
            for (int i = 0; i <= 10; i++)
            {
                int result = input * i;
                Console.WriteLine("\t" + input + " X " + i + " = " + result);
            }
            //multiplicationTable();
        }

        public static void calculateAverage()
        {   //9. Write a C# Sharp program that takes four numbers as input to calculate and print the average
            Console.Write("FIrst number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fourth number : ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Double avg = Convert.ToDouble((num1 + num2 + num3 + num4) / 4);

            Console.WriteLine(("The average of {0}, {1}, {2}, {3} "), num1, num2, num3, num4 + " : " + avg);
        }

        public static void printOutputOf3Inputs()
        {   //10. Write a C# Sharp program that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
            Console.Write("Enter first number - ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number - ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number - ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nOutput is");
            Console.WriteLine("==========");
            Console.WriteLine("(x+y).z is " + Convert.ToInt32((x + y)*z));
            Console.WriteLine("x.y + y.z is " + Convert.ToInt32((x * y) + (y * z)));
        }

        public static void olderThanInputValue()
        {   //11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
            Console.Write("Enter your age - ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYou look older than {0} ", age);
        }

        public static void displayInput4Times()
        {   /*12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces),
             * and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then 
             * use {0}.*/
            Console.Write("Enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<=3; i++)
            {
                Console.Write(input);
                Console.Write(" ");
            }
            Console.WriteLine("\n{0}{0}{0}{0}", input);
            Console.WriteLine("{0} {0} {0} {0}", input);
            Console.WriteLine("{0}{0}{0}{0}", input);
        }

        public static void createRectangle()
        {   /*13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide 
             * and 5 rows tall using that digit.*/
            Console.Write("Enter a number : ");
            int digit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", digit);
            Console.WriteLine("{0} {0}", digit);
            Console.WriteLine("{0} {0}", digit);
            Console.WriteLine("{0} {0}", digit);
            Console.Write("{0}{0}{0}", digit);
        }

        public static void CelciusToKelvinAndFarenheit()
        {   //14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
            Console.Write("Enter the amount of celcius : ");
            int cellcius = Convert.ToInt32(Console.ReadLine());

            int kelvin = cellcius + 273;
            //int farenheit = cellcius * 18 / 10 + 32;

            Console.WriteLine("Kelvin = {0}", kelvin);
            //Console.WriteLine("Farenheit = " + farenheit);
            Console.WriteLine("Farenheit = {0}", cellcius * 18 / 10 + 32);
        }

        public static void RemoveChar()
        {   //15. Write a C# program remove specified a character from a non-empty string using index of a character.
            Console.Write("Enter a string : ");
            var yourString = Convert.ToString(Console.ReadLine());
            Console.WriteLine(remove_char(yourString, 1));
            Console.WriteLine(remove_char(yourString, 9));
            Console.WriteLine(remove_char(yourString, 0));
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }

        public static void ChangeCharPosition()
        {   /*16. Write a C# program to create a new string from a given string where the first and last characters will change 
             * their positions. */
            Console.Write("Give your string : ");
            string givenString = Convert.ToString(Console.ReadLine());

            Console.WriteLine(change_char_position(givenString));
        }
        public static string change_char_position(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
        /*Ternary operator has been used in the above method
         General Structure of Ternary operator:
        expression ? true : false
        meaning, "expression" ==> what will be return if it is true? ==> what will be return if it is false?
        Example:
        ========
        bool correct = true;
        int pointsEarned = correct ? 10 : 0;
        Console.WriteLine(pointsEarned);
         */
        
        public static void FirstCharFirstAndLast()
        {   /*17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at 
             * the front and back.*/
            Console.Write("Give a string : ");
            string givenString = Convert.ToString(Console.ReadLine());

            if (givenString.Length >= 1)
            {
                string firstCharacter = givenString.Substring(0, 1);
                Console.Write(firstCharacter + givenString + firstCharacter);
            }
        }

        public static void CheckIfOneIsNegativeAndOtherIsPositive()
        {   //18. Write a C# program to check two given integers and return true if one is negative and one is positive.
            Console.Write("Enter the 1st number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if ((firstNumber < 0 && secondNumber > 0) || (firstNumber > 0 && secondNumber < 0))
            {
                Console.WriteLine("True");
            }
            else if((firstNumber == 0 && secondNumber == 0) || (firstNumber == -0 && secondNumber == 0) || (firstNumber == 0 && secondNumber == -0))
            {
                Console.WriteLine("Neutral...");
            }
            else
            {
                Console.WriteLine("False");
            }
            CheckIfOneIsNegativeAndOtherIsPositive();
        }

    }
}
