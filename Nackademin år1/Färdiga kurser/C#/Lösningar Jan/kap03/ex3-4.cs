using System;

class Palindrom { 

  public static bool �rPalindrom(string s) {
    int i, j;
    for (i=0, j=s.Length-1; i < j; i++, j--)
      if (s[i] != s[j])
        return false;
    return true;
  } 

  static void Main() {
    Console.Write("Skriv ett ord: ");
    string ord = Console.ReadLine();
    if (�rPalindrom(ord))
      Console.WriteLine("Ordet �r ett palindrom");
    else
      Console.WriteLine("Ordet �r inte ett palindrom");     
  }
}
