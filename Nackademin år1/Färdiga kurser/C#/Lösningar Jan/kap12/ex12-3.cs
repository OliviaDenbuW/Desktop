// Klassen FordonFil inneh�ller l�sningen till uppgiften
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

class FordonFil {

   public static void Lagra(List<Fordon> l, string fileName) {     
     FileStream outStr = new FileStream(fileName, FileMode.Create);
     BinaryFormatter form = new BinaryFormatter();
     form.Serialize(outStr,l);
     outStr.Close();
   }


   public static List<Fordon> L�sIn(string fileName) {
     FileStream inStr = new FileStream(fileName, FileMode.Open);
     BinaryFormatter form = new BinaryFormatter();
     List<Fordon> l = (List<Fordon>) form.Deserialize(inStr);
     inStr.Close();
     return l;
   }
}

// H�r f�ljer Fordons-klasserna fr�n kapitel 7.
// Observera att man m�ste l�gga till attributet [Serializable] f�r varje klass

using System;

[Serializable]
public class Fordon {
  public virtual void Skriv() {
    Console.WriteLine("Ett fordon");
  }
}

[Serializable]
public class Motorfordon : Fordon {
  public string regNum;
  public Motorfordon(string nr) {
    regNum = nr;
  }
  public override void Skriv() {
    Console.WriteLine("Ett motorfordon med reg nr: " + regNum);
  }
}

[Serializable]
public class Personbil : Motorfordon {
  public int antPlats;
  public Personbil(string nr, int antal) : base(nr) {
    antPlats = antal;
  }
  public override void Skriv() {
    base.Skriv();
    Console.WriteLine("En personbil med "+antPlats+" platser");
  }
}

[Serializable]
public class Lastbil : Motorfordon {
  public int maxL;
  public Lastbil(string nr, int last) : base(nr) {
    maxL = last;
  }
  public override void Skriv() {
    base.Skriv();
    Console.WriteLine("En lastbil med maximalt " +maxL+ " kg");
  }
} 

[Serializable]
public class Cykel : Fordon {
  public int antV�xlar;
  public Cykel(int v�xl) {
    antV�xlar = v�xl;
  }
  public override void Skriv() {
    Console.WriteLine("En cykel med " + antV�xlar + " v�xlar");
  }
}

 

// F�ljande klass ingick inte i uppgiften
// Den inneh�ller ett program som testar att l�sningen fungerar
class FordonTest {
  public static void Main() {
    List<Fordon> l1 = new List<Fordon>();
    l1.Add(new Personbil("ABC123", 5));
    l1.Add(new Lastbil("XYZ999", 10000));
    l1.Add(new Personbil("PPP000", 6));
    l1.Add(new Cykel(10));
    Console.WriteLine("Innan lagring:");  
    foreach (Fordon f in l1) {     
      f.Skriv();
      Console.WriteLine(); 
    }
    Console.WriteLine("=================");
    FordonFil.Lagra(l1, "fordon.dat");
    List<Fordon> l2 = FordonFil.L�sIn("fordon.dat");
    Console.WriteLine("Inl�st fr�n filen:");  
    foreach (Fordon f in l1)  {   
      f.Skriv(); 
      Console.WriteLine();
    }
  }  
}

