// F�ljande klass l�ggs i en egen fil Index.cs och kompileras till en dll-fil Index.dll
using System;
using System.IO;
using System.Text;

public class IndexPost : IComparable<IndexPost> {
  public string RegNum = "";   // 6 bytes lagras
  public long Position;        // 8 bytes
  public const int IndexL�ngd = 14;

  public void Write(Stream str) {
    BinaryWriter w = new BinaryWriter(str, Encoding.Default);
    w.Write((string.Format("{0,-6}", RegNum)).ToCharArray());
    w.Write(Position);
  }

  public void Read(Stream str) {
    BinaryReader r = new BinaryReader(str, Encoding.Default);
    char[] buf = r.ReadChars(6); 
    RegNum = new string(buf);
    Position = r.ReadInt64();
  }

   public int CompareTo(IndexPost ip) {
     return RegNum.CompareTo(ip.RegNum);
   }
}  


// H�r f�ljer Fordons-klasserna fr�n kapitel 7.
// Observera att man m�ste l�gga till attributet [Serializable] f�r varje klass
// Dessa klasser l�ggs i en egen fil Fordon.cs och kompileras till en dll-fil Fordon.dll

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

// H�r kommer sj�lva programmet. 
// Det kompileras med referenser till filerna Index.dll och Fordon.dll

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class LetaFordon {

  public static void Main() {
    BinaryFormatter form = new BinaryFormatter();
    FileStream dataFil  = new FileStream("datafil.dat", FileMode.Open);
    FileStream indexFil = new FileStream("indexfil.dat", FileMode.Open);
    IndexPost post = new IndexPost();

    while (true) {
      Console.Write("Registreringsnummer? "); 
      string nr = Console.ReadLine();
      if (nr == null)
        break;

      // bin�rs�kning
      bool funnen = false;
      long postNr=0, f�rsta=0, sista=indexFil.Length/IndexPost.IndexL�ngd-1;
      while (!funnen && f�rsta <= sista) {
        postNr = (f�rsta+sista)/2;
        indexFil.Position = postNr*IndexPost.IndexL�ngd;
        post.Read(indexFil);
        int jfr = post.RegNum.CompareTo(nr);
        if (jfr > 0)
          sista = postNr-1;
        else if (jfr < 0)
          f�rsta = postNr+1;
        else
          funnen = true;
      }
      if (!funnen) 
         Console.WriteLine("Finns ej");
      else {
        dataFil.Position = post.Position;
        Motorfordon m = (Motorfordon) form.Deserialize(dataFil);
        m.Skriv();
      }
    }
  }
}

// SLUT P� �VNINGSEXEMPLET

// F�r att skapa datafilen och indexfilen kan man t.ex. anv�nda f�ljande program
// Det kompileras med referenser till filerna Index.dll och Fordon.dll

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class LagraFordon {

  public static void Main() {
    BinaryFormatter form = new BinaryFormatter();
    FileStream dataFil  = new FileStream("datafil.dat", FileMode.OpenOrCreate);
    FileStream indexFil = new FileStream("indexfil.dat", FileMode.OpenOrCreate);
    IndexPost post = new IndexPost();

    Motorfordon[] a = 
      {new Personbil("PQR999", 5), new Lastbil("VAN777", 7000),
       new Personbil("ABC123", 4), new Lastbil("MER000", 8000),
       new Motorfordon("ZZZ999"),  new Lastbil("TTT000", 9000),
       new Motorfordon("BBB333"),  new Personbil("PPP111", 6)};
    IndexPost[] ix = new IndexPost[a.Length];

    for (int i = 0; i<a.Length; i++) {
      ix[i] = new IndexPost();
      ix[i].RegNum = a[i].regNum;
      ix[i].Position = dataFil.Position;
      form.Serialize(dataFil, a[i]);
    }

    Array.Sort(ix);
    for (int j = 0; j<ix.Length; j++) 
      ix[j].Write(indexFil);
  }
}




