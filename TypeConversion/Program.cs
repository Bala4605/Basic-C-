using System;
using System.Linq.Expressions;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter Your Name :");
        string name=Console.ReadLine();
        Console.Write("Enter Your Age :");
        int age=int.Parse(Console.ReadLine());
        Console.Write("Enter Mark of Subject1 :");
        double mark1=double.Parse(Console.ReadLine());
        Console.Write("Enter Mark of Subject2 :");
        double mark2=double.Parse(Console.ReadLine());
        Console.Write("Enter Mark Of Subject3 :");
        double mark3=double.Parse(Console.ReadLine());
        Console.Write("Enter Garde :");
        char grade=char.Parse(Console.ReadLine());
        Console.Write("Enter Mobile Number :");
        long mobileNumber=long.Parse(Console.ReadLine());
        Console.Write("Enter the Mail Id :");
        string mailId=Console.ReadLine();

        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile: {mobileNumber}");
        Console.WriteLine($"Marks1: {mark1}");
        Console.WriteLine($"Marks2: {mark2}");
        Console.WriteLine($"Marks3: {mark3}");
        double total= mark1 +mark2+mark3;
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {total/3}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"mail Id: {mailId}");



    }
}
