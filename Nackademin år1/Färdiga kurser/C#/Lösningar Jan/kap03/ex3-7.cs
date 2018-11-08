using System;

class C {
  
 public static double Abs(double x) {
    if (x > 0)
      return x;
    else
      return -x;
  }

  public static double Sin(double x) {    
    double term = x, 
           sum  = 0;
    int k = 1;
    
    while (Abs(term) >= 1.0e-5) {
      sum += term;
      k += 2;
      term = -term*x*x/(k-1)/k;
    }
    return sum;
  }

  // Metoden Main ingick inte i uppgiften
  // Den finns med för att man skall kunna testa metoden Sin
  static void Main () {
    while (true) {
      Console.Write("Talet x? ");
      string indata = Console.ReadLine(); 
      if (indata == null)
         break;
      double x = double.Parse(indata);
      Console.WriteLine("sin(x) =  " + Sin(x));
    }
  }
}


