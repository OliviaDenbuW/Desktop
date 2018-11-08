 using System;

 class Simhopp {
   static void Main () {
     while (true) {
       Console.Write("Hoppets svårighetsgrad? "); 
       String indata = Console.ReadLine();
       if (indata == null)
         break;
       double svårighet = double.Parse(indata);
       double sum = 0;
       double minPoäng=10;
       double maxPoäng=0;
       int nr = 1;
       while (nr <= 5) {     
         Console.Write("Poäng av domare nr " + nr + "? ");
         indata = Console.ReadLine();
         double domarPoäng = double.Parse(indata);
         sum = sum + domarPoäng;
         if (domarPoäng > maxPoäng)
           maxPoäng = domarPoäng;
         if (domarPoäng < minPoäng)
           minPoäng = domarPoäng;
         nr = nr + 1;
       }
       sum = sum - maxPoäng - minPoäng; 
       double hoppPoäng = sum * svårighet;
       Console.WriteLine("Hoppets poäng: " + hoppPoäng);
   }
   }
 }

