using System;    // behövs i testprogrammet

struct Point {
  int x;
  int y;

  // konstruktor
  public Point(int xx, int yy) {
    x = xx; y = yy;
  }

  // egenskaper
  public bool IsEmpty {
    get { return x == 0 && y == 0; }
  }

  public int X {
    get { return x; }
    set { x = value; }
  }

  public int Y {
    get { return y; }
    set { y = value; }
  }
}

class Test {
  static void Main() {
    Point p1 = new Point();  // automatisk parameterlös konstruktor
    Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
    if (p1.IsEmpty)
      Console.WriteLine("p1 är tom");
    Point p2 = new Point(1, 2);  // egen konstruktor
    Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
    p2.X = 3; p2.Y = 4;
    Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
    if (p2.IsEmpty)
      Console.WriteLine("p2 är tom");
  }
}






