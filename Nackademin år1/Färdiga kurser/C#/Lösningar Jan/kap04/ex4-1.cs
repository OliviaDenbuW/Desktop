public class Person {
  protected string namn, adress;   // Obs! protected
  protected int �lder;             // Obs! protected

  protected Person() {} // m�ste finnas f�r subklassens skull

  public Person(string namn, string adress, int �lder) {
    this.namn = namn;
    this.adress = adress;
    this.�lder = �lder;
  }

  public string Namn {
    get { return namn; }
  }

  public string Adress {
    get { return adress; }
    set {adress = value;}
  }

  public int  �lder {
    get { return �lder; }
  }
}

public class Bil�gare : Person {
  Bil bilen;

  public Bil�gare(string namn, string adress, int �lder) {  // b�ttre l�sning senare i boken
    this.namn = namn;
    this.adress = adress;
    this.�lder = �lder;
  }

  public Bil Bilen {
    get { return bilen; }
  }

  public void S�ljBil() {
    if (bilen != null) { 
      bilen.S�ld();
      bilen = null;     
    }
  }

  public void K�pBil(Bil nyBil) {
    if (nyBil.�gare == null) {
      bilen = nyBil;
      bilen.K�pt(this);
    }
  }

}

public class Bil {
  string regNr;
  string bilm�rke;
  Bil�gare �gare;

  public Bil(string nr, string fabrikat) {
    regNr = nr; 
    bilm�rke = fabrikat;
  }

  public override string ToString () {
    return regNr + " " + bilm�rke;
  }

  public string RegNr {
    get { return regNr; }
    set { regNr = value; }
  }

  public string Bilm�rke {
    get { return bilm�rke; }
    set { bilm�rke = value; }
  }

  public Bil�gare �gare {
    get { return �gare; }
  }  

  public void S�ld() {   // skall endast anropas av bilens �gare
      �gare = null;
  }

  public void K�pt(Bil�gare ny�gare) {  // skall endast anropas av bilens �gare
      �gare = ny�gare;
  }
}

  

