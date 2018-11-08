using System;
using System.Threading;
using System.Collections.Generic;

class BufElement<T> {     // hjälpklass
   public T elem;
   public ThreadPriority pri;

   public BufElement(T e, ThreadPriority p) {
     elem=e; pri=p;
   }
 }

public class MyBuffer<T> {
  private List<BufElement<T>> q = new List<BufElement<T>>();
 
  public int Count {  
    get { return q.Count; }
  }

  public void Put(T elem) { 
    lock (this) {
      ThreadPriority p = Thread.CurrentThread.Priority;
      int i;     
      for (i=q.Count-1; i>=0 && p > q[i].pri; i--)
        ;    
      q.Insert(i+1, new BufElement<T>(elem,p));
      Monitor.Pulse(this);
    }
  }

  public T Get() {  
    lock (this) {
      while (q.Count == 0)
        Monitor.Wait(this);
      T res = q[0].elem;     
      q.RemoveAt(0);
      return res;
    }
  }
}


