using System;

delegate bool Testare(int tal);
 
class C {

  public static int Antal(int[] a, Testare t) {
    int n = 0;
    foreach (int i in a)
      if(t(i))
        n++;
    return n;
  }
}

class C2 {
  static void Main() {
    int[] v = {1, 2, -3, 0, 5, 0, -1, 0};
    Console.WriteLine(C.Antal(v, ÄrNoll));
    Console.WriteLine(C.Antal(v, delegate (int i) {return i<0;}));
  }

  static bool ÄrNoll(int k) {
    return k == 0;
  }
}



