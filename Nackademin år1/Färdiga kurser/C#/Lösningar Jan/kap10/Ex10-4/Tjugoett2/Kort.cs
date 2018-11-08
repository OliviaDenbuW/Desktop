using System.Windows.Forms;
using System.Drawing;

enum KortFärg {KLÖVER, RUTER, HJÄRTER, SPADER};
enum KortValör {TVÅ=2, TRE, FYRA, FEM, SEX, SJU, ÅTTA,  
                 NIO, TIO, KNEKT, DAM,  KUNG, ESS};

class Kort : Button {
  KortFärg  f;
  KortValör v;
  bool synligt;
  Image framsida;
  static Image baksida;
  static string[] färgTab  = {"Kl", "Ru", "Hj", "Sp"};
  static string[] valörTab = {"2", "3", "4", "5", "6", "7", "8",
                              "9", "10", "Kn", "D", "K", "E"};
  public static string BildMapp = @"c:\Bilder\Kort\";

  public Kort(KortFärg fä, KortValör va, bool synl) {
    f = fä;
    v = va;
    framsida = Image.FromFile(BildMapp + färgTab[(int)f] + valörTab[Värde-2] + ".gif");
    if (baksida == null)
      baksida = Image.FromFile(BildMapp + "Bak.gif");
    Size = framsida.Size;
    Synligt = synl;
  }

  public Kort(KortFärg fä, KortValör va) : this(fä, va, false) { }

  public KortFärg Färg {  
    get { return f; }
  }

  public KortValör Valör { 
    get { return v; }
  }

  public int Värde { 
    get { return (int) v; }
  }

  public bool Synligt {
    get { return synligt; }
    set {
      synligt = value;
      if (synligt)
        Image = framsida;
      else 
        Image = baksida;
    }
  } 

  public override string ToString() {
    return färgTab[(int) f] + " " + valörTab[Värde-2];
  }
}

