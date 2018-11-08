// Klassen FordonFil innehåller lösningen till uppgiften
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


   public static List<Fordon> LäsIn(string fileName) {
     FileStream inStr = new FileStream(fileName, FileMode.Open);
     BinaryFormatter form = new BinaryFormatter();
     List<Fordon> l = (List<Fordon>) form.Deserialize(inStr);
     inStr.Close();
     return l;
   }
}

// Här följer Fordons-klasserna från kapitel 7.
// Observera att man måste lägga till attributet [Serializable] för varje klass

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
  public int antVäxlar;
  public Cykel(int växl) {
    antVäxlar = växl;
  }
  public override void Skriv() {
    Console.WriteLine("En cykel med " + antVäxlar + " växlar");
  }
}

 

// Följande klass ingick inte i uppgiften
// Den innehåller ett program som testar att lösningen fungerar
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
    List<Fordon> l2 = FordonFil.LäsIn("fordon.dat");
    Console.WriteLine("Inläst från filen:");  
    foreach (Fordon f in l1)  {   
      f.Skriv(); 
      Console.WriteLine();
    }
  }  
}

