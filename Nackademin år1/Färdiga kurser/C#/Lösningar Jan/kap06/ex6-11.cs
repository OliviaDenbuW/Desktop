using System;
using System.IO;
using System.Text;

class Lager {
  static void Main() {
    Encoding enc = Encoding.GetEncoding(1252);
    // �ppna lagerfilen
    Console.Write("Filens namn? "); 
    string namn = Console.ReadLine();
    StreamReader fil = new StreamReader(namn, enc);

    const int maxArtiklar = 1000;
    Artikel[] a = new Artikel[maxArtiklar];
    string rad;
    int antalArtiklar=0;
    char[] gr = {' ', '\t'};
    string[] ord;
     
    // l�s in information om alla artiklarna
     
    while ((rad = fil.ReadLine()) != null) {
       ord = rad.Split(gr, StringSplitOptions.RemoveEmptyEntries); 
       a[antalArtiklar++] = new Artikel(ord[0], ord[1], int.Parse(ord[2]), double.Parse(ord[3]));
    }
    fil.Close();

    // l�s och utf�r kommandon
    while (true) {
      Console.Write("? ");
      ord = Console.ReadLine().Split(gr, StringSplitOptions.RemoveEmptyEntries); 
      if (ord.Length >= 2 && (ord[0] == "info" || ord[0] == "buy" || ord[0] == "sell")) {
        // S�k artikeln i f�ltet
        int i;
        for (i=0; i<antalArtiklar; i++)
          if (a[i].Beteckning == ord[1])
            break;
        if (i == antalArtiklar) 
          Console.WriteLine("Ok�nd artikelbeteckning");
        else {
          if (ord[0] == "info") 
            Console.WriteLine(a[i]);  // metoden ToString anropas
          else {  // "buy" eller "sell"
            int antal;
            if (ord.Length >= 3 && int.TryParse(ord[2], out antal)) {
              if (ord[0] == "buy") 
                a[i].K�p(antal);
              else   // "sell"
                a[i].S�lj(antal);
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
    StreamWriter f = new StreamWriter(namn, false, enc);
    for (int i=0; i<antalArtiklar; i++) 
       f.WriteLine(a[i].Beteckning + " " + a[i].Beskrivning + " " + 
                   a[i].Antal + " " + a[i].Pris);
     f.Close();
  }
}

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



