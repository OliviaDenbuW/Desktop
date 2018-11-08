using BilTest;
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