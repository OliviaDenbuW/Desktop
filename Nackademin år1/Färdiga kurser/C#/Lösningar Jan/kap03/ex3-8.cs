using System;

class C {

 public static double Abs(double x) {
    if (x > 0)
      return x;
    else
      return -x;
  }
  
  public static double Sqr(double x) {
    double g = x;
    double gny = x / 2;   // första gissning
    while (Abs(g-gny)>1e-6) {
      g = gny;
      gny = (g + x/g)/2;
    }
    return gny;
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
      Console.WriteLine("Sqr(x) =  " + Sqr(x));
    }
  }
}

