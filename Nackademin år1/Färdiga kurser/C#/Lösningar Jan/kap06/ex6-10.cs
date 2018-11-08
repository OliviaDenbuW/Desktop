using System;
using System.IO;
using System.Text;

class Rövare {
  static void Main () {
    Encoding enc = Encoding.GetEncoding(1252);
    Console.Write("Infilens namn? ");
    string namn = Console.ReadLine();
    StreamReader infil = new StreamReader(namn, enc);
    string konsonanter = "bcdfghjklmnpqrstvxz" +
                         "BCDFGHJKLMNPQRSTVXZ";
    string rad;
    while ((rad = infil.ReadLine()) != null) {
      for (int i=0; i<rad.Length; i++) {
        Console.Write(rad[i]);
        if (konsonanter.IndexOf(rad[i])>=0) {
          if (i<rad.Length-2 && 
              char.ToLower(rad[i+1]) == 'o' && 
              char.ToLower(rad[i+2]) == char.ToLower(rad[i]))
            i += 2;
          else {
            Console.WriteLine();        
            Console.WriteLine("Filen inehåller inte rövarspråk!");
            return;
          }
        }
      }
      Console.WriteLine();
    }      
  }
}

