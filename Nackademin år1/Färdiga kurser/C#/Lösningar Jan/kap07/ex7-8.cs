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

   public void Sortera(IComparer<Kort> jfr) {
     bunten.Sort(jfr);
   }
}

class JfrKort : IComparer<Kort> {
  public int Compare(Kort k1, Kort k2) {
    if (k1 == null && k2 == null)
      return 0;
    else if (k1 == null)
      return -1;
    else if (k2 == null)
      return 1;
    else if (k1.F�rg < k2.F�rg)   // uppr�kningsv�rdena r�kar ligga i "r�tt" ordning
      return -1;
    else if (k1.F�rg > k2.F�rg)
      return 1;
    else if (k1.Val�r < k2.Val�r) 
      return -1;
    else if (k1.Val�r > k2.Val�r)
      return 1;
    else
      return 0;
  }
}

class KortTest {
   public static void Main() {
     Kortbunt b = new Kortbunt();
     b.NyKortlek();
     b.Blanda();
     b.Sortera(new JfrKort());
     for (int i =0; i<b.AntalKort; i++) { 
       if (i > 0 && i % 13 == 0) 
         Console.WriteLine();
       Console.Write(b[i] + "  "); 
     }      
   }
 }


