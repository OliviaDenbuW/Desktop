public class Euclides {
  public static int Gcd(int m, int n) {
    if (m == n)
      return m;
    else if (m > n)
      return Gcd(m-n, n);
    else
      return Gcd(m, n-m);
  }
}


    
