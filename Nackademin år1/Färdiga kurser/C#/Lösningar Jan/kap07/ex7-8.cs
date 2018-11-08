using System.Collections.Generic;
using System;

enum KortFärg {KLÖVER, RUTER, HJÄRTER, SPADER};
enum KortValör {TVÅ=2, TRE, FYRA, FEM, SEX, SJU, ÅTTA,  
                NIO, TIO, KNEKT, DAM,  KUNG, ESS};
class Kort {
  KortFärg  f;
  KortValör v;

  static string[] färgTab  = {"Kl", "Ru", "Hj", "Sp"};
  static string[] valörTab = {"2", "3", "4", "5", "6", "7", "8",
                              "9", "10", "Kn", "D", "K", "E"};

  public Kort(KortFärg fä, KortValör va) {
    f = fä;
    v = va;
  }

  public KortFärg Färg {  
    get { return f; }
  }

  public KortValör Valör { 
    get { return v; }
  }

  public int Värde { 
    get { return (int) v; }
  }

  public override string ToString() {
    return färgTab[(int) f] + " " + valörTab[Värde-2];
  }
}

class Kortbunt {
  List<Kort> bunten = new List<Kort>();
  static Random rand = new Random(); 

  public void LäggÖverst(Kort k) {
    bunten.Insert(0, k);
  }

  public Kort TaBortÖversta() {
    Kort k = bunten[0];
    bunten.RemoveAt(0);
    return k;
  }

  public int AntalKort {
    get { return bunten.Count; }
  }

  public void SlängKorten() {
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

  public int Sök(KortFärg f, KortValör v) {
    int i = 0;
    for (i=0; i<bunten.Count; i++)
      if (bunten[i].Färg==f && bunten[i].Valör==v)
        return i;
    return -1;
  }

  public void NyKortlek() {
    bunten.Clear();
    for (KortFärg f=KortFärg.KLÖVER; f <= KortFärg.SPADER; f++)
      for (KortValör v = KortValör.TVÅ; v <= KortValör.ESS; v++)
        bunten.Add(new Kort(f, v));
  }

  public void Blanda() {
    for (int i=0; i<100; i++) {
      // Låt två slumpmässiga kort byta plats
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
    else if (k1.Färg < k2.Färg)   // uppräkningsvärdena råkar ligga i "rätt" ordning
      return -1;
    else if (k1.Färg > k2.Färg)
      return 1;
    else if (k1.Valör < k2.Valör) 
      return -1;
    else if (k1.Valör > k2.Valör)
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


