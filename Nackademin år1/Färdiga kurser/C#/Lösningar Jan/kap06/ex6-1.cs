using System;

class Förbrukning {

  static void Main() {  
    Console.Write("Dagens mätarställning? ");
    int m1 = int.Parse(Console.ReadLine());
    Console.Write("Mätarställning för ett år sedan? ");
    int m2 = int.Parse(Console.ReadLine());
    Console.Write("Antal liter förbrukad bensin? ");
    double li = double.Parse(Console.ReadLine());
    Console.WriteLine("Antal körda mil:{0,9}", m1-m2);
    Console.WriteLine("Antal liter bensin:{0,8:f1}", li);
    Console.WriteLine("Förbrukning per mil:{0,5:f2}", li/(m1-m2)); 
  }
}
