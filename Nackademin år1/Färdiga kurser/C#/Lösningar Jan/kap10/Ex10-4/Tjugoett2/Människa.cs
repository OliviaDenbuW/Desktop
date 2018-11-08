
class Människa : Spelare {
  public Människa(Kortbunt k) : base(k) { }

  public override void Spela() {
    NyttSpel();
    NyttKort();
  }
}
