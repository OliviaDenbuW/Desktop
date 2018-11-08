using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

class Lager {
  static void Main() {
    Encoding enc = Encoding.GetEncoding(1252);
    FileStream fil;
    BinaryFormatter form = new BinaryFormatter();
    Dictionary<string, Artikel> tab;
    // �ppna lagerfilen
    Console.Write("Filens namn? "); 
    string namn = Console.ReadLine();
    try {
      fil = new FileStream(namn, FileMode.Open);
      tab = (Dictionary<string, Artikel>) form.Deserialize(fil);   // l�s in hastabellen
      fil.Close();
    }
    catch(Exception) {
      tab  = new Dictionary<string, Artikel>();   // filen fanns inte skapa en ny hashtabell
    }

    // l�s och utf�r kommandon
    char[] gr = {' ', '\t'};
    while (true) {
      Console.Write("? ");
      string[] ord = Console.ReadLine().Split(gr, StringSplitOptions.RemoveEmptyEntries); 
      if (ord.Length >= 2 && (ord[0] == "new" || ord[0] == "info" || ord[0] == "buy" || ord[0] == "sell")) {
        // S�k artikeln i tabellen
        Artikel art;
        tab.TryGetValue(ord[1], out art);
        if (ord[0] == "new") {
          if (art == null) {
            double pris; 
            if (ord.Length >= 4 && double.TryParse(ord[3], out pris))
              tab.Add(ord[1], new Artikel(ord[1], ord[2], 0, pris));
            else
              Console.WriteLine("Felaktigt kommando");              
          }
          else
            Console.WriteLine("Artikeln finns redan");
        }
        else if (art == null) 
          Console.WriteLine("Ok�nd artikelbeteckning");
        else {
          if (ord[0] == "info") 
            Console.WriteLine(art);  // metoden ToString anropas
          else {  // "buy" eller "sell"
            int antal;
            if (ord.Length >= 3 && int.TryParse(ord[2], out antal)) {
              if (ord[0] == "buy") 
                art.K�p(antal);
              else   // "sell"
                art.S�lj(antal);
            }
            else
              Console.WriteLine("Felaktig antal");
          }
        }
      }
      else if (ord.Length == 1 && ord[0] == "stop")
        break;
      else
        Console.WriteLine("Felaktigt kommando");
    }

    // Lagra informationen i filen
    fil = new FileStream(namn, FileMode.Create);
    form.Serialize(fil, tab);
    fil.Close();
  }
}

[Serializable]
class Artikel {  // fr�n tidigare �vning
  string beteckning;
  string beskrivning;
  int antal;
  double pris;

  // konstruktor
  public Artikel(string bet, string bes, int ant, double pr) {
    beteckning = bet;
    beskrivning = bes;
    if (ant >= 0 ) 
      antal = ant;
    else 
      Console.WriteLine("Artikel: Felaktigt antal");
    Pris = pr;  // Obs! stort P
  }

  // egenskaper
  public string Beteckning {
    get {return beteckning;}
  }

  public string Beskrivning {
    get {return beskrivning;}
  }

  public int Antal {
    get {return antal;}
  }

  public double Pris{
    get {return pris;}
    set {
      if (value >= 0)
        pris = value;
      else 
        Console.WriteLine("Artikel: Felaktigt pris"); 
    }       
  }

  // metoder
  public override string ToString() {
    return beteckning + ": " + beskrivning + 
           " Antal: " + antal + " Pris: " + pris;
  }

  public void K�p(int n) {
    if (n > 0) 
      antal = antal + n;
    else
      Console.WriteLine("Artikel.K�p: Felaktigt antal");
  }

  public void S�lj(int n) {
    if (n > 0 && antal - n >= 0) 
      antal = antal - n;
    else
      Console.WriteLine("Artikel.s�lj: Felaktigt antal");
  }
}

