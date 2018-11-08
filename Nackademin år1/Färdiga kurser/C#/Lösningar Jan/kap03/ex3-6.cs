using System;

class Euclides {
  public static int Sgd(int m, int n) {
    int r = m % n;
    while (r != 0)
    {
      m = n;
      n = r;
      r = m % n;
    }
    return n;
  }

  // Metoden Main ingick inte i uppgiften
  // Den finns med f�r att man skall kunna testa metoden Sgd
  static void Main () {
    while (true) {
      Console.Write("F�sta talet? ");
      string indata = Console.ReadLine(); 
      if (indata == null)
         break;
      int m = int.Parse(indata);
      Console.Write("Andra talet? "); 
      indata = Console.ReadLine();
      if (indata == null)
         break;
      int n = int.Parse(indata);
      int d = Sgd(m, n);
      Console.WriteLine("St�rsta gemensamma divisor �r " + d);
    }  
  }
}


