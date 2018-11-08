using System;

class Kort {
  int f�rg;    // 1=kl�ver, 2=ruter, 3=hj�rter, 4=spader 
  int val�r;

  // konstruktor
  public Kort(int f, int v) {
    if (f < 1 || f > 4)
      throw new ArgumentOutOfRangeException("f");
    if (v < 1 || v > 13)
      throw new ArgumentOutOfRangeException("v");
    f�rg = f;
    val�r = v;
  }

  // egenskaper
  public int F�rg { 
    get {return f�rg;}
  }

  public int Val�r { 
    get {return val�r;}
  }

  public override string ToString() {
    string s;
    if (f�rg == 1)
      s = "Kl�ver ";
    else if (f�rg == 2)
      s = "Ruter ";
    else if (f�rg==3)
      s = "Hj�rter ";
    else
      s = "Spader ";
   
    if (val�r == 1)
      s = s + "Ess";
    else if (val�r < 11) 
      s = s + val�r;
    else if (val�r == 11)
      s = s + "Knekt";
    else if (val�r== 12)
      s = s + "Dam";
    else s = s + "Kung";
    return s;
  } 
}

class Test {
  static void Main() {
    Kort k1 = new Kort(3, 11);
    Console.WriteLine(k1);
    Console.WriteLine("F�rg:  " + k1.F�rg);
    Console.WriteLine("Val�r: " + k1.Val�r);
    Kort k2 = new Kort(1, 7);
    Console.WriteLine(k2);
    Console.WriteLine("F�rg:  " + k2.F�rg);
    Console.WriteLine("Val�r: " + k2.Val�r);
    Kort k3 = new Kort(0, 7);
    Kort k4 = new Kort(2, 14);
  }
}
   
