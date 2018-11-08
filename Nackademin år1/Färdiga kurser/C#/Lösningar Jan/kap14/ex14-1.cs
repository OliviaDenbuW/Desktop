using System;
public class SmallNumbers {

  public static void WriteSum(byte c) {
    int i = c & 0x0f;
    int j = ((c & 0xf0) >> 4) & 0x0f;
    Console.WriteLine(i+j);
  }

}

