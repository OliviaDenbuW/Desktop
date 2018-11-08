// Lägg till följande klass som beskriver externa jämförare:

public class JfrLängd : IComparer<string> {
  public int Compare(string s1, string s2) {
    return s1.Length - s2.Length;
  }
}

// Ändra sedan i programmet initieringen av mängden tab till:

SortedDictionary<string,int> tab = new SortedDictionary<string,int>(new JfrLängd());


