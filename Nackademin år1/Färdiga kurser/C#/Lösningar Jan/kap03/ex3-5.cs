using System;      // behövs för Main

class C {
  public static bool Perfekt(int tal) {
    int sum=0;
    for (int k=1; k<tal; k++)
      if (tal % k == 0)
        sum += k;
    return tal > 0 && sum == tal;
  }

  // Metoden main ingick inte i uppgiften
  // Den finns med för att man skall kunna testa metoden Perfekt
  static void Main () {
    while (true) {
      Console.Write("Tal som skall testas? "); 
      string indata = Console.ReadLine();
      if (indata == null)
         break;
      int n = int.Parse(indata);
      if (Perfekt(n))
        Console.WriteLine("Talet är perfekt");
      else
        Console.WriteLine("Talet är inte perfekt");  
    }
  }
}

