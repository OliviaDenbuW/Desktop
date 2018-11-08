 using System;
 using System.Collections.Generic;
 using System.IO;
 using System.Text;

 public class NyTextAnalys {
   public static void Main(string[] args) {    
      StreamReader f = new StreamReader("resord.txt", Encoding.Default);
      HashSet<string> resord = new HashSet<string>();
      string s;
      while((s = f.ReadLine()) != null)  
        resord.Add(s);
      f.Close();     
      f = new StreamReader(args[0], Encoding.Default);
      SortedDictionary<string,int> tab = new SortedDictionary<string,int>
                                         (StringComparer.CurrentCultureIgnoreCase);
      string rad;
      while((rad = f.ReadLine()) != null) {
        string[] a = rad.Split();  // dela upp raden i ord
        // lägg orden i mängden
        foreach (string ord in a)
          if (!resord.Contains(ord)) {
            int antal;
            tab.TryGetValue(ord, out antal);   // finns ordet?
            tab[ord] = antal+1;
          }            
      }
      // skriv ut alla paren
      foreach( KeyValuePair<string, int> par in tab )
        Console.WriteLine(par.Key);
    }
 }

