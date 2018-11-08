using System.Collections.Generic;

class MyArrays {

  static bool Equals(int[] a, int[] b) {
    if (a.Length != b.Length)
      return false;
    for (int i=0; i<a.Length; i++)
      if (a[i] != b[i])
        return false;
    return true;
  }

  // Lägg till motsvarande metoder för alla övriga enkla standardtyper (double etc.)

  public static bool Equals(object[] a, object[] b) {
    if (a.Length != b.Length)
      return false;
    for (int i=0; i<a.Length; i++)
      if (!a[i].Equals(b[i]))
        return false;
    return true;
  }

  public static bool Equals<T>(List<T> a, List<T> b) {  // generisk
    if (a.Count != b.Count)
      return false;
    for (int i=0; i<a.Count ; i++)
      if (!a[i].Equals(b[i]))
        return false;
    return true;
  }
}
