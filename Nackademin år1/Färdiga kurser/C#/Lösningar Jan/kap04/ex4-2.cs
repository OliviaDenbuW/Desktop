class Fordon {
  protected double hastighet;
  protected double vikt;

  protected Fordon() {}  // beh�vs f�r subklassernas skull

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

  // Fler metoder beh�vs om det skall vara mer realistiskt. 
}

class T�g : Fordon {
  int antalVagnar;

  public T�g(double h, double v, int vagnar) {
    hastighet = h;
    vikt = v;
    antalVagnar = vagnar;
  }

  public void KopplaVagn() {
    antalVagnar = antalVagnar-1;
  }

  // Fler metoder ...
}


