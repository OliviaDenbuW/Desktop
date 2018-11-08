public class Person {
  protected string namn, adress;   // Obs! protected
  protected int ålder;             // Obs! protected

  protected Person() { } // måste finnas för subklassens skull

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
    set { adress = value; }
  }

  public int Ålder {
    get { return ålder; }
  }
}