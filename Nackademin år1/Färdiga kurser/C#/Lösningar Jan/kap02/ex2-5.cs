using System;

class Artikel {
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

class Test {
  static void Main() {
    Artikel a1 = new Artikel("gg6791", "G�ngj�rn", 75, 10.50);
    Console.WriteLine(a1);
    Console.WriteLine("Beteckning:  " + a1.Beteckning);
    Console.WriteLine("Beskrivning: " + a1.Beskrivning); 
    Console.WriteLine("Antal:       " + a1.Antal);
    Console.WriteLine("Pris:        " + a1.Pris); 
    a1.K�p(100);
    a1.S�lj(125);
    a1.Pris = 13.25;
    Console.WriteLine(a1); 
    a1.S�lj(60);
    a1.K�p(-1);
    a1.Pris = -1;
  }
}

