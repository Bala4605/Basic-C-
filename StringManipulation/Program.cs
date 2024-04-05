using System;
namespace StringManipulation;
class Program{
    public static void Main(string[] args)
    {   Console.Write("Enter the Main String: ");
        string str=Console.ReadLine();
        Console.Write("Enter the SubString: ");
        string subStr=Console.ReadLine();

        string[] array=str.Split(subStr);
        Console.WriteLine($"string searchrd count is {array.Length-1}");
    }
}