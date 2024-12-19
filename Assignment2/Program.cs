using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Q1
        // Console.WriteLine("Enter a number");
        //int Number=int.Parse(Console.ReadLine());    
        // if ( Number%3==0 && Number%4==0 )
        // {
        //     Console.WriteLine("Yes");
        // }
        // else
        // {
        //     Console.WriteLine("No");
        // }

        #endregion

        #region Q2
        //Console.WriteLine("Enter a number");
        //int Number = int.Parse(Console.ReadLine());
        //if (Number <0)
        //{
        //    Console.WriteLine("Negative");
        //}
        //else
        //{
        //    Console.WriteLine("Positive");
        //}

        #endregion


        #region Q3
        //Console.WriteLine("Enter a number 1");
        //int Number1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter a number 2");
        //int Number2 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter a number 3");
        //int Number3 = int.Parse(Console.ReadLine());


        //if (Number1 >= Number2 & Number1 >= Number3)
        //{
        //    Console.WriteLine("MAX = " + Number1);
        //    if (Number2 > Number3)
        //    {
        //        Console.WriteLine("MIN: " + Number3);
        //    }
        //    else
        //    {
        //        Console.WriteLine("MIN: " + Number2);

        //    }
        //}



        //else if (Number2 >= Number1 & Number2 >= Number3)
        //{
        //    Console.WriteLine("MAX = " + Number2);
        //    if (Number1 > Number3)
        //    {
        //        Console.WriteLine("MIN: " + Number3);
        //    }
        //    else
        //    {
        //        Console.WriteLine("MIN: " + Number1);

        //    }
        //}

        //else
        //{
        //    Console.WriteLine("MAX = " + Number3);
        //    if (Number1 > Number2)
        //    {
        //        Console.WriteLine("MIN: " + Number2);
        //    }
        //    else
        //    {
        //        Console.WriteLine("MIN: " + Number1);

        //    }
        //} 
        #endregion


        #region Q4
        //Console.WriteLine("Enter a number");
        //int Number = int.Parse(Console.ReadLine());
        //if (Number % 2 == 0 )
        //{
        //    Console.WriteLine("Even");
        //}
        //else
        //{
        //    Console.WriteLine("Odd");
        //} 
        #endregion

        #region Q5
        //Console.WriteLine("Enter a character");
        //string input = Console.ReadLine();

        //if ("aeiouAEIOU".Contains(input))
        //{
        //    Console.WriteLine("vowel");
        //}
        //else 
        //{
        //    Console.WriteLine("Consonant");
        //} 
        #endregion

        #region Q6
        //Console.WriteLine("Enter a number");
        //int Number = int.Parse(Console.ReadLine());

        //for (int i=1;i<=Number;i++)
        //{
        //    Console.WriteLine(i);
        //} 
        #endregion


        #region Q7
        //Console.WriteLine("Enter a number");
        //int Number = int.Parse(Console.ReadLine());


        //for (int i=1;i<=12;i++)
        //{
        //    int mult = Number * i;
        //    Console.WriteLine(mult +",");
        //} 
        #endregion



        #region Q8
        //Console.WriteLine("Enter a number");
        //int Number = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= Number; i++)
        //{
        //    if (i % 2==0) 
        //    {
        //        Console.WriteLine(i);
        //    }

        //} 
        #endregion


        #region Q9 H
        //Console.WriteLine("Enter a number");
        //int Number = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter a Power");
        //int Power = int.Parse(Console.ReadLine());

        //if (Power > 0)
        //{
        //    int count = 1;
        //    for (int i = 1; i <= Power; i++)
        //    {
        //        int powered = Number * count;

        //        count = powered;

        //    }

        //    Console.WriteLine(count);
        //}
        //else if (Power < 0)
        //{
        //    int count = 1;
        //    for (int i = Power; i < 0; i++)
        //    {
        //        int powered = Number * count;

        //        count = powered;

        //    }

        //    Console.WriteLine($"1/{count}");
        //}
        //else
        //{
        //    Console.WriteLine(1);
        //} 
        #endregion


        #region Q10 H
        //int[] marks = new int[5];
        //int Total = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    marks[i] = int.Parse(Console.ReadLine());
        //    Total += marks[i];
        //}

        //int average = Total / 5;

        ////500.0 must be float
        //double percentage = (Total / 500.0) * 100;

        //Console.WriteLine("Total Marks " + Total);
        //Console.WriteLine("Average " + average);
        //Console.WriteLine("Percentage " + percentage);

        #endregion

        #region Q11 H
        //Console.WriteLine("Enter the month number ");
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
        //    case 2:
        //        days = 28;
        //        break;
        //    default:
        //        days = 30;
        //        break;
        //}
        //Console.WriteLine($"Days in this month = {days}"); 
        #endregion

        #region Q12
        //Console.WriteLine("number1");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("number2");
        //int num2 = int.Parse(Console.ReadLine());

        //Console.WriteLine("Operator");
        //char op = char.Parse(Console.ReadLine());

        //switch (op)
        //{
        //    case '+':
        //        Console.WriteLine(num1 + num2);
        //        break;
        //    case '-':
        //        Console.WriteLine(num1 - num2);
        //        break;
        //    case '*':
        //        Console.WriteLine(num1 * num2);
        //        break;
        //    case '/':
        //        if (num2 != 0)

        //            Console.WriteLine(num1 / num2);
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Operator");
        //        break;
        //}
        #endregion


        #region Q13 H
        //Console.WriteLine("Enter A string");
        //string word = Console.ReadLine();


        //for (int i = word.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(word[i]);
        //} 
        #endregion



        #region Q14 H
        //Console.WriteLine("Enter a number");
        //int number = int.Parse(Console.ReadLine());

        //int reversed = 0;
        //while (number != 0)
        //{
        //    int remainder = number % 10;
        //    reversed = reversed * 10 + remainder; 
        //    number /= 10; 
        //}
        //Console.WriteLine("Reversed number: " + reversed); 
        #endregion


        #region Q15 ASK

        //Console.WriteLine("Input starting number of range: ");
        //int StartNum = int.Parse(Console.ReadLine());

        //Console.WriteLine("Input ending number of range:");
        //int EndNum = int.Parse(Console.ReadLine());
        //int count;

        //for (int i = StartNum; i <= EndNum; i++)
        //{
        //    count = 0;
        //    for (int j = 2; j * j <= i; j++)
        //    {
        //        if (i % j == 0)
        //            count++;
        //        break;
        //    }
        //    if (count == 0 && i != 1)
        //        Console.WriteLine(i);
        //} 
        #endregion


        #region Q16 H

        //Console.WriteLine("Enter a number to convert: ");
        //int number = int.Parse(Console.ReadLine());

        //string binaryResult = "";


        //if (number == 0)
        //{
        //    binaryResult = "0";
        //}
        //else
        //{

        //    while (number > 0)
        //    {

        //        binaryResult = (number % 2) + binaryResult;
        //        number /= 2;
        //    }
        //    Console.WriteLine(binaryResult);
        //} 
        #endregion



        #region Q17
        //Console.WriteLine("Enter the coordinates of three points:");

        //Console.Write("Enter x1: ");
        //double x1 = double.Parse(Console.ReadLine());
        //Console.Write("Enter y1: ");
        //double y1 = double.Parse(Console.ReadLine());

        //Console.Write("Enter x2: ");
        //double x2 = double.Parse(Console.ReadLine());
        //Console.Write("Enter y2: ");
        //double y2 = double.Parse(Console.ReadLine());

        //Console.Write("Enter x3: ");
        //double x3 = double.Parse(Console.ReadLine());
        //Console.Write("Enter y3: ");
        //double y3 = double.Parse(Console.ReadLine());


        //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
        //{
        //    Console.WriteLine("The points lie on a single straight line.");
        //}
        //else
        //{
        //    Console.WriteLine("The points do not lie on a single straight line.");
        //} 
        #endregion

        #region Q18


        //Console.Write("Enter the time taken : ");
        //double time = double.Parse(Console.ReadLine());


        //if (time >= 2 && time < 3)
        //{
        //    Console.WriteLine("The worker is highly efficient.");
        //}
        //else if (time >= 3 && time < 4)
        //{
        //    Console.WriteLine("The worker needs to increase their speed.");
        //}
        //else if (time >= 4 && time < 5)
        //{
        //    Console.WriteLine("The worker needs training to enhance their speed.");
        //}
        //else if (time >= 5)
        //{
        //    Console.WriteLine("The worker is required to leave the company.");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Please enter a time of 2 hours or more.");
        //} 
        #endregion

    }
}
