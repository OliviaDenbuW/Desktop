using System;
using System.IO;
using System.Text; 

class ÄndraFil {
  static void Main() {
    Encoding enc = Encoding.GetEncoding(1252);
    Console.Write("Infilens namn? ");
    string namn = Console.ReadLine();
    StreamReader infil = new StreamReader(namn, enc);
    // skapa en temporär fil
    StreamWriter temp1 = new StreamWriter("temp.tmp", false, enc);
    while(true) {
      string rad = infil.ReadLine();
      string ut = "";
      if (rad == null)
        break;
      foreach (char c in rad) {
        if (c == '\t')
          ut += "   ";
        else if (char.IsUpper(c)) 
          ut += char.ToLower(c);
        else
          ut += c;
      }
      temp1.WriteLine(ut);
    }
    infil.Close(); 
    temp1.Close();

    // kopiera den temporära filen till infilen
    StreamReader temp2 = new StreamReader("temp.tmp", enc);
    StreamWriter utfil = new StreamWriter(namn, false, enc);
    string s = temp2.ReadToEnd();
    utfil.Write(s);
    utfil.Close();
  }
}


