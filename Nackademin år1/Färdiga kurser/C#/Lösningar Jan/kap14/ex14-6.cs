public class C {
  public static double Lön(int år) {
    if (år == 1)
      return 20000;
    else
      return 1.04*Lön(år-1) + 400;
  }    
}
   
