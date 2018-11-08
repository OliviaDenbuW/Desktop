using System;

class Kort {
  int färg;    // 1=klöver, 2=ruter, 3=hjärter, 4=spader 
  int valör;

  // konstruktor
  public Kort(int f, int v) {
    if (f < 1 || f > 4)
      throw new ArgumentOutOfRangeException("f");
    if (v < 1 || v > 13)
      throw new ArgumentOutOfRangeException("v");
    färg = f;
    valör = v;
  }

  // egenskaper
  public int Färg { 
    get {return färg;}
  }

  public int Valör { 
    get {return valör;}
  }

  public override string ToString() {
    string s;
    if (färg == 1)
      s = "Klöver ";
    else if (färg == 2)
      s = "Ruter ";
    else if (färg==3)
      s = "Hjärter ";
    else
      s = "Spader ";
   
    if (valör == 1)
      s = s + "Ess";
    else if (valör < 11) 
      s = s + valör;
    else if (valör == 11)
      s = s + "Knekt";
    else if (valör== 12)
      s = s + "Dam";
    else s = s + "Kung";
    return s;
  } 
}

class Test {
  static void Main() {
    Kort k1 = new Kort(3, 11);
    Console.WriteLine(k1);
    Console.WriteLine("Färg:  " + k1.Färg);
    Console.WriteLine("Valör: " + k1.Valör);
    Kort k2 = new Kort(1, 7);
    Console.WriteLine(k2);
    Console.WriteLine("Färg:  " + k2.Färg);
    Console.WriteLine("Valör: " + k2.Valör);
    Kort k3 = new Kort(0, 7);
    Kort k4 = new Kort(2, 14);
  }
}
   
