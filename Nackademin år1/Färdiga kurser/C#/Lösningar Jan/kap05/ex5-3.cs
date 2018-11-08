using System.Collections.Generic;

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


// ny version av klassen Lärare, en lista används

class Lärare : Person {
  List<Kurs> kur = new List<Kurs>();

  public Lärare(string namn, string adress, int ålder) {
    this.namn = namn;
    this.adress = adress;
    this.ålder = ålder;
  }


  public void NyKurs(Kurs k) {
    if (kur.IndexOf(k) == -1)
      kur.Add(k); // lägg in ny kurs sist i listan 
  }

  public void AvslutaKurs(Kurs k) {
    kur.Remove(k);     
  }
}


class Student : Person {
  List<Kurs> kur = new List<Kurs>();

  public Student(string namn, string adress, int ålder) {
    this.namn = namn;
    this.adress = adress;
    this.ålder = ålder;
  }

  public void nyKurs(Kurs k) {
    if (kur.IndexOf(k) == -1)
      kur.Add(k); // lägg in ny kurs sist i listan   
  }

  public void LämnaKurs(Kurs k) {
    kur.Remove(k);
  }
}


class Kurs {
  string namn;
  Lärare lär;
  List<Student> stud = new List<Student>();

  public Kurs(string namn) {
    this.namn = namn;
  }

  public string Namn {
    get { return namn; }
  }

  public void nyStudent(Student s) {
    if (stud.IndexOf(s) == -1)
      stud.Add(s); // lägg in ny student sist i listan   
  }

  public void lämnaKurs(Student s) {
    stud.Remove(s);
  }
}



  





