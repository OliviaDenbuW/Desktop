using System.Drawing;

struct Line {
  public Point P1, P2;
  public Color Color;
  public Line(Point a, Point b, Color c) {
    P1 = a; P2 = b;
    Color = c;
  }
}
