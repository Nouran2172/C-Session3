using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        #region EX01
        //STRING FORMATTING
        //EQUATION : X+Y =12

        //int X = 3, Y = 4;

        //1.string concatnation
        //string Message = "Equation :" + X + "+" + Y + "=" + (X + Y);

        //Console.WriteLine(Message);

        //string:immutable -> can not change its value after creation

        //2.string format 

        //string Message = string.Format("equation: {0}+{1} = {2}",X,Y,X+Y);
        // Console.WriteLine(Message);

        //3.STRING INTERPOLUTION
        //$:

        //string Message = $"Equation : {X}+{Y}={X + Y}";
        //Console.WriteLine(Message);

        ////////////////////////////

        //control statments
        //control statments : 1. conditional control statments (if statments ,switch case)
        //control statments : 2.loop control statements (for ,foreach,while,do-while)

        //if (/*Expression*/)
        //{
        //    //code
        //    //will be executed when the condition is true
        //}

        //Console.WriteLine("Enter the number of month in the first quarter: ");
        //int MonthNumber = int.Parse(Console.ReadLine());
        //1--> jan
        //2--> feb
        //3--> mar

        //Console.WriteLine("jan");
        //Console.WriteLine("feb");
        //Console.WriteLine("mar");



        //if (MonthNumber==1)
        //{
        //    Console.WriteLine("jan");
        //}


        //if (MonthNumber == 2)
        //{
        //    Console.WriteLine("feb");
        //}


        //if (MonthNumber == 3)
        //{
        //    Console.WriteLine("mar");
        //}


        //if (MonthNumber == 1)
        //{
        //    Console.WriteLine("jan");
        //}

        //else if (MonthNumber == 2)
        //{
        //    Console.WriteLine("feb");
        //}
        //else if (MonthNumber == 3)
        //{
        //    Console.WriteLine("mar");
        //}

        //else
        //{
        //    Console.WriteLine("invalid number ");
        //}

        //switch

        //switch (/*expression*/)
        //{
        //    //case
        //}

        //Console.WriteLine("Enter the number of month in the first quarter: ");
        //int MonthNumber = int.Parse(Console.ReadLine());

        ////better in performance than if condtiton as:
        ////it creates in the run time jump table (cases: values) depend on theory hash table

        //switch (MonthNumber)
        //{
        //    case 1:
        //        Console.WriteLine("jan");
        //        break;

        //    case 2:
        //        Console.WriteLine("FEB");
        //        break;

        //    case 3:
        //        Console.WriteLine("MAR");
        //        break;

        //    default:
        //        Console.WriteLine("else");
        //        break;
        //}

        #endregion


        #region EX02
        //Console.WriteLine("Enter your name : ");
        //string Name = Console.ReadLine();
        //if condition 

        //if (Name =="Ahmed" || Name =="ahmed")
        //{
        //    Console.WriteLine("hi ahmed");
        //}
        //else if (Name == "Omar")
        //{
        //    Console.WriteLine("hi Omar");
        //}

        //else if (Name == "ali")
        //{
        //    Console.WriteLine("hi ali");
        //}

        //else if (Name == "mariam")
        //{
        //    Console.WriteLine("hi mariam");
        //}

        //switch
        //no logical operations in switch

        //switch (Name)
        //{
        //    case "Ahmed":
        //    case "ahmed":
        //        Console.WriteLine("hi ahmed");
        //        break;
        //    case "omar":
        //        Console.WriteLine("hi omar");
        //        break;
        //    case "ali":
        //        Console.WriteLine("hi ali");
        //        break;
        //    case "mariam":
        //        Console.WriteLine("hi mariam");
        //        break;
        //}

        #endregion



        #region EX03
        //Console.WriteLine("Enter your age : ");

        //int age = int.Parse(Console.ReadLine());

        //1.using if

        //if (age > 18)
        //{
        //    Console.WriteLine("welcome:)");
        //}
        //else if (age < 18)
        //{
        //    Console.WriteLine("bye bye:(");
        //}
        //else
        //{
        //    Console.WriteLine("Equal !!");
        //}

        //2.using switch
        //switch (age)
        //{
        //    case > 18:
        //        Console.WriteLine("welcome:)");
        //        break;
        //    case < 18:
        //        Console.WriteLine("bye bye :(");
        //        break;
        //    default:
        //        Console.WriteLine("equal !");
        //        break; 

        //} 
        #endregion

        #region EX04 C# 7.0
        //object obj = new object();
        //obj = 1;
        //obj = "ahmed";

        //switch (obj)
        //{
        //    case int x when x > 12:

        //        Console.WriteLine("int object");
        //        break;

        //    case string x when x.Length > 5:

        //        Console.WriteLine("string object");
        //        break;

        //    case string x when x.Length <=5:

        //        Console.WriteLine("string object<=5");
        //        break;
        //} 
        #endregion

        #region c# 9
        //https://mihirdave95.medium.com/evaluation-of-switch-in-c-be587f7de47c

        //String input = Console.ReadLine();

        //1
        //=> goes to
        //string output = input switch
        //{
        //    "1" => "option 1",
        //    "2" => "option 2",
        //    "3" => "option3",
        //    _ => "defult"
        //};

        //or for simplfy
        //Console.WriteLine(input switch
        //{
        //    "1" => "option 1",
        //    "2" => "option 2",
        //    "3" => "option3",
        //    _ => "defult"
        //});

        #endregion


        #region for vs foreach
        //1.for loop

        //for (/*statment*/;/*Expression*/ ; /*statment*/)
        //{
        //    //code will be repeated
        //}

        //for (int i = 0; i<=10;i++)
        //{
        //    Console.WriteLine("hello world");
        //}

        //int i = 0;

        //for ( Console.WriteLine("hello world"); i <= 10; Console.WriteLine("hello 2"))
        //{
        //    Console.WriteLine("hello world");
        //    i++;

        //}



        //for (int i = 0; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}


        //2.foreach

        //this compatible for the lists that had index but if i work with linked list it wont work
        //int[] Number = { 1, 2, 3 };


        //for (int i = 0; i <= Number.Length; i++)
        //{
        //    Console.WriteLine(Number[i]);
        //}


        //this compatible for lists that doesnot hase index like linked list
        //moves through  item item

        //foreach (int i in Number) 
        //{
        //    Console.WriteLine(i);

        //}

        #endregion

        #region While / do while
        //while loop 

        //while (/*Expression boolen*/)
        //{

        //    //code
        //    //code that is true

        //}

        //infinit loop
        //while (true)
        //{

        //    Console.WriteLine("hello");

        //}

        //int i = 1;
        //while (i <= 10)
        //{
        //    Console.WriteLine("hello");
        //    i++;
        //}

        //Console.WriteLine(i);

        //do{
        //    //code
        //    //this code will be excutede first before the condition

        //}
        //while(/*expression*/);

        //int i = 1; 
        //do
        //{
        //    Console.WriteLine("hello");
        //    i++;
        //}
        //while (i<=10);

        //handle string input with flag

        //int number;
        //do
        //{
        //    Console.WriteLine("even number:");
        //    number = int.Parse(Console.ReadLine());
        //}
        //while (number % 2 != 0);
        //Console.WriteLine(number);

        //handle string input with flag

        //int number;
        //bool flag;
        //do
        //{
        //    Console.WriteLine("even number:");
        //    flag = int.TryParse(Console.ReadLine(),out number);
        //}
        //while (number % 2 != 0 || flag ==false );
        //Console.WriteLine(number);

        #endregion

        #region String
        /*//string :reference type:heap (class)
//immutable type : can not change its value after creation
string s01;

//declare for refernece (pointer) frm type 'string'
//s01:can refer to object from 'string'
//s01:refer to null


//8 will be allocated at stack for refernce 's01'
// 0 bytes will be allocated at heap

s01 = new string("ahmed"); //syntax sugar

//new 
//1.allocate the number of required bytes for the object at heap
//2.initialized the allocated bytes with the default value
//3 call user -definrd constructor is exists
//4 assign the object to the reference

Console.WriteLine(s01.GetHashCode());

s01 = new string("ali");
//lma b8yr string b3ml object gded mn awel w a3ed nafs steps 
//new 
//1.allocate the number of required bytes for the object at heap
//2.initialized the allocated bytes with the default value
//3 call user -definrd constructor is exists
//4 assign the object to the reference
Console.WriteLine(s01.GetHashCode());

string message = "hello";

Console.WriteLine("message:" + message);
Console.WriteLine("hashcode: " + message.GetHashCode());
Console.WriteLine();*/
        #endregion

        #region StringBuilder
        /*
        //stringbuilder:class (reference type):Heap
        //mutable datatype:can change its value after creatation
     
        StringBuilder s01;

        //declare for refernece (pointer) frm type 'StringBuilder'
        //s01:can refer to object from 'StringBuilder'
        //s01:refer to null

        s01 = new StringBuilder("Ahmed");
        //new 
        //1.allocate the number of required bytes for the object at heap
        //2.initialized the allocated bytes with the default value
        //3 call user -definrd constructor is exists
        //4 assign the object to the reference

        Console.WriteLine("s01:" + s01);
        Console.WriteLine("s01 hash code: " + s01.GetHashCode());
        Console.WriteLine();

        //append: hna ana lma b8yr el string byfdl f nafs makan msh by3ml object gded
        //expand
        s01.Append("hello");

        Console.WriteLine("s01:" + s01);
        Console.WriteLine("s01 hash code: " + s01.GetHashCode());*/
        #endregion

        #region string methods

        //string s01 = "Hello world";
        //string result = s01.Substring(s01.Length);
        //var result = s01.Replace("hello", "welcome");
        //bool result = s01.StartsWith("H");
        //s01.ToCharArray();

        // Console.WriteLine(result);
        //Console.WriteLine(s01); 
        #endregion
    }

}