using System;
namespace Methods;
class Program{
    public static void Main(string[] args)
    { 
        string again="";
        do{
        Console.Write("Enter the number1 :");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter the number2 :");
        int number2=int.Parse(Console.ReadLine());
        Console.WriteLine("1.Addition\n2.Subtration\n3.Multiplication\n4.Divison");
        Console.Write("Enter the Value :");
        int value=int.Parse(Console.ReadLine());
        switch(value){
            case 1:

            {
                Console.WriteLine($"The Answer is {add(number1,number2)}");
                break;
            }
            case 2:

            {
                Console.WriteLine($"The Answer is {sub(number1,number2)}");
                break;
            }
            case 3:

            {
                Console.WriteLine($"The Answer is {multi(number1,number2)}");
                break;
            }
            case 4:

            {
                Console.WriteLine($"The Answer is {div(number1,number2)}");
                break;
            }
            
        }   Console.WriteLine("Do you want to continue?-(yes/no) :");
            again=Console.ReadLine();
        }while(again=="yes");
    }
    static int add(int a,int b){
        return a+b;
    }
    static int sub(int a,int b){
        return a-b;
    }
    static int multi(int a,int b){
        return a*b;
    }
    static int div(int a,int b){
        return a/b;
    }
}