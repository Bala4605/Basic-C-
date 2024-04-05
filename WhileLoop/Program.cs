using System;
using System.Transactions;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {  // Question1
        int count=0;
        while(count<=25){
            if(count %2==0){
                Console.WriteLine(count);
            }
            count++;
        }
        //Quetion2
        int flag=1;

        while(flag==1){
            int validNumber;
            Console.Write("Enter a Number:");
            bool value=int.TryParse(Console.ReadLine(),out validNumber);
            if(value){
                Console.WriteLine($"The Number is {validNumber}");
                flag=0;
            }else{
                Console.WriteLine("Invalid Number");
            }

        }
    }
}