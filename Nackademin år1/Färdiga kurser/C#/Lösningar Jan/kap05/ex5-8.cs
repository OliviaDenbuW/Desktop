class C {
  public static bool Symmetrisk(int[,] m) {
    for (int i=0; i<m.GetLength(0); i++)
      for (int j=0; j<m.GetLength(1); j++)
        if (m[i,j] != m[j,i])
          return false;
    return true;
  }
}


