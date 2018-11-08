  public static implicit operator int[] (BitArray x) {
    int[] z = new int[x.length];
    for (int i=0; i<x.length; i++) 
      z[i] = x[i] ? 1 : 0;
    return z;
  }    


