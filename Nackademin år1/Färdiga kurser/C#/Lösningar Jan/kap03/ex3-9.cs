using System;

class Exercis {

   enum Grad {Menig, Korpral, Furir, �verfurir, Sergeant, Fanjunkare,
              F�nrik, L�jtnant, Kapten, Major, �verstel�jtnant, �verste,
              �verste1Grad,  Generalmajor, Generall�jtnant, General}                 

   enum Kommando {H�gerOm, V�nsterOm, HeltOm, Fram�tMarsch, Halt, 
                  GivAkt, Man�ver, Lediga, H�gerV�nsterOm}

   static void Main() {
     while(true) {
       Console.Write("Den f�rsta milit�rens kommando? ");
       String s = Console.ReadLine(); 
       if (s == null)
         break;
       Kommando k1 = (Kommando) Enum.Parse(typeof(Kommando), s, true);
       Console.Write("Den andra milit�rens kommando? ");
       s = Console.ReadLine(); 
       if (s == null)
         break;
       Kommando k2 = (Kommando) Enum.Parse(typeof(Kommando), s, true);
       if (k1 == k2)
          Console.WriteLine(k1);
       else { 
         Console.Write("Den f�rsta milit�rens grad? ");
         s = Console.ReadLine(); 
         if (s == null)
           break;
         Grad g1 = (Grad) Enum.Parse(typeof(Grad), s, true);       
         Console.Write("Den andra milit�rens grad? ");
         s = Console.ReadLine(); 
         if (s == null)
           break;
         Grad g2 = (Grad) Enum.Parse(typeof(Grad), s, true); 
         if (g1 > g2)
           Console.WriteLine(k1);
         else if (g2 > g1)
           Console.WriteLine(k2);
         else
           Console.WriteLine("Konflikt"); 
       }
     }            
   }
}

