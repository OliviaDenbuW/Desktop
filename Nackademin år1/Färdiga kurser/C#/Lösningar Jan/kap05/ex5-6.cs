using System;
using System.Collections.Generic;

public class C {
  public static double Langd(List<double> v) {
    double l=0;
    foreach (double x in v) 
      l += x * x;
    return Math.Sqrt(l);
  }
}

