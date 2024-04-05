using System;
using System.Runtime.CompilerServices;
using System.Threading;

public class Program
        {
            public static void Main(string[] args)
            {
            //   DateTime a=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
            //   DateTime b=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
            //   TimeSpan c=b-a;
            //      Console.WriteLine($"Age : {(int)c.TotalDays/365}");
            //     Console.WriteLine($"Day : {a.DayOfWeek}");
            //     Console.WriteLine($"Number of days : {(int)c.TotalDays}");
            //     Console.WriteLine($"Number of hours : {(int)c.TotalHours}");
            //     Console.WriteLine($"Number of minutes  : {(int)c.TotalMinutes}");
           
            string str1=Console.ReadLine();
                string str2=Console.ReadLine();
                if(str1.Length==str2.Length){
                    char[] strArray1=str1.ToCharArray();
                    char[] strArray2=str2.ToCharArray();
                    Array.Sort(strArray1);
                    Array.Sort(strArray2);
                    if(new string(strArray1)==new string(strArray2)){
                        Console.WriteLine("Anagrams");
                    }else{
                        Console.WriteLine("Not Anagrams");
                    }
                    }else{
                    Console.WriteLine("Not Anagrams");}
            
            //---------------------------//

            // int number1=int.Parse(Console.ReadLine()); 
            // int number2=int.Parse(Console.ReadLine());        

            // int[,] array1=new int[number1,number2];
            // int[,] array2=new int[number2,number1];
            // for(int i=0;i<number1;i++){
            //    for(int j=0;j<number2;j++){
            //         array1[i,j]=int.Parse(Console.ReadLine()); 
            //    }
            // }
            //   for(int i=0;i<number2;i++){
            //    for(int j=0;j<number1;j++){
            //         array2[i,j]=int.Parse(Console.ReadLine()); 
            //    }
            // }
            // for(int i=0;i<number1;i++){
            //    for(int j=0;j<number1;j++){
            //     int sum=0;
            //     for(int k=0;k<number2;k++){
            //         sum+=array1[i,k]*array2[k,j];}
            //     Console.Write($"{sum} ");}
            //     Console.WriteLine();
            // }
//---------------------------------------//
            // double total=0;
            // for(int i=1;i<9;i++){
            //     total+= (double)pow(2,i)/fact(i);
            // }
            // Console.WriteLine(total);

            }
            static int fact(int n){
                if(n<=1){
                    return 1;
                }
                return n*fact(n-1);
            }
            static int pow(int a,int b){
                int count=1;
                int sum=1;
                while(count<=b){
                    sum *=a;
                    count++;
                }
                return sum;
            }
            
        }
            