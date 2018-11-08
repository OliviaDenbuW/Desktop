using System;

class Ränta {
  static void Main() {
    Console.Write("Kapital? ");
    double k = double.Parse(Console.ReadLine());
    Console.Write("Räntesats? "); 
    double p = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("År        Saldo");
    Console.WriteLine("==        =====");
    for (int år=1; år<=10; år++) {
      k *= (1+p/100);
      Console.WriteLine("{0:d2}{1,15:f2}", år, k);
    }
  }
}
