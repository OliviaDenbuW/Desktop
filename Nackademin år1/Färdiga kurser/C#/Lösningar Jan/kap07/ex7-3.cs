using System;
using System.Collections.Generic;

interface ITing {
  void Skriv();
}

abstract class Ägare {
  List<ITing> tingen = new List<ITing>();

  public void Köp(ITing t) {
    if (!tingen.Contains(t))  // Finns detta ting tidigare?
      tingen.Add(t);          // Nej, lägg in det sist i listan   
  }

  public void sälj(ITing t) {
    int i = tingen.IndexOf(t);
    if (i >= 0)                     // Finns detta ting?
      tingen.RemoveAt(i);           // Ja, ta bort det
  }

  public ITing EttTing(int n) {     // returnerar ting nummer n
    if (n>=0 && n<tingen.Count)
      return tingen[n];
    else
      return null;
  }

  public int AntalTing {
    get { return tingen.Count; }
  }

  public void SkrivAllaTing() {
    foreach (ITing t in tingen )
      t.Skriv();
  }
}

class Fordon : ITing {
  public virtual void Skriv() {      // implementering av metoden Skriv() i ITing
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

class Person : Ägare {
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

class JuridiskPerson : Ägare, ITing {
  string namn, organisationsnr; 

  public JuridiskPerson(string na, string nr) {
    namn = na;
    organisationsnr = nr;
  }

  // egenskaper
  public string Namn {
    get {return namn;}
  }
 
  public string Organisationsnr {
    get {return organisationsnr;}
  }

  public virtual void Skriv() {  // implementering av metoden Skriv() i ITing
    Console.WriteLine("Organisationsnamn: " + namn);
    Console.WriteLine("Organisationsnr:   " + organisationsnr);
    Console.WriteLine("Äger följande ting:");
    SkrivAllaTing();
  }    
}





