using System;

class Kalkylator {
  static void Main() {
     char[] avgränsare = {' '};
     char[] op = {'+', '-', '*', '/'};
     double a, b, r = 0;

     while (true) {
       Console.WriteLine("Skriv ett uttryck");
       string indata = Console.ReadLine();
       if (indata == null)
          break;
       string[] d = indata.Split(avgränsare,
                         StringSplitOptions.RemoveEmptyEntries); 
       if (d.Length == 3 && 
           double.TryParse(d[0], out a) &&
           d[1].IndexOfAny(op) >= 0 && 
           double.TryParse(d[2], out b) ) { 
         if (d[1] == "+")
           r = a+b;
         else if (d[1] == "-")
           r = a-b; 
         else if (d[1] == "*")
           r = a*b;
         else 
           r = a/b;
         Console.WriteLine("{0} = {1}", indata, r); 
       }
       else      
         Console.WriteLine("Felaktigt uttryck!");
     }
   }
 }


