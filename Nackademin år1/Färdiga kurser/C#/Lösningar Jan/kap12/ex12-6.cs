// Klassen Bil läggs i en egen fil och kompileras till en dll-fil, bil.dll
using System.IO;
using System.Text;

public class Bil {
  public string RegNum = "";           // 6 bytes lagras
  public int Årsmodell;               // är 4 bytes
  public const int Längd = 10;

  public void Write(Stream str) {
    BinaryWriter w = new BinaryWriter(str, Encoding.Default);
    w.Write((string.Format("{0,-6}", RegNum)).ToCharArray());
    w.Write(Årsmodell);
  }

  public void Read(Stream str) {
    BinaryReader r = new BinaryReader(str, Encoding.Default);
    char[] buf = r.ReadChars(6); 
    RegNum = new string(buf);
    Årsmodell = r.ReadInt32();
  }
}


// Klassen Merge läggs i en egen fil och kompileras med referens till bil.dll
using System;
using System.IO;

class Merge {
  private static bool TryRead(Bil b, Stream str) {
    if (str.Position < str.Length) {
      b.Read(str);
      return true;
    }
    else
      return false;
  }

  public static void Main(string[] arg) {
    if (arg.Length != 3) {
      Console.WriteLine("Fel antal argument");
      Environment.Exit(1);
    }
    FileStream  f1 = new FileStream(arg[0], FileMode.Open);
    if (f1 == null) {
      Console.WriteLine("Kan inte öppna filen " + arg[0]);
      Environment.Exit(2);
    }
    FileStream  f2 = new FileStream(arg[1], FileMode.Open);
    if (f2 == null) {
      Console.WriteLine("Kan inte öppna filen " + arg[1]);
      Environment.Exit(3);
    }
    FileStream  f3 = new FileStream(arg[2], FileMode.Create);
    if (f3 == null) {
      Console.WriteLine("Kan inte skapa filen " + arg[2]);
      Environment.Exit(4);
    }

    Bil b1 = new Bil(),
        b2 = new Bil();
    bool ok1 = TryRead(b1, f1);
    bool ok2 = TryRead(b2, f2);

    while(ok1 || ok2) {
      if ((ok1 && ok2 && b1.RegNum.CompareTo(b2.RegNum)<0) || !ok2) {
        b1.Write(f3);
        ok1 = TryRead(b1, f1);
      }
      else {
        b2.Write(f3);
        ok2 = TryRead(b2, f2);
      }
    }
    f1.Close(); 
    f2.Close();
    f3.Close();
  }
}

// SLUT PÅ ÖVNINGSUPPGIFTEN

// En bilfil kan skapas med följande program som kompileras separat med referens till bil.dll
using System;
using System.IO;

class SkapaBil {

  public static void Main(string[] arg) {
    if (arg.Length != 1) {
      Console.WriteLine("Fel antal argument");
      Environment.Exit(1);
    }
    FileStream  f = new FileStream(arg[0], FileMode.Create);
    if (f == null) {
      Console.WriteLine("Kan inte skapa filen " + arg[2]);
      Environment.Exit(2);
    }

    Bil b = new Bil();
    while(true) {
      Console.Write("Regnummer? ");
      string s = Console.ReadLine();
      if (s == null)
        break; 
      b.RegNum = s;
      Console.Write("Årsmodell? ");
      s = Console.ReadLine();
      if (s == null)
        break;
      b.Årsmodell = int.Parse(s);
      b.Write(f);
    }
    f.Close();
  }
}

// En bilfil kan läsas med följande program som kompileras separat med referens till bil.dll

using System;
using System.IO;

class VisaBil {

  public static void Main(string[] arg) {
    if (arg.Length != 1) {
      Console.WriteLine("Fel antal argument");
      Environment.Exit(1);
    }
    FileStream  f = new FileStream(arg[0], FileMode.Open);
    if (f == null) {
      Console.WriteLine("Kan inte öppna filen " + arg[0]);
      Environment.Exit(2);
    }
    Bil b = new Bil();
    while(f.Position < f.Length) {
      b.Read(f);
      Console.WriteLine("Regnummer: " + b.RegNum + "   Årsmodell " + b.Årsmodell); 
    }
    f.Close();
  }
}

