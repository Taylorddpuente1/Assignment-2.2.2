
// Week 2 MON, April 14, 2025
//Write a Math Class

using System;

public class Maths
{

    // Add two imtegers
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Add three decimal numbers
    public static decimal Add(decimal num1, decimal num2, decimal num3)
    {
        return num1 + num2 + num3;
    }

    // Multiply two floats
    public static float Multiply(float num1, float num2)
    {
        return num1 * num2;
    }
    //Multiply three floats
    public static float Multiply(float num1, float num2, float num3)
    {
        return num1 * num2 * num3;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Maths Program!");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1.Add two integers:");
        Console.WriteLine("2.Add three decimals:");
        Console.WriteLine("3.Multiply two floats:");
        Console.WriteLine("4.Multiply three floats:");
    

    string choice = Console.ReadLine();

switch (choice)
{
    case "1":
          Console.WriteLine("Enter first integer: ");
          int a1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second integer: ");
          int a2 = Convert.ToInt32(Console.ReadLine());
    int addResult = Maths.Add(a1, a2);
    Console.WriteLine("Result: " + addResult);
          break;


   case "2":
        Console.WriteLine("Enter first decimal: ");
        decimal d1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second decimal: ");
        decimal d2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter third decimal: ");
        decimal d3 = Convert.ToInt32(Console.ReadLine());
    decimal addDecResult = Maths.Add(d1, d2, d3);
    Console.WriteLine("Result: " + addDecResult);
        break;


    case "3":
         Console.WriteLine("Enter first float: ");
         float f1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second float: "); 
         float f2 = Convert.ToInt32(Console.ReadLine());
    float mulResult = Maths.Multiply(f1, f2);
    Console.WriteLine("Result: " + mulResult);
         break;


     case "4":
         Console.WriteLine("Enter first float: ");
         float m1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second float: ");
         float m2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter third float: ");
         float m3 = Convert.ToInt32(Console.ReadLine());
    float mul2Result = Maths.Multiply(m1, m2, m3);
    Console.WriteLine("Result: " + mul2Result);
         break;

        default:
        Console.WriteLine("Invalid choice!");
        break;
      }
   }
}