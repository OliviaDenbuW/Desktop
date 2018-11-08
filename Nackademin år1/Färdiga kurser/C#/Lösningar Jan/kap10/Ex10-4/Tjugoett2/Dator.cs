

class Dator : Spelare {
  Spelare motspelare;

  public Dator(Kortbunt k, Spelare mot)
    : base(k) {
    motspelare = mot;
  }

  public override void Spela() {
    NyttSpel();
    while (Poäng < 21 && Poäng < motspelare.Poäng)
      NyttKort();
  }
}