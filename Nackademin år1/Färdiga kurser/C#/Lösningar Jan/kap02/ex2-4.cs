using System;

class GeKort {
  static void Main() {
    Random r = new Random();
    int f = r.Next(1,4);
    int v = r.Next(1,15);
    Kort k1 = new Kort(f, v);
    while (f == k1.Färg && v == k1.Valör) {
      f = r.Next(1,4);
      v = r.Next(1,15);
    }
    Kort k2 = new Kort(f, v);
    Console.WriteLine(k1);     
    Console.WriteLine(k2);
  }
}

