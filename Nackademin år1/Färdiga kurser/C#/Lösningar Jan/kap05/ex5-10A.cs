using System;

class Morse {

  static string kod(char ch) {

    string[] tab = {".-",    "-...",  "-.-.", "-..",  ".",    "..-.",
                    "--.",   "....",  "..",   ".---", "-.-",  ".-..",
                    "--",    "-.",    "---",  ".--.", "--.-", ".-.",
                    "...",   "-",    "..-",  "...-", ".--",  "-..-",
                    "-.--",  "--..",  ".--.-",".-.-", "---." };
    ch = char.ToLower(ch);   
    if (ch >= 'a' && ch <= 'z')
      return tab[((int) ch) - 'a']; 
    else if (ch == '�')
      return tab[tab.Length-3];  
    else if (ch == '�')
      return tab[tab.Length-2];
    else if (ch == '�')
      return tab[tab.Length-1];
    else if (ch == ' ' || ch == '\t')
      return " ";
    else
      return "";
  }

  static void Main() {
    string s = Console.ReadLine();
    foreach (char c in s)
      Console.Write(kod(c) + ' ');
    Console.WriteLine();
  }
}
  
 
