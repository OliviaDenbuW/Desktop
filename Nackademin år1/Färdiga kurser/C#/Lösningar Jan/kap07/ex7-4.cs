using System;

abstract class Djur {
  int l�ngd;
  double vikt;

  public Djur(int l, double v) {
    l�ngd=l;
    vikt=v;
  }

  public int L�ngd {
    get { return l�ngd; }
  }

  public double Vikt {
    get { return vikt; }
  }
  
  public abstract string L�te { get; }
}

abstract class D�ggdjur : Djur {
  public D�ggdjur(int l, double v) : base(l,v) {}
}

abstract class Kr�ldjur : Djur {
  public Kr�ldjur(int l, double v) : base(l,v) {}
}

abstract class F�gel : Djur {
  public F�gel(int l, double v) : base(l,v) {}
}

class Hund : D�ggdjur {
  string ras;

  public Hund(int l, double v, string r) : base(l,v) {
    ras = r;
  }

  public string Ras {
    get { return ras; }
  }

  public override string L�te {
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

class Orm : Kr�ldjur {
  bool giftig;

  public Orm(int l, double v, bool g) : base(l,v) {
    giftig=g;
  }

  public bool Giftig {
    get { return giftig; }
  }

  public override string L�te {
    get {
      if (giftig) 
        return "SSSSSSS...";
      else
        return "sssssss...";
    }
  }
}

class Kr�ka : F�gel {

  public Kr�ka(int l, double v) :  base(l,v) {}

  public override string L�te {
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
    d[4] = new Kr�ka(20, 1);
    for (int i=0; i<d.Length; i++)
      if (d[i] != null)   
        Console.WriteLine(d[i].L�te);
  }
}



