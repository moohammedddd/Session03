namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region 2 Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion

            #region 3 - Write a program that takes 3 integers from the user then prints the max element and the min element
            //Console.Write("enter  first integer: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("enter secound integer : ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("enter third integer: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine("Max element = " + max);
            //Console.WriteLine("Min element = " + min);
            #endregion

            #region 4- - Write a program that allows the user to insert an integer number then check If a number is even or odd
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");

            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter a character: ");
            //char ch = char.Parse(Console.ReadLine().ToLower());

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion



            #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion


            #region 7 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(number * i);
            //}

            #endregion


            #region  8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion



            #region -9  Write a program that takes two integers then prints the power.
            //Console.Write("Enter the base number: ");
            //int baseNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //    result *= baseNumber;
            //}

            //Console.WriteLine("Result: " + result);
            #endregion

            #region 10 -  Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int total = 0;

            //Console.Write("Enter marks for subject 1: ");
            //int marks1 = int.Parse(Console.ReadLine());
            //total += marks1;

            //Console.Write("Enter marks for subject 2: ");
            //int marks2 = int.Parse(Console.ReadLine());
            //total += marks2;

            //Console.Write("Enter marks for subject 3: ");
            //int marks3 = int.Parse(Console.ReadLine());
            //total += marks3;

            //Console.Write("Enter marks for subject 4: ");
            //int marks4 = int.Parse(Console.ReadLine());
            //total += marks4;

            //Console.Write("Enter marks for subject 5: ");
            //int marks5 = int.Parse(Console.ReadLine());
            //total += marks5;

            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine("Total marks = " + total);
            //Console.WriteLine("Average marks = " + average);
            //Console.WriteLine("Percentage = " + average);
            #endregion


            #region -11 - Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter the month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //int days;

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:

            //        days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        days = 28; // Assuming it's not a leap year
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        return;
            //}

            //Console.WriteLine("Days in Month: " + days);
            #endregion

        }
    }
}
