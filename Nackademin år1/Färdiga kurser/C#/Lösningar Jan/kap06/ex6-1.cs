using System;

class F�rbrukning {

  static void Main() {  
    Console.Write("Dagens m�tarst�llning? ");
    int m1 = int.Parse(Console.ReadLine());
    Console.Write("M�tarst�llning f�r ett �r sedan? ");
    int m2 = int.Parse(Console.ReadLine());
    Console.Write("Antal liter f�rbrukad bensin? ");
    double li = double.Parse(Console.ReadLine());
    Console.WriteLine("Antal k�rda mil:{0,9}", m1-m2);
    Console.WriteLine("Antal liter bensin:{0,8:f1}", li);
    Console.WriteLine("F�rbrukning per mil:{0,5:f2}", li/(m1-m2)); 
  }
}
