using System;

class Primtal {

  static void Main() {
    const int maxAntal = 50;
    int[] primTab = new int[maxAntal];
    bool prim;
    int antal=0, tal=1;

    while (antal < maxAntal)  {
      tal++;
      prim=true;
      for (int i=0; i<antal && prim; i++)
        if (tal%primTab[i] == 0)
          prim=false;
      if (prim)
        primTab[antal++] = tal;
    }
    for (int j=0; j<maxAntal; j++)
      Console.WriteLine(primTab[j]);
  }
}

    

