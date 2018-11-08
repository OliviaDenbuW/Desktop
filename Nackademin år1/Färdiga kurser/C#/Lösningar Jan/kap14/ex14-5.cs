using System;

class DayNumber {

  public static void Main() {
    Console.Write("Enter date in the format yyyy-mm-dd: ");
    string s  = Console.ReadLine();
    int year  = int.Parse(s.Substring(0,4));
    int month = int.Parse(s.Substring(5,2));
    int day   = int.Parse(s.Substring(8,2));
    int dayNo=day;
    switch (month) {
      case 1: break;
      case 2: dayNo+=31;
              break;
      case 3: dayNo+=59;
              break;
      case 4: dayNo+=90;
              break;
      case 5: dayNo+=121;
              break;
      case 6: dayNo+=151;
              break;
      case 7: dayNo+=183;
              break;
      case 8: dayNo+=212;
              break;
      case 9: dayNo+=242;
              break;
     case 10: dayNo+=273;
              break;
     case 11: dayNo+=303;
              break;
     case 12: dayNo+=334;
              break;
     default: Console.WriteLine("Illegal month");
              Environment.Exit(0);
              break;
   }
   if ((year%4 == 0 && year%100 != 0) || year%400 == 0)
     dayNo++;   // leap year
   Console.WriteLine("The day's number in the year is " + dayNo);
 }
}

