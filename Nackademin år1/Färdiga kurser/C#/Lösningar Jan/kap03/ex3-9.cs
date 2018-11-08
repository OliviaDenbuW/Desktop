using System;

class Exercis {

   enum Grad {Menig, Korpral, Furir, Överfurir, Sergeant, Fanjunkare,
              Fänrik, Löjtnant, Kapten, Major, Överstelöjtnant, Överste,
              Överste1Grad,  Generalmajor, Generallöjtnant, General}                 

   enum Kommando {HögerOm, VänsterOm, HeltOm, FramåtMarsch, Halt, 
                  GivAkt, Manöver, Lediga, HögerVänsterOm}

   static void Main() {
     while(true) {
       Console.Write("Den första militärens kommando? ");
       String s = Console.ReadLine(); 
       if (s == null)
         break;
       Kommando k1 = (Kommando) Enum.Parse(typeof(Kommando), s, true);
       Console.Write("Den andra militärens kommando? ");
       s = Console.ReadLine(); 
       if (s == null)
         break;
       Kommando k2 = (Kommando) Enum.Parse(typeof(Kommando), s, true);
       if (k1 == k2)
          Console.WriteLine(k1);
       else { 
         Console.Write("Den första militärens grad? ");
         s = Console.ReadLine(); 
         if (s == null)
           break;
         Grad g1 = (Grad) Enum.Parse(typeof(Grad), s, true);       
         Console.Write("Den andra militärens grad? ");
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

