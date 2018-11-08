using System;
using System.Collections;

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
    else {
      ArgumentException e = new ArgumentException("Otillåtna gränser i räknare");
      e.Data["Min"] = min;
      e.Data["Max"] = max;
      e.Data["Värde"] = start;
      throw e;
    }      
  }

  // egenskaper
  public int Värde {
    get {return värde;} 
    set {
      if (value >= min && value <= max)
        värde = value;
      else {
        ArgumentException e = new ArgumentException("Otillåtet värde i räknare");
        e.Data["Min"] = min;
        e.Data["Max"] = max;
        e.Data["Värde"] = value;
        throw e;
      }
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
    try {
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
    catch (Exception e) {
      Console.WriteLine(e.Message);
        foreach (DictionaryEntry d in e.Data)
          Console.WriteLine(" Nyckelord: " + d.Key + " Värde: " + d.Value);
    }
  }
}

