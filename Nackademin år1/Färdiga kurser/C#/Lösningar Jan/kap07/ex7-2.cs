using System;
using System.Collections.Generic;

class Fordon {
  public virtual void Skriv() {
    Console.WriteLine("Ett fordon");
  }
}

class Motorfordon : Fordon {
  string regNum;
  public Motorfordon(string nr) {
    regNum = nr;
  }
  public override void Skriv() {
    Console.WriteLine("Ett motorfordon med reg nr: " + regNum);
  }
}

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

class Bilagare : Person {
  List<Fordon> ford = new List<Fordon>();

  public Bilagare(string na, string adr, int f�dd�r)
  : base(na, adr, f�dd�r) {}

  public void KpFordon(Fordon f) {
    if (!ford.Contains(f))  // Finns fordonet tidigare?
      ford.Add(f);          // Nej, l�gg in det sist i listan   
  }

  public void S�ljFordon(Fordon f) {
    int i = ford.IndexOf(f);
    if (i >= 0)                   // Finns fordonet?
      ford.RemoveAt(i);           // Ja, ta bort det
  } 
}

