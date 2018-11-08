// Klasserna Person och Person2 skall l�ggas i en egen fil Person.cs 
// och kopileras separat med kommandot:
// csc /t:library Person.cs

using System;

[Serializable]
public class Person  {
  public string namn;
  public int l�ngd;
  public double vikt;
  public int skonr;
  public bool gift;

  public Person(string namn, int l�ngd, double vikt, int skonr, bool gift) {
    this.namn = namn;
    this.l�ngd = l�ngd;
    this.vikt = vikt;
    this.skonr = skonr;
    this.gift = gift;
  }  
}

[Serializable]
public class Person2 : Person {
  public bool kvinna;

  public Person2(string namn, int l�ngd, double vikt, int skonr, bool gift, bool kvinna) 
  : base(namn, l�ngd, vikt, skonr, gift) {
    this.kvinna = kvinna;
  }

  public Person2(Person p, bool kvinna) 
    : this(p.namn, p.l�ngd, p.vikt, p.skonr, p.gift, kvinna) {
  }   
}


// H�r f�ljer l�sningen till uppgiften.
// Koden l�ggs i filen Statistik.cs och kompileras med kommandot:
// csc /r:Person.dll Statistik.cs

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Statistik {

  public static void Main() {
    FileStream infil   = new FileStream("personer.dat", FileMode.Open);
    FileStream damfil  = new FileStream("damer.dat", FileMode.Create);
    FileStream herrfil = new FileStream("herrar.dat", FileMode.Create);
    BinaryFormatter form = new BinaryFormatter();
    Console.WriteLine("Ange f�r var och en av f�ljande personer " +
                       "om det �r en kvinna 'k' eller man 'm'");
    Person p;

    while(infil.Position < infil.Length) {
      p = (Person) form.Deserialize(infil);
      Console.Write(p.namn + "? ");
      bool ok = false;
      while(!ok) {
        string svar = Console.ReadLine();
        if (svar== "k" || svar == "kvinna") {
          form.Serialize(damfil, new Person2(p, true));
          ok=true;
        }
        else if (svar == "m" || svar == "man") {
          form.Serialize(herrfil, new Person2(p, false));
          ok=true;
        }
        else
          Console.WriteLine("Felaktigt svar. Skriv 'k' eller man 'm'");
      }
    }
    infil.Close();
    damfil.Close();
    herrfil.Close();
  }
}


// H�r f�ljer ett testprogram som genererar filen personer.dat
// Koden l�ggs i filen SkapaFil.cs och kompileras med kommandot:
// csc /r:Person.dll SkapaFil.cs

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class SkapaFil {
  public static void Main() {
    FileStream personfil   = new FileStream("personer.dat", FileMode.Create);
    BinaryFormatter form = new BinaryFormatter();
    form.Serialize(personfil, new Person("Nisse", 180, 80, 45, false));
    form.Serialize(personfil, new Person("Eva", 160, 50, 37, true));
    form.Serialize(personfil, new Person("Lisa", 170, 55, 38, false));
    form.Serialize(personfil, new Person("Kalle", 185, 87, 45, true));
    form.Serialize(personfil, new Person("Maria", 165, 54, 38, true));
    form.Serialize(personfil, new Person("Olle", 175, 68, 43, true));
    personfil.Close();
  }
}

