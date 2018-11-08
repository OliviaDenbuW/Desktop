using System;

class Bubbel {

  static void sortera(int[] f, int antal) {
    bool byteHarSkett=true;
    while (byteHarSkett)
    {
      byteHarSkett=false;
      for (int i=0; i<antal-1; i++)
        if (f[i]>f[i+1])
        { // i fel ordning, byt plats
          int temp=f[i]; 
          f[i]=f[i+1]; 
          f[i+1]=temp;
          byteHarSkett=true;
        }
    }
  }

  // metod för att testa (ingick egentligen inte i uppgiften)  
  static void Main() {
    const int maxAntal = 100;
    int[] a = new int[maxAntal];
    int n = 0;
    // läs in tal till ett fält
    Console.WriteLine("Skriv in ett antal heltal");
    while (n < maxAntal) {
      string s = Console.ReadLine();
      if (s == null)
        break;
      a[n++]=int.Parse(s);;
    }
    sortera(a, n);  // testa sorteringsmetoden

    // skriv ut det sorterade fältet
    for (int j=0; j<n; j++)
      Console.WriteLine(a[j]);
  }
}

