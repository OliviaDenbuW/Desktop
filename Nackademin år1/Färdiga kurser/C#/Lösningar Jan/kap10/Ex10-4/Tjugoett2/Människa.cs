
class M�nniska : Spelare {
  public M�nniska(Kortbunt k) : base(k) { }

  public override void Spela() {
    NyttSpel();
    NyttKort();
  }
}
