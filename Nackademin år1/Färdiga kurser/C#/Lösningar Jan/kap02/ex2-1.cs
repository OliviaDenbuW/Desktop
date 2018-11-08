using System;

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
    else 
      Console.WriteLine("Felaktiga gr�nser i r�knare");      
  }

  // egenskaper
  public int V�rde {
    get {return v�rde;} 
    set {
      if (value >= min && value <= max)
        v�rde = value;
      else
        Console.WriteLine("Otill�tet v�rde i r�knare");
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
}


