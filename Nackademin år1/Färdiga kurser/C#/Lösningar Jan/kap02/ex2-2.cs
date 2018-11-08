using System;  // behövs för klassen Test

class Person {
  string namn, adress;
  int ålder;

 // konstruktor 
 public Person(string na, string adr, int år) {
    namn = na;
    adress = adr;
    ålder = år;
  }

  // egenskaper
  public string Namn {
     get {return namn;}
  }

  public string Adress {
     get {return adress;}
     set {adress = value;}
  }

  public int  Ålder {
     get {return ålder;}
  }

  // metoder
  public void FyllerÅr()  {
    ålder++;
  }
}

class Test {
  static void Main() {
    Person p = new Person("Cecilia Skarp", "Tonvägen 1 A", 21);
    Console.WriteLine(p.Namn + ", " + p.Adress + ", " + p.Ålder + " år");
    p.Adress = "Nygatan 2";
    p.FyllerÅr();
    Console.WriteLine(p.Namn + ", " + p.Adress + ", " + p.Ålder + " år");
  }
}
  


