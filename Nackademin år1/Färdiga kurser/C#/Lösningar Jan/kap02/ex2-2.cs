using System;  // beh�vs f�r klassen Test

class Person {
  string namn, adress;
  int �lder;

 // konstruktor 
 public Person(string na, string adr, int �r) {
    namn = na;
    adress = adr;
    �lder = �r;
  }

  // egenskaper
  public string Namn {
     get {return namn;}
  }

  public string Adress {
     get {return adress;}
     set {adress = value;}
  }

  public int  �lder {
     get {return �lder;}
  }

  // metoder
  public void Fyller�r()  {
    �lder++;
  }
}

class Test {
  static void Main() {
    Person p = new Person("Cecilia Skarp", "Tonv�gen 1 A", 21);
    Console.WriteLine(p.Namn + ", " + p.Adress + ", " + p.�lder + " �r");
    p.Adress = "Nygatan 2";
    p.Fyller�r();
    Console.WriteLine(p.Namn + ", " + p.Adress + ", " + p.�lder + " �r");
  }
}
  


