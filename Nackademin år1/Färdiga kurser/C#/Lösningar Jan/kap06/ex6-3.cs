 using System;
 using System.Windows.Forms;

 class BilHyra2 {
   static void Main() {
     bool klar = false;
     while (!klar) {
       string s = InputBox.Show
                   ("Antal dagar, pris/dag och bil"); 
       if (s == null)
         return;            
       char[] avgr�nsare = {' ', ';'};
       string[] a = s.Split(avgr�nsare,
                         StringSplitOptions.RemoveEmptyEntries); 
       int antalDagar;
       double dagsPris; 
       if (a.Length == 3 && 
           int.TryParse(a[0], out antalDagar) && 
           double.TryParse(a[1], out dagsPris) ) {  
         string bil = a[2];
         double tot = dagsPris * antalDagar;
         s = string.Format("Totalt pris f�r {0}: {1:c}", bil, tot);
         MessageBox.Show(s, "Resultat");
         klar = true;
       }
       else 
         MessageBox.Show("Felaktiga indata. F�rs�k igen!", "Felmeddelande"); 
     }                 
   }
 }

