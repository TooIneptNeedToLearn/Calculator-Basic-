using System.Security.Cryptography;

class Program
{   
    static void asdad(String[] args)
    {
        string input;
        int a, b, c, a1, b1,c1, a2, b2, c2;
        double a3, b3, c3, d3;
        
        Console.WriteLine("Project:Input Calculator");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("For this cmd i will ask you Operation will you use? \nit can be addition,subtraction,multiplication and division");
        input = Console.ReadLine();

        if (input == "addition")
        {
            Console.WriteLine("You have chosen Addition operation");
            Console.WriteLine("Put two value that you wish to add");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen " + a + " as your first value");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen " + b + " as your second value");
            c = a + b;
            Console.WriteLine("Your sum is "+c);
        }

        else if(input == "subtraction")
        {
            Console.WriteLine("You have chosen Subtraction\nPut your first value ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen " + a1 + " as your first value");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen " + b1 + " as your second value");
            c1 = a1 - b1;
            Console.WriteLine("Your Difference is " + c1);
        }
        else if (input == "multiplication")
        {
            Console.WriteLine("You have chosen Multiplication\nPut your first value ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen " + a2 + " as your first value");
            b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen " + b2 + " as your second value");
            c2 = a2 * b2;
            Console.WriteLine("Your product  is " + c2);
        }
        else if (input == "division")
        {
            Console.WriteLine("You have chosen division\nPut your first value and it will produce the modulus and qoutient");
            a3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You have chosen " + a3 + " as your first value");
            b3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You have chosen " + b3 + " as your second value");
            c3 = a3 / b3;
            d3 = a3 % b3;
            Console.WriteLine("Your qoutient is " + c3);
            Console.WriteLine("Your modulus is " + d3);
        }
        else
            Console.WriteLine("Put the Right Operation");
        
    }
    static void Main(string[] args)
    {
        asdad(args);
    
    }
}

