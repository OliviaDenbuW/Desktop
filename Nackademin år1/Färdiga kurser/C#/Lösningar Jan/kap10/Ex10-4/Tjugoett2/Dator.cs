

class Dator : Spelare {
  Spelare motspelare;

  public Dator(Kortbunt k, Spelare mot)
    : base(k) {
    motspelare = mot;
  }

  public override void Spela() {
    NyttSpel();
    while (Po�ng < 21 && Po�ng < motspelare.Po�ng)
      NyttKort();
  }
}