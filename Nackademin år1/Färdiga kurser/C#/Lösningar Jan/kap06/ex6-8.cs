using System;
using System.IO;
using System.Text;

class Slumpord {
  string[] ord;
  Random r = new Random();

  public Slumpord(string filnamn) {
    Encoding enc = Encoding.GetEncoding(1252);
    StreamReader infil = new StreamReader(filnamn, enc);
    string s = "";
    string rad;
    while ((rad = infil.ReadLine()) != null)
      s = s + " " + rad; 
    char[] gr = {' ', '\t', ',', ';'};
    ord = s.Split(gr, StringSplitOptions.RemoveEmptyEntries);     
  }

  public string EttOrd() {
    // slumpa fram ordets nummer
    return ord[r.Next(0,ord.Length)];
  }
}

// Följande klass ingick egentligen inte i uppgiften
class OrdTest {
  static void Main() {
    Console.Write("Infilens namn? ");
    string namn = Console.ReadLine(); 
    Slumpord sl = new Slumpord(namn);
    for (int i=0; i<25; i++)
      Console.WriteLine(sl.EttOrd()); 
  }
}

