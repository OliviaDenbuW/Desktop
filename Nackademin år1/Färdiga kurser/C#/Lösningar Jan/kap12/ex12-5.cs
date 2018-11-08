// L�gg till f�ljande metod i klassen KontoDatabas
 
  public long NyttKonto(string nyttNamn, string nyAdress) {
    bool nrUpptaget = true;
    long nr=0;
    Random r = new Random();
    while (nrUpptaget) {
      nr = (long) (r.NextDouble() * long.MaxValue);
      nrUpptaget = S�kKonto(nr) != null; 
    }
    Konto nyPost = new Konto();
    nyPost.Nummer = nr;
    nyPost.Namn = nyttNamn;
    nyPost.Adr = nyAdress;

    // kopiera till en tempor�r fil
    string tmpNamn = Path.GetRandomFileName();   // skapar en tempor�r fil
    FileStream tmp = new FileStream(tmpNamn, FileMode.Create);   
    fil.Position = 0;                          // l�s fr�n b�rjan
    bool skriven = false;
    while (fil.Position < fil.Length) {
      post.Read(fil);
      if (!skriven && nr < post.Nummer)  {
        // stoppa in den nya posten
        nyPost.Write(tmp); 
        skriven = true;
      }                  
      post.Write(tmp);
    }
    if (!skriven)
      nyPost.Write(tmp);   // den nya posten hamnade sist

    // kopiera till kontofilen
    fil.Position = 0;  // fr�n b�rjan
    tmp.Position = 0;  // fr�n b�rjan
    while (tmp.Position < tmp.Length) {
      post.Read(tmp);        
      post.Write(fil);
    }
    tmp.Close();
    File.Delete(tmpNamn); 
    return nr; 
  }



// Till�gg av nya konton kan sedan g�ras med f�ljande testprogram

using System;

class NyaKonton {
  public static void Main() {
    KontoDatabas  b = new KontoDatabas();
    b.�ppna("konton.dat");
    Konto k = new Konto(); 
    while(true) {
      Console.Write("Namn? "); 
      string namn = Console.ReadLine();
      if (namn == null)
        break;
      Console.Write("Adress? "); 
      string adr = Console.ReadLine();
      if (adr == null)
        break;
      long nr = b.NyttKonto(namn, adr);
      Console.WriteLine("Nytt konto med nr " + nr);
    }
  }
}

