using System;

class Persontest {
  static void Main() {
    Console.Write("Ange personnummer: ");
    string pnr = Console.ReadLine();    
    if (int.Parse(pnr.Substring(8,1)) % 2 == 0)
      Console.WriteLine("En kvinna");
    else
      Console.WriteLine("En man");      
  }
}

