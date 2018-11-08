public class Person {
  protected string namn, adress;   // Obs! protected
  protected int ålder;             // Obs! protected

  protected Person() {} // måste finnas för subklassens skull

  public Person(string namn, string adress, int ålder) {
    this.namn = namn;
    this.adress = adress;
    this.ålder = ålder;
  }

  public string Namn {
    get { return namn; }
  }

  public string Adress {
    get { return adress; }
    set {adress = value;}
  }

  public int  Ålder {
    get { return ålder; }
  }
}

public class Bilägare : Person {
  Bil bilen;

  public Bilägare(string namn, string adress, int ålder) {  // bättre lösning senare i boken
    this.namn = namn;
    this.adress = adress;
    this.ålder = ålder;
  }

  public Bil Bilen {
    get { return bilen; }
  }

  public void SäljBil() {
    if (bilen != null) { 
      bilen.Såld();
      bilen = null;     
    }
  }

  public void KöpBil(Bil nyBil) {
    if (nyBil.Ägare == null) {
      bilen = nyBil;
      bilen.Köpt(this);
    }
  }

}

public class Bil {
  string regNr;
  string bilmärke;
  Bilägare ägare;

  public Bil(string nr, string fabrikat) {
    regNr = nr; 
    bilmärke = fabrikat;
  }

  public override string ToString () {
    return regNr + " " + bilmärke;
  }

  public string RegNr {
    get { return regNr; }
    set { regNr = value; }
  }

  public string Bilmärke {
    get { return bilmärke; }
    set { bilmärke = value; }
  }

  public Bilägare Ägare {
    get { return ägare; }
  }  

  public void Såld() {   // skall endast anropas av bilens ägare
      ägare = null;
  }

  public void Köpt(Bilägare nyÄgare) {  // skall endast anropas av bilens ägare
      ägare = nyÄgare;
  }
}

  

