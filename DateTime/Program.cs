using System;
namespace DateTimeAssignment;
class Program{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine($"year: {date.Year}");
        Console.WriteLine($"Month: {date.Month}");
        Console.WriteLine($"Day: {date.Day}");
        Console.WriteLine($"Hour: {date.Hour}");
        Console.WriteLine($"Minute: {date.Minute}");
        Console.WriteLine($"Second: {date.Second}");

        Console.Write("Enter the Date(yyyy,MM,dd,hh,mm,ss,tt) :");
        string date2=Console.ReadLine();
        string[] date3=date2.Split(",");
        for(int i=date3.Length-1;i>=0;i--){
            Console.Write(date3[i]+" ");
        }

        Console.WriteLine();
        // Console.WriteLine(date.ToString("tt ss mm hh dd MM yyyy"));
        
        Console.Write("Enter the Date(yyyy/MM/dd hh:mm:ss tt) :");

        bool isValid=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out DateTime date1);

        while(!isValid){
            Console.Write("Please Enter Correct Format (yyyy/MM/dd hh:mm:ss tt):");
            isValid=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date1);
        }
        Console.WriteLine($"year: {date1.Year}");
        Console.WriteLine($"Month: {date1.Month}");
        Console.WriteLine($"Day: {date1.Day}");
    }
}