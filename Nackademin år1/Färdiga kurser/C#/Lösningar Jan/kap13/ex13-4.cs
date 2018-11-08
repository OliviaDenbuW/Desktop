using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Lotteri {

  public static void Main() {
    Console.Write("Lägsta lottnummer? ");
    string s = Console.ReadLine();
    int min = int.Parse(s);
    Console.Write("Högsta lottnummer? ");
    s = Console.ReadLine();
    int max = int.Parse(s);
    Random slump = new Random();
    List<KeyValuePair<int,string>> list = new List<KeyValuePair<int,string>>();
    SortedDictionary<int,string> tab = new SortedDictionary<int,string>();
    Console.Write("Filens namn? ");
    s = Console.ReadLine(); 
    Encoding enc = Encoding.Default; 
    StreamReader infil = new StreamReader(s, enc);
    while ((s=infil.ReadLine()) != null) {
      int i = s.IndexOf(' ');
      int antalVinster = int.Parse(s.Substring(0,i));
      string vinst = s.Substring(i+1);
      while (antalVinster>0) {
        int vinstNr = slump.Next(min,max);
        if (!tab.ContainsKey(vinstNr)) {
          list.Add(new KeyValuePair<int,string>(vinstNr, vinst));
          tab.Add(vinstNr, vinst);
          antalVinster--;
        }
      }
    }

    StreamWriter fil1 = new StreamWriter("vinstlista1.txt", false, enc);
    foreach (KeyValuePair<int,string> par in list)
      fil1.WriteLine(par.Key + "  " + par.Value);
    fil1.Close();

    StreamWriter fil2 = new StreamWriter("vinstlista2.txt", false, enc);
    foreach (KeyValuePair<int,string> par in tab)
      fil2.WriteLine(par.Key + "  " + par.Value);
    fil2.Close();

    while (true) {
      Console.Write("Ditt lottnummer? ");
      s = Console.ReadLine();
      if (s == null)
        break;
      string vinst;
      tab.TryGetValue(int.Parse(s), out vinst);
      if (vinst ==  null)
        Console.WriteLine("Nitlott");
      else
        Console.WriteLine("Vinst: " + vinst); 
    }            
  }
}
  
    
    
  
