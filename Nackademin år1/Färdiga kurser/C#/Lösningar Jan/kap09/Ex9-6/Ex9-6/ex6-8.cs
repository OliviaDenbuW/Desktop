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
