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

  public void SlåIhop(Kortbunt annan) {
    while (annan.AntalKort > 0) 
      LäggÖverst(annan.TaBortÖversta());
  }
}

class SvältaRäv {
  public static void Main() {
    Kortbunt[] spelare = new Kortbunt[2];
    spelare[0] = new Kortbunt();
    spelare[1] = new Kortbunt();
    int nästa = 0;
    Kortbunt b = new Kortbunt();
    b.NyKortlek();
    b.Blanda();
    for (int i=1; i<=26; i++) {
      spelare[0].LäggÖverst(b.TaBortÖversta());
      spelare[1].LäggÖverst(b.TaBortÖversta());
    }

    while (spelare[0].AntalKort >0 && spelare[1].AntalKort >0) {
      Kort första = spelare[nästa].TaBortÖversta();
      b.LäggÖverst(första);
      Console.WriteLine("Spelare " + nästa + " lägger ut " + första);
      nästa = (nästa+1) % 2;
      while (b.AntalKort > 0 && spelare[nästa].AntalKort >0) {
        Kort k=spelare[nästa].TaBortÖversta();
        b.LäggÖverst(k);
        Console.WriteLine("Spelare " + nästa + " lägger ut " + k);
        if (k.Färg == första.Färg && 
           (k.Valör > första.Valör || första.Valör == KortValör.ESS)) {
            spelare[nästa].SlåIhop(b);
          Console.WriteLine("Spelare " + nästa + " tar korten");
          Console.WriteLine();
          Console.WriteLine("Spelare 0 har nu " + spelare[0].AntalKort + " kort");
          Console.WriteLine("Spelare 1 har nu " + spelare[1].AntalKort + " kort");
        }
        nästa = (nästa+1) % 2;
      }
    }
    if (spelare[0].AntalKort == 0)
      Console.WriteLine("Spelare 1 vann"); 
    else 
      Console.WriteLine("Spelare 0 vann");  
  }
}
