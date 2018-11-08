using System.Collections.Generic;

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

class Student : Person {
  List<Kurs> kurser = new List<Kurs>();

  public Student(string na, string adr, int föddÅr)
  : base(na, adr, föddÅr) {}

  public void NyKurs(Kurs k) {
    if (!kurser.Contains(k))  // Finns kursen tidigare?
      kurser.Add(k);          // Nej, lägg in den sist i listan   
  }

  public void LämnaKurs(Kurs k) {
    int i = kurser.IndexOf(k);
    if (i >= 0)                   // Finns kursen?
      kurser.RemoveAt(i);         // Ja, ta bort den
  } 
}

class Kurs {
  string namn;
  List<Student> studenter = new List<Student> ();

  public Kurs(string na) {
    namn = na;
  }

  public string Namn {
     get {return namn;}
  }

  public void NyStudent(Student s) {
    if (!studenter.Contains(s))  // Finns studenten tidigare?
      studenter.Add(s);          // Nej, lägg in den sist i listan   

  }

  public void LämnaKurs(Student s) {
    int i = studenter.IndexOf(s);
    if (i >= 0)                      // Finns studenten?
      studenter.RemoveAt(i);         // Ja, ta bort den
  }  
}


