using System;
namespace SwithCase;
class Program {
    public static void Main(string[] args)
    {
        Console.Write("Enter the Number1: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter the Number2 :");
        int number2=int.Parse(Console.ReadLine());
        Console.Write("Enter the operant + - / * %: ");
        char operant=char.Parse(Console.ReadLine());


        switch(operant){
            case '+':{
                Console.WriteLine(number1+number2);
                break;
            }
            case '-':{
                Console.WriteLine(number1-number2);
                break;
                
            }
            case '*':{
                Console.WriteLine(number1*number2);
                break;
            }
            case '/':{
                Console.WriteLine(number1/number2);
                break;
            }
            case '%':{
                Console.WriteLine(number1%number2);
                break;
            }
            default:{
                Console.WriteLine("Operation is Invalid");
                break;
            }

        }
    }
}

