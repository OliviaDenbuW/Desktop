using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Lag : IComparable<Lag> {
  private string namn;
  int antal;
  private int po�ng;
  private int gjordaM�l;
  private int insl�pptaM�l;

  public Lag(string s) {
    namn = s;
  }

  public override string ToString() {
    return namn + "\t" + antal + "\t" + gjordaM�l + "\t" + insl�pptaM�l + "\t" + po�ng;
  }

  public int CompareTo(Lag l) {
    int d1 = gjordaM�l - insl�pptaM�l;
    int d2 = l.gjordaM�l - l.insl�pptaM�l;
    if (po�ng > l.po�ng || (po�ng == l.po�ng && d1 > d2) ||
       (po�ng == l.po�ng && d1 == d2 && namn.CompareTo(l.namn) < 0))
      return -1;
    else
      return 1;
  }

  public static void RegistreraMatch(Lag l1, Lag l2, int i1, int i2) {
    l1.antal++;
    l2.antal++;
    if (i1>i2)
      l1.po�ng += 3;
    else if (i1<i2)
      l2.po�ng += 3;
    else {
      l1.po�ng++;
      l2.po�ng++;
    }
    l1.gjordaM�l += i1;
    l1.insl�pptaM�l += i2;
    l2.gjordaM�l += i2;
    l2.insl�pptaM�l += i1; 
  }
}

public class Fotboll {
    
  public static void Main(string[] args) {  
     StreamReader lagFil = new StreamReader(args[0], Encoding.Default); 
     StreamReader resFil = new StreamReader(args[1], Encoding.Default); 
     Dictionary<string,Lag> tab = new Dictionary<string,Lag>
                                       (StringComparer.CurrentCultureIgnoreCase);
     List<Lag> list = new  List<Lag>();
     string s;
     while ((s=lagFil.ReadLine()) != null) {
       Lag g = new Lag(s); 
       list.Add(g);
       tab.Add(s, g);
     }
     char[] gr = {' ', '\t'};
     while ((s=resFil.ReadLine()) != null) {
       string[] a = s.Split(gr, StringSplitOptions.RemoveEmptyEntries);
       Lag lag1 = tab[a[0]];
       Lag lag2 = tab[a[1]];
       Lag.RegistreraMatch(lag1, lag2, int.Parse(a[2]), int.Parse(a[3]));
     }
     list.Sort();
     foreach (Lag l in list)
      Console.WriteLine(l);     
   }
 }

