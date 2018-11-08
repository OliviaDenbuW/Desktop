public class Person {
  protected string namn, adress;   // Obs! protected
  protected int �lder;             // Obs! protected

  protected Person() { } // m�ste finnas f�r subklassens skull

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
    set { adress = value; }
  }

  public int �lder {
    get { return �lder; }
  }
}