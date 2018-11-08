using System;

abstract class Djur {
  int längd;
  double vikt;

  public Djur(int l, double v) {
    längd=l;
    vikt=v;
  }

  public int Längd {
    get { return längd; }
  }

  public double Vikt {
    get { return vikt; }
  }
  
  public abstract string Läte { get; }
}

abstract class Däggdjur : Djur {
  public Däggdjur(int l, double v) : base(l,v) {}
}

abstract class Kräldjur : Djur {
  public Kräldjur(int l, double v) : base(l,v) {}
}

abstract class Fågel : Djur {
  public Fågel(int l, double v) : base(l,v) {}
}

class Hund : Däggdjur {
  string ras;

  public Hund(int l, double v, string r) : base(l,v) {
    ras = r;
  }

  public string Ras {
    get { return ras; }
  }

  public override string Läte {
    get {
      if (Vikt < 3)
        return "Viff";
      else if (Vikt < 10)
        return "Vov";
      else
        return "VOFF";
    }
  }
}

class Orm : Kräldjur {
  bool giftig;

  public Orm(int l, double v, bool g) : base(l,v) {
    giftig=g;
  }

  public bool Giftig {
    get { return giftig; }
  }

  public override string Läte {
    get {
      if (giftig) 
        return "SSSSSSS...";
      else
        return "sssssss...";
    }
  }
}

class Kråka : Fågel {

  public Kråka(int l, double v) :  base(l,v) {}

  public override string Läte {
    get {
      return "Krax, Krax";
    }
  }
}

class DjurTest {
  public static void Main() {
    Djur[] d = new Djur[20];
    d[0] = new Hund(30, 6, "Tax");
    d[1] = new Orm(150, 2, true);
    d[2] = new Hund(70, 20, "Labrador");
    d[3] = new Orm(100, 1.5, false); 
    d[4] = new Kråka(20, 1);
    for (int i=0; i<d.Length; i++)
      if (d[i] != null)   
        Console.WriteLine(d[i].Läte);
  }
}



