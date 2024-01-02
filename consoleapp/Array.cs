using System;

class Array{
    static void Main()
    {
     var sentence = "My name is Ferhat Sümer"; 
     Console.WriteLine(sentence.Split(' ')); // My name is Ferhat Sümer
    
    string [] names = {"Ferhat", "Sümer", "Ali", "Veli"};
    Console.WriteLine(names[0]); // Ferhat
    Console.WriteLine(names[1]); // Sümer
    Console.WriteLine(names[2]); // Ali
    Console.WriteLine(names[3]); // Veli


    int [] numbers = {1,2,3,4,5,6,7,8,9,10};
    Console.WriteLine(numbers[0]); // 1
    Console.WriteLine(numbers[1]); // 2
    Console.WriteLine(numbers[2]); // 3
    Console.WriteLine(numbers[3]); // 4
    Console.WriteLine(numbers[4]); // 5

    string [] city={"Ankara", "İstanbul", "İzmir", "Adana", "Bursa"};
    Console.WriteLine(city[0]); // Ankara
    Console.WriteLine(city.Length); // 5
    Console.WriteLine(city[city.Length-1]); // Bursa

        foreach (var i in city[0..2])
        {
            Console.WriteLine(i); // Ankara, İstanbul
        }
      foreach(var i in city[2..]){
            Console.WriteLine(i); // İzmir, Adana, Bursa
      }
    }

}