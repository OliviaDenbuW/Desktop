using System;
using System.IO;
using System.Text; 

class Textanalys {
  static void Main() {
    Encoding enc = Encoding.GetEncoding(1252);
    Console.Write("Infilens namn? ");
    string namn = Console.ReadLine();
    StreamReader f = new StreamReader(namn, enc);
    int antalSiffror=0, antalBokst‰ver=0, antal÷vriga=0;
    while (true) {
      string rad = f.ReadLine();
      if (rad == null)
        break;
      foreach (char c in rad) {
        if (char.IsDigit(c))
         antalSiffror++;
       else if (char.IsLetter(c)) 
         antalBokst‰ver++;
       else
         antal÷vriga++;
      }
    }
    Console.WriteLine("Antal siffror:   " + antalSiffror);
    Console.WriteLine("Antal bokst‰ver: " + antalBokst‰ver);
    Console.WriteLine("Antal ˆvriga:    " + antal÷vriga);
  }
} 

