using System;
using System.Collections;

class R�knare {
  int v�rde, min, max;

  // konstruktorer
  public R�knare(int start) {
    min = int.MinValue; 
    max = int.MaxValue; 
    v�rde = start;   
  }
    
  public R�knare(int start, int minsta, int st�rsta) {
    if (minsta <= st�rsta) {
      min = minsta;
      max = st�rsta;
      v�rde = min;    // Om n�sta sats misslyckas
      V�rde = start;  // Obs! stort V
    }
    else {
      ArgumentException e = new ArgumentException("Otill�tna gr�nser i r�knare");
      e.Data["Min"] = min;
      e.Data["Max"] = max;
      e.Data["V�rde"] = start;
      throw e;
    }      
  }

  // egenskaper
  public int V�rde {
    get {return v�rde;} 
    set {
      if (value >= min && value <= max)
        v�rde = value;
      else {
        ArgumentException e = new ArgumentException("Otill�tet v�rde i r�knare");
        e.Data["Min"] = min;
        e.Data["Max"] = max;
        e.Data["V�rde"] = value;
        throw e;
      }
    }
  }

  // metoder
  public void Upp() {
    V�rde = v�rde + 1;    // Obs! stort V
  }

  public void Ner() {
    V�rde = v�rde - 1;    // Obs! stort V
  }     
}

class Test {
  static void Main() {
    try {
      R�knare r = new R�knare(100);
      Console.WriteLine(r.V�rde);
      r.Upp();
      Console.WriteLine(r.V�rde);
      r.V�rde = 25;
      Console.WriteLine(r.V�rde);
      r.Ner();
      Console.WriteLine(r.V�rde);
      r = new R�knare(1, 0, 10);
      r.Ner();
      Console.WriteLine(r.V�rde);
      r.Ner();
      r.V�rde = 10;
      Console.WriteLine(r.V�rde);
      r.Upp();
      r = new R�knare(0, 0, -1);
      r = new R�knare(0, 1, 10);       
    }
    catch (Exception e) {
      Console.WriteLine(e.Message);
        foreach (DictionaryEntry d in e.Data)
          Console.WriteLine(" Nyckelord: " + d.Key + " V�rde: " + d.Value);
    }
  }
}

