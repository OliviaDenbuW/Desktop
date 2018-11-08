using System;   // behövs för testprogrammet

class C {

  static int totAntal;

  public static int TotAntal {
    get { return totAntal; }
  }

  public C() {       // konstruktor
    totAntal++;
  }
    
}

class TestC {      // testprogram, ingick inte i uppgiften
  static void Main() {
    C c1 = new C();
    C c2 = new C();
    C c3 = new C();
    Console.WriteLine(C.TotAntal);    // ger utskriften 3
  }
}


