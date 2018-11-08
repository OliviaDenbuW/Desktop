using System.Collections.Generic;
using System;

enum KortF�rg {KL�VER, RUTER, HJ�RTER, SPADER};
enum KortVal�r {TV�=2, TRE, FYRA, FEM, SEX, SJU, �TTA,  
                NIO, TIO, KNEKT, DAM,  KUNG, ESS};
class Kort {
  KortF�rg  f;
  KortVal�r v;

  static string[] f�rgTab  = {"Kl", "Ru", "Hj", "Sp"};
  static string[] val�rTab = {"2", "3", "4", "5", "6", "7", "8",
                              "9", "10", "Kn", "D", "K", "E"};

  public Kort(KortF�rg f�, KortVal�r va) {
    f = f�;
    v = va;
  }

  public KortF�rg F�rg {  
    get { return f; }
  }

  public KortVal�r Val�r { 
    get { return v; }
  }

  public int V�rde { 
    get { return (int) v; }
  }

  public override string ToString() {
    return f�rgTab[(int) f] + " " + val�rTab[V�rde-2];
  }
}

class Kortbunt {
  List<Kort> bunten = new List<Kort>();
  static Random rand = new Random(); 

  public void L�gg�verst(Kort k) {
    bunten.Insert(0, k);
  }

  public Kort TaBort�versta() {
    Kort k = bunten[0];
    bunten.RemoveAt(0);
    return k;
  }

  public int AntalKort {
    get { return bunten.Count; }
  }

  public void Sl�ngKorten() {
    bunten.Clear();
  }

  public Kort this[int nr] {     // indexerare
    get { return bunten[nr]; }
  }

  public Kort TaBort(int nr) {
    Kort k = bunten[nr];
    bunten.RemoveAt(nr);
    return k;
  }

  public int S�k(KortF�rg f, KortVal�r v) {
    int i = 0;
    for (i=0; i<bunten.Count; i++)
      if (bunten[i].F�rg==f && bunten[i].Val�r==v)
        return i;
    return -1;
  }

  public void NyKortlek() {
    bunten.Clear();
    for (KortF�rg f=KortF�rg.KL�VER; f <= KortF�rg.SPADER; f++)
      for (KortVal�r v = KortVal�r.TV�; v <= KortVal�r.ESS; v++)
        bunten.Add(new Kort(f, v));
  }

  public void Blanda() {
    for (int i=0; i<100; i++) {
      // L�t tv� slumpm�ssiga kort byta plats
      int a = rand.Next(bunten.Count);
      int b = rand.Next(bunten.Count);
      Kort k = bunten[a];
      bunten[a] = bunten[b];
      bunten[b] = k;
    }
  }

  public void Sl�Ihop(Kortbunt annan) {
    while (annan.AntalKort > 0) 
      L�gg�verst(annan.TaBort�versta());
  }
}

class Sv�ltaR�v {
  public static void Main() {
    Kortbunt[] spelare = new Kortbunt[2];
    spelare[0] = new Kortbunt();
    spelare[1] = new Kortbunt();
    int n�sta = 0;
    Kortbunt b = new Kortbunt();
    b.NyKortlek();
    b.Blanda();
    for (int i=1; i<=26; i++) {
      spelare[0].L�gg�verst(b.TaBort�versta());
      spelare[1].L�gg�verst(b.TaBort�versta());
    }

    while (spelare[0].AntalKort >0 && spelare[1].AntalKort >0) {
      Kort f�rsta = spelare[n�sta].TaBort�versta();
      b.L�gg�verst(f�rsta);
      Console.WriteLine("Spelare " + n�sta + " l�gger ut " + f�rsta);
      n�sta = (n�sta+1) % 2;
      while (b.AntalKort > 0 && spelare[n�sta].AntalKort >0) {
        Kort k=spelare[n�sta].TaBort�versta();
        b.L�gg�verst(k);
        Console.WriteLine("Spelare " + n�sta + " l�gger ut " + k);
        if (k.F�rg == f�rsta.F�rg && 
           (k.Val�r > f�rsta.Val�r || f�rsta.Val�r == KortVal�r.ESS)) {
            spelare[n�sta].Sl�Ihop(b);
          Console.WriteLine("Spelare " + n�sta + " tar korten");
          Console.WriteLine();
          Console.WriteLine("Spelare 0 har nu " + spelare[0].AntalKort + " kort");
          Console.WriteLine("Spelare 1 har nu " + spelare[1].AntalKort + " kort");
        }
        n�sta = (n�sta+1) % 2;
      }
    }
    if (spelare[0].AntalKort == 0)
      Console.WriteLine("Spelare 1 vann"); 
    else 
      Console.WriteLine("Spelare 0 vann");  
  }
}
