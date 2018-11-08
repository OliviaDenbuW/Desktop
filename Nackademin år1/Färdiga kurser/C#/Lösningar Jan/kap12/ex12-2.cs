using System;
using System.IO;
using System.Text;

class Cat {

  public static void Main(string[] arg) {
    TextReader inStr;
    if (arg.Length == 0) {  
      inStr = Console.In;
      Copy(inStr);
    }
    else
      for (int i=0; i < arg.Length; i++) {
        try {
          inStr = new StreamReader(arg[i], Encoding.Default);
          Copy(inStr);
        }
        catch (FileNotFoundException) {
          Console.WriteLine("Cannot open file " + arg[i]);
          Environment.Exit(1);
        }
      }
  }

  static void Copy(TextReader inStr) {
    int i;
    while ((i = inStr.Read()) != -1) 
      Console.Write((char)i); 
  }
}

