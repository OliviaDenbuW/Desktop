using System;
using System.IO;
using System.Text; 

class L�nga {
  static void Main() {
    Encoding enc = Encoding.GetEncoding(1252);
    Console.Write("Infilens namn? ");
    string namn = Console.ReadLine();
    StreamReader infil = new StreamReader(namn, enc);
    Console.Write("Utfilens namn? ");
    namn = Console.ReadLine();
    StreamWriter utfil = new StreamWriter(namn, false, enc);
    while(true) {
      string rad1 = infil.ReadLine();
      string rad2 = infil.ReadLine();
      if (rad1 == null || rad2 == null)
        break;
      char[] gr = {' '};
      string[] a = rad2.Split(gr, StringSplitOptions.RemoveEmptyEntries);       
      int �lder = int.Parse(a[0]);
      int l�ngd = int.Parse(a[1]);
      double vikt = double.Parse(a[2]);
      if (l�ngd >= 200)
        utfil.WriteLine("{0}\n{1} {2} {3}", rad1, �lder, l�ngd, vikt);
    }
    utfil.Close();
  }
}
