  public static BitArray operator&(BitArray x, BitArray y) {
    if (x.length != y.length)
      throw new Exception("Different lengths");
    BitArray z = new BitArray(x.length);
    for (int i=0; i<x.a.Length; i++) 
      z.a[i] = (byte) (x.a[i] & y.a[i]);
    return z;
  }

 

