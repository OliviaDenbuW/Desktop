// Del a

using System;

class Forsakring {
  static void Main() {
    Console.Write("Vilket �r �r det nu? ");
    String indata = Console.ReadLine();
    int nu = int.Parse(indata);
    Console.Write("Bilens �rsmodell? ");
    indata = Console.ReadLine();
    int �rsmod = int.Parse(indata);
    if (nu-�rsmod < 5)
      Console.WriteLine("V�lj en helf�rs�kring");
    else
      Console.WriteLine("V�lj en halvf�rs�kring");
  }
}

// Del b
using System;

class Forsakring {
  static void Main() {
    Console.Write("Vilket �r �r det nu? ");
    String indata = Console.ReadLine();
    int nu = int.Parse(indata);
    Console.Write("Bilens �rsmodell? ");
    indata = Console.ReadLine();
    int �rsmod = int.Parse(indata);
    if (nu-�rsmod < 5)
      Console.WriteLine("V�lj en helf�rs�kring");
    else if (nu-�rsmod < 25)
      Console.WriteLine("V�lj en halvf�rs�kring");
    else
      Console.WriteLine("V�lj en veteranbilsf�rs�kring");
  }
}



