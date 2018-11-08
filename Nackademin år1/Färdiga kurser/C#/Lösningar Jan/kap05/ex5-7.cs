using System;

enum RomerskSiffra {I=1, V=5, X=10, L=50, C=100, D=500, M=1000}

class Rom {

  static void Main() {
    while (true) {
      Console.WriteLine("Skriv ett romerskt tal");
      string s = Console.ReadLine();
      if (s == null)
        break;
      // spara siffrornas v�rden i ett f�lt 
      int[] siff = new int[s.Length+1];  // med ett extra element som inneh�ller 0
      siff[s.Length] = 0;
      for (int i=0; i<s.Length; i++) {
        string t = s.Substring(i,1);
        RomerskSiffra r = (RomerskSiffra) Enum.Parse(typeof(RomerskSiffra), t, true);
        siff[i] = (int) r;
      }
      // ber�kna det romerska talets v�rde
      int sum=0;
      for (int k=0; k<siff.Length-1; k++)
        if (siff[k] >= siff[k+1])
          sum += siff[k];
        else
          sum -= siff[k];
      Console.WriteLine("Talets v�rde �r " + sum);
    }
  }
}
