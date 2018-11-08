using System.Windows.Forms;
using System.Drawing;

enum KortF�rg {KL�VER, RUTER, HJ�RTER, SPADER};
enum KortVal�r {TV�=2, TRE, FYRA, FEM, SEX, SJU, �TTA,  
                 NIO, TIO, KNEKT, DAM,  KUNG, ESS};

class Kort : Button {
  KortF�rg  f;
  KortVal�r v;
  bool synligt;
  Image framsida;
  static Image baksida;
  static string[] f�rgTab  = {"Kl", "Ru", "Hj", "Sp"};
  static string[] val�rTab = {"2", "3", "4", "5", "6", "7", "8",
                              "9", "10", "Kn", "D", "K", "E"};
  public static string BildMapp = @"c:\Bilder\Kort\";

  public Kort(KortF�rg f�, KortVal�r va, bool synl) {
    f = f�;
    v = va;
    framsida = Image.FromFile(BildMapp + f�rgTab[(int)f] + val�rTab[V�rde-2] + ".gif");
    if (baksida == null)
      baksida = Image.FromFile(BildMapp + "Bak.gif");
    Size = framsida.Size;
    Synligt = synl;
  }

  public Kort(KortF�rg f�, KortVal�r va) : this(f�, va, false) { }

  public KortF�rg F�rg {  
    get { return f; }
  }

  public KortVal�r Val�r { 
    get { return v; }
  }

  public int V�rde { 
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
    return f�rgTab[(int) f] + " " + val�rTab[V�rde-2];
  }
}

