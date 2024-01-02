using System;

class Program
{
    static void Main( )

    {
    //Console.WriteLine("Hello, World!");
    var kdv1=1.18;
    var computerPrice=1000;
           Console.WriteLine(computerPrice*kdv1);

    var kdv2=1.28;
    var phonePrice=2000;
           Console.WriteLine(phonePrice*kdv2);

    //strings Methods 
    var str= "Hello, World!";
    Console.WriteLine(str);
    Console.WriteLine(str.Length);  //13
    Console.WriteLine(str.ToUpper()); //HELLO, WORLD!
    Console.WriteLine(str.ToLower()); //hello, world!
    Console.WriteLine(str.Contains("World")); //true
    Console.WriteLine(str.StartsWith("Hello")); //true
    Console.WriteLine(str.EndsWith("World")); //true
    Console.WriteLine(str.IndexOf("World")); //7

        // DateTime
    var dateTime = DateTime.Now;
    Console.WriteLine(dateTime); // 10.10.2021 15:00:00
    Console.WriteLine(dateTime.Year); // 2024
    Console.WriteLine(dateTime.Month); // 01
    Console.WriteLine(dateTime.Day); // 02
    Console.WriteLine(dateTime.Hour); // 20 
    Console.WriteLine(dateTime.Minute); // 30
    Console.WriteLine(dateTime.Second); // 40


    }


}
