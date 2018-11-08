using System;
using System.Collections.Generic;

 class Tidpunkt {
   // instansvariabler
   int tim, min, sek;
   bool visaSek = true;

   // konstruktorer
   public Tidpunkt() {}

   public Tidpunkt(int t, int m, int s) {
     Sätt(t, m, s);
   }

   public Tidpunkt(int t, int m) : this(t, m, 0) {
		 visaSek = false; 
   }

   public Tidpunkt(int t): this(t, 0) {}

   public int Tim {               
     get { return tim; }
     set {
       if (value>=0 && value<24)
         tim = value;
       else
         Console.WriteLine("Felaktig timme");
     }
   }

   public int Min {               
     get { return min; }
     set {
       if (value>=0 && value<60)
         min = value;
       else
         Console.WriteLine("Felaktig minut");
     }
   }

   public int Sek {             
     get { return sek; }
     set {
       if (value>=0 && value<60)
         sek = value;
       else
         Console.WriteLine("Felaktig sekund");
     }
   } 

   public bool VisaSek {       
     get { return visaSek; }
     set { visaSek = value; }
   } 

   // metoder
   public void Sätt (int t, int m, int s) {
     Tim = t; Min = m; Sek = s;
   } 
      
      public void Ticka() {        // stegar fram tiden en sekund
     if (++sek == 60) {
       sek = 0; ++min;
     }
     if (min == 60) {
       min = 0; ++tim;
     }
     if (tim == 24) 
       tim=0;
   }

   public void Ticka(int antalSek) {
     while (antalSek>0) {
       Ticka();
       antalSek = antalSek - 1;
     }
   }

   public override string ToString () { 
     if (visaSek) 
       return string.Format("{0:d2}:{1:d2}:{2:d2}",tim, min, sek);
     else
       return string.Format("{0:d2}:{1:d2}", tim, min);
   }

 }

 class Flight {
   readonly string number, destination;
   string comment;
   Tidpunkt dep, arr;     // referensvariabler

   // konstruktor
   public Flight (string no,   string dest,
                  int depHour, int depMin,
                  int arrHour, int arrMin) {
     number = no;
     destination = dest;
     dep = new Tidpunkt(depHour, depMin);
     arr = new Tidpunkt(arrHour, arrMin);
   }

   // egenskaper
   public string Comment {
     get { return comment; }
     set { comment = value; }
   }

   public string Number {
     get { return number; }
   }

   public string Destination {
     get { return destination; }
   }

   public Tidpunkt Departure {
     get { return new Tidpunkt(dep.Tim, dep.Min); }
   }

   public Tidpunkt Arrival {
     get { return new Tidpunkt(arr.Tim, arr.Min); }
   }

   // metoder
   public void Delay (int min) {
     dep.Ticka(min*60);
     arr.Ticka(min*60);
     Comment = "Delayed";
   }

   public override string ToString() {
     return number + " " + destination + " " + dep + " "+ comment;
   }
 }

class Resenär {
  List<Flight> f;   

  public Resenär(List<Flight> flights) {
    f = new List<Flight>(flights);
    KontrolleraTider();
  }

  public void LäggTill(Flight nyFlight) {
    if (!f.Contains(nyFlight)) {
      f.Add(nyFlight);
      KontrolleraTider();
    }
  }

  public void TaBort(Flight enFlight) {
    int i = f.IndexOf(enFlight);
    if (i >= 0) 
      f.RemoveAt(i);
  }

  public void Ersätt(int nr, Flight nyFlight) {
    f[nr] = nyFlight;
    KontrolleraTider();
  }

  public void KontrolleraTider() {
    if (f.Count >= 2) {
      Flight förraFlighten = f[0];
      for (int i=1; i< f.Count; i++) {
        Flight dennaFlight = f[i];
        // tider omräknas till minuter
        int m1 = förraFlighten.Arrival.Tim*60 + 
                 förraFlighten.Arrival.Min;
        int m2 = dennaFlight.Departure.Tim*60 + 
                 dennaFlight.Departure.Min;
        if ( m2 < m1)
          m2 += 24*60;  // korrigera för nytt dygn
        if ((m2-m1) > 12*60) {
          Console.WriteLine("Resplanen stämmer inte");
          return;
        }
        förraFlighten = dennaFlight;
      }
    }
  }

  public void SkrivResplan() {
    foreach (Flight fl in f) 
      Console.WriteLine(fl);
  }

  // Test (ingick ej i uppgiften)
  public static void Main() {
    Flight f1 = new Flight("SK123", "Köpenhamn", 18, 0, 18, 45);
    Flight f2 = new Flight("BA999", "London", 19, 0, 20, 5);
    Flight f3 = new Flight("VA000", "Rio de Janeiro", 20, 0, 4, 30);
    List<Flight> v = new List<Flight>();
    v.Add(f1); v.Add(f2); v.Add(f3); 
    Resenär r = new Resenär(v);
    r.SkrivResplan();
    Console.WriteLine(); 
    r.Ersätt(1, new Flight("AF", "London", 18, 50, 19, 45));
    r.SkrivResplan();
    Console.WriteLine();  
    r.LäggTill(new Flight("VA001", "Buenos Aires", 6, 15, 10, 45));
    r.TaBort(f1);
    r.SkrivResplan();      
  }        
}

