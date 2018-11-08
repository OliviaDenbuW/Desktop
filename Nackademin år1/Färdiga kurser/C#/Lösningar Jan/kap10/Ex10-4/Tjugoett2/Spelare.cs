
abstract class Spelare {
  Kortbunt leken;
  public Kortbunt hand = new Kortbunt();
  int po‰ng;      // aktuell po‰ng

  public Spelare(Kortbunt k) {
    leken = k;
  }

  public abstract void Spela();   // definieras i subklasserna

  public void NyttSpel() {
    hand.Sl‰ngKorten();
    po‰ng = 0;
  }

  public Kort NyttKort() {
    Kort k = leken.TaBort÷versta();
    hand.L‰gg÷verst(k);
    k.Synligt = true;

    // Ber‰kna ny po‰ng
    int antalEss = 0;
    po‰ng = 0;
    for (int i=0; i<hand.AntalKort; i++) {
      KortValˆr v = hand[i].Valˆr;
      po‰ng += hand[i].V‰rde;
      if (v == KortValˆr.ESS)
        antalEss++;
    }
    for (int j=1; j<=antalEss && po‰ng>21; j++)
      po‰ng -= 13;  // r‰kna ett ess som 1
    return k;       // returnera det nya kortet
  }

  public int Po‰ng {
    get { return po‰ng; }
  }
}