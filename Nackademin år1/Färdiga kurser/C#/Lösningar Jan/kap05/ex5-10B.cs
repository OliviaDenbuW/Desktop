using System;

class FromMorse {
  static string[] tab = {".-",    "-...",  "-.-.", "-..",  ".",    "..-.",
                         "--.",   "....",  "..",   ".---", "-.-",  ".-..",
                         "--",    "-.",    "---",  ".--.", "--.-", ".-.",
                         "...",   "-",    "..-",  "...-", ".--",  "-..-",
                         "-.--",  "--..",  ".--.-",".-.-", "---." };

  static char ToLetter(string s) {
    int j = Array.IndexOf(tab, s);
    if (j < 0)
      return '?';  // markerar felaktig morsekod        
    else if (j < tab.Length-3)
      return (char) ((int) 'a' + j);    // a - z
    else if (j == tab.Length-3)
      return 'å';
    else if ( j == tab.Length-2)
      return 'ä';
    else 
      return 'ö';
  }

  static void Main() {
    while (true) {
      string s = Console.ReadLine();
      if (s == null)
        break;
      s = s.Trim();
      while (s.Length > 0) {
        int j=s.IndexOf(' ');
        if (j >= 0) {
          Console.Write(ToLetter(s.Substring(0,j)));    // skriv ut bokstaven
          if (s[j+1] == ' ') {
            Console.Write(' ');                         // nytt ord
            s = s.Substring(j+2);
          }
          else
            s = s.Substring(j+1);
        }
        else {                                          // sista bokstaven på raden
          Console.Write(ToLetter(s));                   // skriv ut bokstaven
          s = "";
          Console.WriteLine();
        }
      }
    }
  }
}
