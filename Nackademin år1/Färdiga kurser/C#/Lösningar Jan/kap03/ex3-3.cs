using System;   // beh�vs f�r testprogrammet

class EnKlass {

  public static void Byt(ref int a, ref int b) {
    int temp = a;
    a = b; b = temp;
  }
    
}

class TestByt {      // testprogram
  static void Main() {
    int i=1, j=2;
    EnKlass.Byt(ref i,ref j);
    Console.WriteLine(i + "  " + j);    // ger utskriften 2  1
  }
}
