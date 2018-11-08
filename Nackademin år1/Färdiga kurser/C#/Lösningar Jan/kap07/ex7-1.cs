using System.Collections.Generic;

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

class Student : Person {
  List<Kurs> kurser = new List<Kurs>();

  public Student(string na, string adr, int f�dd�r)
  : base(na, adr, f�dd�r) {}

  public void NyKurs(Kurs k) {
    if (!kurser.Contains(k))  // Finns kursen tidigare?
      kurser.Add(k);          // Nej, l�gg in den sist i listan   
  }

  public void L�mnaKurs(Kurs k) {
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
      studenter.Add(s);          // Nej, l�gg in den sist i listan   

  }

  public void L�mnaKurs(Student s) {
    int i = studenter.IndexOf(s);
    if (i >= 0)                      // Finns studenten?
      studenter.RemoveAt(i);         // Ja, ta bort den
  }  
}


