using System;
class BilHyra {
  static void Main() {
    int antalDagar  = 0;
    double dagsPris = 0;
    double totPris;
    string indata = "";
    // L�s in antal dagar
    bool klar = false;
    while (!klar) 
      try {
        Console.Write("Antal dagar? ");
        indata = Console.ReadLine();
        antalDagar = int.Parse(indata);
        klar = true;
      }
      catch (FormatException) {
        Console.WriteLine("Felaktigt heltal. F�rs�k igen!");
      }
      catch (ArgumentNullException) {
        Console.WriteLine("V�rdet f�r inte vara null. F�rs�k igen!");
      }
    // L�s in pris per dag
    klar = false;
    while (!klar) 
      try {
        Console.Write("Pris per dag? ");
        indata = Console.ReadLine();
        dagsPris = double.Parse(indata);
        klar = true;
      }
      catch (FormatException) {
        Console.WriteLine("Felaktigt belopp. F�rs�k igen!");
      }
      catch (ArgumentNullException) {
        Console.WriteLine("V�rdet f�r inte vara null. F�rs�k igen!");
      }
    totPris = dagsPris * antalDagar; 
    Console.WriteLine("Totalt pris: " + totPris);
  }
}

