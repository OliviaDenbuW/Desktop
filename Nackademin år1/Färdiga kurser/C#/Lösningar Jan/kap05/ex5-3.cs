using System.Collections.Generic;

class Person {
  protected string namn, adress;   // Obs! protected
  protected int �lder;             // Obs! protected

  protected Person() {} // m�ste finnas f�r subklassens skull

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
    set {adress = value;}
  }

  public int  �lder {
    get { return �lder; }
  }
}


// ny version av klassen L�rare, en lista anv�nds

class L�rare : Person {
  List<Kurs> kur = new List<Kurs>();

  public L�rare(string namn, string adress, int �lder) {
    this.namn = namn;
    this.adress = adress;
    this.�lder = �lder;
  }


  public void NyKurs(Kurs k) {
    if (kur.IndexOf(k) == -1)
      kur.Add(k); // l�gg in ny kurs sist i listan 
  }

  public void AvslutaKurs(Kurs k) {
    kur.Remove(k);     
  }
}


class Student : Person {
  List<Kurs> kur = new List<Kurs>();

  public Student(string namn, string adress, int �lder) {
    this.namn = namn;
    this.adress = adress;
    this.�lder = �lder;
  }

  public void nyKurs(Kurs k) {
    if (kur.IndexOf(k) == -1)
      kur.Add(k); // l�gg in ny kurs sist i listan   
  }

  public void L�mnaKurs(Kurs k) {
    kur.Remove(k);
  }
}


class Kurs {
  string namn;
  L�rare l�r;
  List<Student> stud = new List<Student>();

  public Kurs(string namn) {
    this.namn = namn;
  }

  public string Namn {
    get { return namn; }
  }

  public void nyStudent(Student s) {
    if (stud.IndexOf(s) == -1)
      stud.Add(s); // l�gg in ny student sist i listan   
  }

  public void l�mnaKurs(Student s) {
    stud.Remove(s);
  }
}



  





