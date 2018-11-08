 using System;

 class Nastlade {
   static void Main () {
     Console.Write("Antal rader? ");
     string s = Console.ReadLine();
     int n = int.Parse(s);
     for (int i=n; i>0; i=i-1) {
       for (int j=1; j<=i; j=j+1)
         Console.Write('+');
       Console.WriteLine();
     }
   }
 }
