class Falt {

  public static void Rotera(int[] a, int steg) {
    for (int k=1; k<=steg; k++) {
      int temp = a[a.Length-1];
      for (int i=a.Length-1; i>=1; i--)
        a[i] = a[i-1];
      a[0] = temp;
    }
  }

}
