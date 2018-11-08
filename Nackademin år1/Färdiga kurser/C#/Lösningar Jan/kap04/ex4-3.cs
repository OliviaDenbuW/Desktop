class Person {
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

class Lärare : Person {
  Kurs k1, k2, k3, k4, k5;   // högst 5 kurser per lärare (bättre med array) 
  int antalKurser;

  public Lärare(string namn, string adress, int ålder) {
    this.namn = namn;
    this.adress = adress;
    this.ålder = ålder;
  }


  public void NyKurs(Kurs k) {
    if (antalKurser == 5) 
      return;  // kan inte ge fler kurser;
    antalKurser = antalKurser+1;
    if (k1 == null) 
      k1 = k;  
    else if (k2 == null) 
      k2 = k;    
    else if (k3 == null) 
      k3 = k;
    else if (k4 == null) 
      k4 = k;
    else if (k5 == null) 
      k5 = k;
  }

  public void AvslutaKurs(Kurs k) {
    antalKurser = antalKurser - 1;
    if (k == k1) 
      k1 = null;
    else if (k == k2)
      k2 = null;
    else if (k == k3)
      k3 = null;
    else if (k == k4)
      k4 = null;
    else if (k == k5)
      k5 = null;
    else
      antalKurser = antalKurser + 1 ;  // felaktig parameter, återställ     
  }
}

class Kurs {
  // Diverse instansvariabler och metoder
}

