class Fordon {
  protected double hastighet;
  protected double vikt;

  protected Fordon() {}  // behövs för subklassernas skull

  public Fordon(double h, double v) {
    hastighet = h;
    vikt = v;
  }

  public double Hastighet {
    get { return hastighet; }
    set { hastighet = value; }
  }

  public double Vikt {
    get { return vikt; }
  }

  // Fler metoder behövs om det skall vara mer realistiskt. 
}

class Tåg : Fordon {
  int antalVagnar;

  public Tåg(double h, double v, int vagnar) {
    hastighet = h;
    vikt = v;
    antalVagnar = vagnar;
  }

  public void KopplaVagn() {
    antalVagnar = antalVagnar-1;
  }

  // Fler metoder ...
}


