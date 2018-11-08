using System;
using System.Collections.Generic;

struct Punkt {
  public double x, y;
  
  public Punkt(double xx, double yy) {
    x=xx; y=yy;
  }

  public Punkt(Punkt p) {
    x=p.x; y=p.y;
  }

  public double Avst�nd(Punkt p) { 
    // ger avst�ndet mellan denna punkt och punkten p 
    return Math.Sqrt((x-p.x)*(x-p.x)+(y-p.y)*(y-p.y));
  }
}

abstract class Figur {
  Punkt startp;

  public const double pi=3.141592653589793;

  public Figur() {
    startp = new Punkt();
  }

  public Figur(double x, double y) {
    startp = new Punkt(x,y);
  }

  public Figur(Punkt p) {
    startp = new Punkt(p);
  }

  public void FlyttaTill(Punkt p) {
    startp = p;
  }

  public void Flytta(double dx, double dy) {
    startp.x += dx; startp.y += dy;
  }

  public Punkt Startpunkt {
    get { return startp; } 
  }

  public abstract double Area { get; }
}


class Cirkel : Figur {
  double radie;

  public Cirkel(double r, double x, double y) : base(x,y) {
    radie=r;
  }

  public Cirkel(double r, Punkt mitt)  : base(mitt) {
    radie=r;
  }

  public double Radie {
    get { return radie; }
  }

  public override double Area {
    get { return pi*radie*radie; }
  }
}

class Rektangel : Figur {
  double bredd, h�jd; 

  // �vre v�nstra h�rnet ges som starpunkt
  public Rektangel(double b, double h, double x, double y) : base(x,y) {
    bredd=b; h�jd=h; 
  }

  public Rektangel(double b, double h, Punkt start) {
    bredd=b; h�jd=h;
  }

  public double Bredd {
    get { return bredd; }
  }

  public double H�jd {
    get { return h�jd; }
  }

  public override double Area {
    get { return bredd*h�jd; }
  }
}

class Triangel : Figur {
  Punkt p2, p3;  // punkterna anges relativt startpunkten

  public Triangel(Punkt pa, Punkt pb, Punkt pc) : base (pa) {
    p2 = new Punkt(pb.x-pa.x, pb.y-pa.y);
    p3 = new Punkt(pc.x-pa.x, pc.y-pa.y);
  }

  public Punkt H�rn(int i) {
    if (i==1)
      return Startpunkt;
    else if (i==2)
      return new Punkt(p2.x+Startpunkt.x, p2.y+Startpunkt.y);
    else if (i==3)
      return new Punkt(p3.x+Startpunkt.x, p3.y+Startpunkt.y);
    else {
     Console.WriteLine("Felaktigt argument");
     return Startpunkt;  // n�got m�ste returneras i alla fall
    }
  }

  public override double Area {
    get {
      double a = Startpunkt.Avst�nd(p2), b = Startpunkt.Avst�nd(p3), c = p2.Avst�nd(p3);
      // a, b och c �r sidornas l�ngder
      double s = (a+b+c)/2;
      return Math.Sqrt(s*(s-a)*(s-b)*(s-c));  // Herons formel
    }
  }
}

class FigurTest {
  public static void Main() {
    List<Figur> f = new List<Figur>();
    f.Add(new Cirkel(2, 1, 1));
    f.Add(new Cirkel(3, new Punkt(1,0)));
    f.Add(new Rektangel(4, 5, 2, -2));
    f.Add(new Rektangel(6, 7, new Punkt(-1, 3)));
    f.Add(new Triangel(new Punkt(0,0), new Punkt(1,1), new Punkt(1,0)));
    f.Add(new Triangel(new Punkt(1,1), new Punkt(2,-1), new Punkt(0,-3)));
    foreach (Figur fig in f) 
      Console.WriteLine(fig.Area);
  }
}  

