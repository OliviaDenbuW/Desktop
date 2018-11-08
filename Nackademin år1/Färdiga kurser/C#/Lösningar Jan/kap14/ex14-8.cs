 using System;
 class Rapport {

   public static int BinS�k(string s�kt, Agent[] a, int f�rsta, int sista) {	
     if (f�rsta <= sista) {
       int mitten = (f�rsta + sista)/2;
       if (string.Compare(s�kt, a[mitten].Namn, true) < 0)
         return BinS�k(s�kt, a, f�rsta, mitten-1);
       else if (string.Compare(s�kt, a[mitten].Namn, true) > 0)
         return BinS�k(s�kt, a, mitten+1, sista);
       else // lika
         return mitten;
     }
     else
       return -1;  // inte funnen 
   }

   static void L�ggIn(Agent nyAgent, Agent[] a, int antal) {
     int i=antal-1;
     for (; i >= 0 && 
             string.Compare(nyAgent.Namn, a[i].Namn, true) < 0; i--)
       a[i+1] = a[i];    // flytta ett steg �t h�ger
     a[i+1] = nyAgent;   // l�gg in den nya agenten
   }

   static void Main () {
    Agent[] a = new Agent[100];
    int antalAgenter = 0;
     // L�s in f�rs�ljningsuppgifter
     while (true) {
       Console.Write("Agent? ");
       string nn = Console.ReadLine();
       if (nn == null) // inga fler uppgifter
         break;
       Console.Write("Belopp? "); 
       double belopp = double.Parse(Console.ReadLine());
       // s�k efter namnet nn
       int i;
       if ((i = BinS�k(nn, a, 0, antalAgenter-1)) == -1) {
         Agent nyAgent = new Agent(nn);
         nyAgent.Summa = belopp;
         L�ggIn(nyAgent, a, antalAgenter);
         antalAgenter++;
       }
       else  
         a[i].Summa += belopp;
     }
     // Skriv tabell
     Console.WriteLine("Belopp    Arvode".PadLeft(40));
     Console.WriteLine("======    ======".PadLeft(40));
     for (int j=0; j<antalAgenter; j++) 
       Console.WriteLine(a[j].Namn.PadRight(20) +
                         a[j].Summa.ToString().PadLeft(10) +
                         a[j].Arvode.ToString().PadLeft(10));
   }														
 }

 class Agent {
   const double gr�ns=50000;
   const double proc1=0.1;
   const double proc2=0.15;
   // instansvariabler
   string namn;
   double summa;
   // konstruktor
   public Agent(string n) { 
     namn=n;
   }
   // egenskaper
   public string Namn {
     get { return namn; }
   }
   public double Summa {
     get { return summa; }
     set { summa = value; }
   }
   public double Arvode {   // ber�knar arvodet
     get {
       if (summa <= gr�ns)
         return summa * proc1;
       else
         return gr�ns * proc1 + (summa-gr�ns) * proc2;
     }
   }
 }

