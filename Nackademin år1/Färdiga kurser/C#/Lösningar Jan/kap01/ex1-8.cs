 using System;

 class Simhopp {
   static void Main () {
     while (true) {
       Console.Write("Hoppets sv�righetsgrad? "); 
       String indata = Console.ReadLine();
       if (indata == null)
         break;
       double sv�righet = double.Parse(indata);
       double sum = 0;
       double minPo�ng=10;
       double maxPo�ng=0;
       int nr = 1;
       while (nr <= 5) {     
         Console.Write("Po�ng av domare nr " + nr + "? ");
         indata = Console.ReadLine();
         double domarPo�ng = double.Parse(indata);
         sum = sum + domarPo�ng;
         if (domarPo�ng > maxPo�ng)
           maxPo�ng = domarPo�ng;
         if (domarPo�ng < minPo�ng)
           minPo�ng = domarPo�ng;
         nr = nr + 1;
       }
       sum = sum - maxPo�ng - minPo�ng; 
       double hoppPo�ng = sum * sv�righet;
       Console.WriteLine("Hoppets po�ng: " + hoppPo�ng);
   }
   }
 }

