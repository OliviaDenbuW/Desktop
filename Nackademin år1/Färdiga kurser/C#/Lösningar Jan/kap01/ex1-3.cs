 using System;

 class Gallon {
   static void Main () {
     Console.Write("Miles per gallon? ");
     String indata = Console.ReadLine();
     double milesPerGallon = double.Parse(indata);
     double literPerMil = 3.785/milesPerGallon/1.609*10;
     Console.WriteLine(literPerMil + " l/mil");
   }
  }

