 using System;
 using System.Windows.Forms; 

 class Sfar {
   static void Main () {
     String indata = InputBox.Show("Radie?");
     double r = double.Parse(indata); 
     double pi = 3.1416;
     double v = 4*pi*r*r*r/3;
     double a = 4*pi*r*r;
     MessageBox.Show("Volym = " + v + "  Area = " + a);
   }
  }


