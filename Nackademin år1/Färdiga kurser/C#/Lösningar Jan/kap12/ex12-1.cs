
using System;
using System.IO;
using System.Text;

class Hemlig {

  public static void Main(){
    Console.WriteLine("Skriv in kodningstabellen");
    Console.WriteLine("abcdefghijklmnopqrstuvwxyzåäö");
    char[] tab = new char[29];
    for (char c='a'; c<='z'; c++) 
      tab[nummer((char) Console.Read())]= c;
    tab[nummer((char) Console.Read())]= 'å';
    tab[nummer((char) Console.Read())]= 'ä';
    tab[nummer((char) Console.Read())]= 'ö';

    // Läs och avkoda den hemliga texten
    StreamReader fil = new StreamReader("hemlig.txt", Encoding.Default);
    int i;
    while ((i=fil.Read()) != -1) {
      char c = (char) i;
      int n = nummer(c);  // bokstavens nummer
      if (n>=0)
        Console.Write(tab[n]);  // bokstav
      else
        Console.Write(c);      // annat tecken
    }
  }

  static int nummer(char c) { // returnerar bokstavens nr i alfabetet
    c = char.ToLower(c);
    if (c>='a' && c<='z')
      return (int) c - (int) 'a';
    else if (c=='å' || c=='Å')
      return 26;
    else if (c=='ä' || c=='Ä')
      return 27;
    else if (c=='ö' || c=='Ö')
      return 28;
    return -1; // ingen bokstav
  }

} 


