using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {   Console.Write("Enter the Number1: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter the Number2: ");
        int number2=int.Parse(Console.ReadLine());

        int total=0;
        
        for(int i=number1;i<=number2;i++){
            total+=i*i;
        }
        Console.WriteLine($"Total= {total}");
    }
}