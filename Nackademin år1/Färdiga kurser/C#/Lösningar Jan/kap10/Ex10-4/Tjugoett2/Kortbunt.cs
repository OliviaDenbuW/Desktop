using System;
using System.Collections.Generic;

 class Kortbunt {
   List<Kort> bunten = new List<Kort>();
   static Random rand = new Random(); 
   public void L�gg�verst(Kort k) {
     bunten.Insert(0, k);
   }
   public Kort TaBort�versta() {
     Kort k = bunten[0];
     bunten.RemoveAt(0);
     return k;
   }
   public int AntalKort {
     get { return bunten.Count; }
   }
   public void Sl�ngKorten() {
     bunten.Clear();
   }
   public Kort this[int nr] {     // indexerare
     get { return bunten[nr]; }
   }
   public Kort TaBort(int nr) {
     Kort k = bunten[nr];
     bunten.RemoveAt(nr);
     return k;
   }
   public int S�k(KortF�rg f, KortVal�r v) {
     int i = 0;
     for (i=0; i<bunten.Count; i++)
       if (bunten[i].F�rg==f && bunten[i].Val�r==v)
         return i;
     return -1;
   }
   public void NyKortlek() {
     bunten.Clear();
     for (KortF�rg f=KortF�rg.KL�VER; f <= KortF�rg.SPADER; f++)
       for (KortVal�r v = KortVal�r.TV�; v <= KortVal�r.ESS; v++)
         bunten.Add(new Kort(f, v));
   } 
   public void Blanda() {
     for (int i=0; i<100; i++) {
       // L�t tv� slumpm�ssiga kort byta plats
       int a = rand.Next(bunten.Count);
       int b = rand.Next(bunten.Count);
       Kort k = bunten[a];
       bunten[a] = bunten[b];
       bunten[b] = k;
     }
   }
 }

