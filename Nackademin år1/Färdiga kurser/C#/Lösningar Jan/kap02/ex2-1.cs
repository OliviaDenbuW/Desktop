using System;

class Räknare {
  int värde, min, max;

  // konstruktorer
  public Räknare(int start) {
    min = int.MinValue; 
    max = int.MaxValue; 
    värde = start;   
  }
    
  public Räknare(int start, int minsta, int största) {
    if (minsta <= största) {
      min = minsta;
      max = största;
      värde = min;    // Om nästa sats misslyckas
      Värde = start;  // Obs! stort V
    }
    else 
      Console.WriteLine("Felaktiga gränser i räknare");      
  }

  // egenskaper
  public int Värde {
    get {return värde;} 
    set {
      if (value >= min && value <= max)
        värde = value;
      else
        Console.WriteLine("Otillåtet värde i räknare");
    }
  }

  // metoder
  public void Upp() {
    Värde = värde + 1;    // Obs! stort V
  }

  public void Ner() {
    Värde = värde - 1;    // Obs! stort V
  }     
}

class Test {
  static void Main() {
    Räknare r = new Räknare(100);
    Console.WriteLine(r.Värde);
    r.Upp();
    Console.WriteLine(r.Värde);
    r.Värde = 25;
    Console.WriteLine(r.Värde);
    r.Ner();
    Console.WriteLine(r.Värde);
    r = new Räknare(1, 0, 10);
    r.Ner();
    Console.WriteLine(r.Värde);
    r.Ner();
    r.Värde = 10;
    Console.WriteLine(r.Värde);
    r.Upp();
    r = new Räknare(0, 0, -1);
    r = new Räknare(0, 1, 10);       
  }
}


