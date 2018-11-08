using BilTest;
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