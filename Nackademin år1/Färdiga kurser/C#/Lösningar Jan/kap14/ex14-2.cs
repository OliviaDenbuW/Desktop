public class BitArray {
  private byte[] a;
  private int length;

  // Constructor
  public BitArray(int numberOfBits) { 
    int noBytes = (numberOfBits+7)/8;
    a = new byte[noBytes];
    for (int i=0; i < noBytes; i++)  // set all elements false
      a[i]=0;
    length = numberOfBits; 
  }

  public int Length {
    get { return length; }
  }

  public bool this[int k]  {
    get {
      int byte_no = k >> 3;          // byte number in a
      int bit_no  = k & 7;           // bit number within byte
      int m = 0x80;                  // m has the pattern 10000000
      m = m >> bit_no;               // shift right
      return (a[byte_no] & m) != 0;  // is the bit == 1 ?
    }

    set {
      int byte_no = k >> 3;          // byte number in a
      int bit_no  = k & 7;           // bit number within byte
      int m = 0x80;                  // m has the pattern 10000000
      m = m >> bit_no;               // shift right
      if (value) 
        a[byte_no] = (byte) (a[byte_no] | m);
      else
        a[byte_no] = (byte) (a[byte_no] & ~m);
    }
  }
}  

