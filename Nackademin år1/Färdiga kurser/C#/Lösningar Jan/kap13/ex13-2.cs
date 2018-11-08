// L�gg till f�ljande klass som beskriver externa j�mf�rare:

public class JfrL�ngd : IComparer<string> {
  public int Compare(string s1, string s2) {
    return s1.Length - s2.Length;
  }
}

// �ndra sedan i programmet initieringen av m�ngden tab till:

SortedDictionary<string,int> tab = new SortedDictionary<string,int>(new JfrL�ngd());


