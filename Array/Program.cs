using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        string[] array=new string[5]{"Mani","Ganesh","Venkat","Suresh","Venkat"};
        
        for(int i=0;i<array.Length;i++){
            Console.WriteLine(array[i]);
        }
        Console.Write("Enter Your name: ");
        string name=Console.ReadLine();
        bool flag=true;
        int count=0;

        foreach(string i in array){
            
            if(i==name){
                Console.WriteLine($"The Name is Present in Array and Index is {count}");
                flag=false;
                // break;
            }
            count++;

        }
        if(flag){
            Console.WriteLine("The Name is not Present in Array");
        }
    }
}
