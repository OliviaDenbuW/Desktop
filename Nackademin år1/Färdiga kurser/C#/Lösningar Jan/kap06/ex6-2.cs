using System;

class R�nta {
  static void Main() {
    Console.Write("Kapital? ");
    double k = double.Parse(Console.ReadLine());
    Console.Write("R�ntesats? "); 
    double p = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("�r        Saldo");
    Console.WriteLine("==        =====");
    for (int �r=1; �r<=10; �r++) {
      k *= (1+p/100);
      Console.WriteLine("{0:d2}{1,15:f2}", �r, k);
    }
  }
}
