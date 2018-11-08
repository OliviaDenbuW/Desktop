using System;

class Grattis {
  static void Main() {
    Console.Write("Ditt personnummer? ");
    string pnr = Console.ReadLine();
    int mån = int.Parse(pnr.Substring(2,2));
    int dag = int.Parse(pnr.Substring(4,2));
    DateTime idag = DateTime.Now;
    if (mån == idag.Month && dag == idag.Day)
      Console.WriteLine("Grattis!");
  }
}
