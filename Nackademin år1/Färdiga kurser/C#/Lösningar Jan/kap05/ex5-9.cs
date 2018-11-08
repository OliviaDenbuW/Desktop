class C {

  static bool Magisk(int[,] m)
  {
     int sum1 = 0, sum2 = 0;
     int i, j;

     if (m.GetLength(0) != m.GetLength(1))
       return false;
     int n = m.GetLength(0);
  
     // kontrollera diagonalerna
     for (i=0; i<n; i++)
     {
       sum1 += m[i,i];
       sum2 += m[i,n-i-1];
     }
     if (sum1 != sum2)
       return false;
  
     // kontrollera raderna
     for (i=0; i<n; i++)
     {
       for (sum2=0, j=0; j<n; j++)
         sum2 += m[i,j];
       if (sum1 != sum2)
        return false;
     }
  
     // kontrollera kolumnerna
     for (j=0; j<n; j++)
     {
       for (sum2=0, i=0; i<n; i++)
         sum2 += m[i,j];
       if (sum1 != sum2)
        return false;
     }
  
     // kontrollera att alla tal finns med
     for (int tal=1; tal<=n; tal++)
     {
        bool saknas=true;
        for (i=0; i<n && saknas; i++)
          for (j=0; j<n && saknas; j++)
            if (m[i,j] == tal)
              saknas = false;
        if (saknas)
          return false; 
     }
  
     // alla tester avklarade
     return true;
  }

}
  

  

  
