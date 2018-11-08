using System;
using System.IO;
using System.Text; 

class Temperatur {
  static void Main() {
    Encoding enc = Encoding.GetEncoding(1252);
    StreamReader f = new StreamReader("temp.txt", enc);
    string s = f.ReadToEnd();
    char[] gr = {' ', '\n'};
    string[] a = s.Split(gr, StringSplitOptions.RemoveEmptyEntries);                         
    double sum = 0;
    double max = double.MinValue;
    foreach (string d in a) {
      double temp = double.Parse(d);
      sum += temp;
      if (temp > max)
        max = temp;
    }
    Console.WriteLine("Medeltemperatur:{0,8:f1}", sum/a.Length);
    Console.WriteLine("Högsta temperatur:{0,8:f1}", max);
  }
} 

