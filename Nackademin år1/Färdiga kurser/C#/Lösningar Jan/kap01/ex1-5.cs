// Del a

using System;

class Forsakring {
  static void Main() {
    Console.Write("Vilket år är det nu? ");
    String indata = Console.ReadLine();
    int nu = int.Parse(indata);
    Console.Write("Bilens årsmodell? ");
    indata = Console.ReadLine();
    int årsmod = int.Parse(indata);
    if (nu-årsmod < 5)
      Console.WriteLine("Välj en helförsäkring");
    else
      Console.WriteLine("Välj en halvförsäkring");
  }
}

// Del b
using System;

class Forsakring {
  static void Main() {
    Console.Write("Vilket år är det nu? ");
    String indata = Console.ReadLine();
    int nu = int.Parse(indata);
    Console.Write("Bilens årsmodell? ");
    indata = Console.ReadLine();
    int årsmod = int.Parse(indata);
    if (nu-årsmod < 5)
      Console.WriteLine("Välj en helförsäkring");
    else if (nu-årsmod < 25)
      Console.WriteLine("Välj en halvförsäkring");
    else
      Console.WriteLine("Välj en veteranbilsförsäkring");
  }
}



