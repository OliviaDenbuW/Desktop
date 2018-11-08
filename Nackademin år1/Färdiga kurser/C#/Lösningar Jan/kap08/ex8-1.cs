using System;
class BilHyra {
  static void Main() {
    int antalDagar  = 0;
    double dagsPris = 0;
    double totPris;
    string indata = "";
    // Läs in antal dagar
    bool klar = false;
    while (!klar) 
      try {
        Console.Write("Antal dagar? ");
        indata = Console.ReadLine();
        antalDagar = int.Parse(indata);
        klar = true;
      }
      catch (FormatException) {
        Console.WriteLine("Felaktigt heltal. Försök igen!");
      }
      catch (ArgumentNullException) {
        Console.WriteLine("Värdet får inte vara null. Försök igen!");
      }
    // Läs in pris per dag
    klar = false;
    while (!klar) 
      try {
        Console.Write("Pris per dag? ");
        indata = Console.ReadLine();
        dagsPris = double.Parse(indata);
        klar = true;
      }
      catch (FormatException) {
        Console.WriteLine("Felaktigt belopp. Försök igen!");
      }
      catch (ArgumentNullException) {
        Console.WriteLine("Värdet får inte vara null. Försök igen!");
      }
    totPris = dagsPris * antalDagar; 
    Console.WriteLine("Totalt pris: " + totPris);
  }
}

