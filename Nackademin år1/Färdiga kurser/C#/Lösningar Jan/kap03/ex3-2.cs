using System;   // behövs för testprogrammet

class C {

  static int totAntal;

  public static int TotAntal {
    get { return totAntal; }
  }

  readonly int id;

  public C() {       // konstruktor
    totAntal++;
    id = totAntal;
  }

  public int Id {
    get { return id; }
  }  
    
}

class TestC {      // testprogram, ingick inte i uppgiften
  static void Main() {
    C c1 = new C();
    C c2 = new C();
    C c3 = new C();
    Console.WriteLine(C.TotAntal);    // ger utskriften 3
    Console.WriteLine(c1.Id);         // ger utskriften 1
    Console.WriteLine(c2.Id);         // ger utskriften 2
    Console.WriteLine(c3.Id);         // ger utskriften 3
    
  }
}
