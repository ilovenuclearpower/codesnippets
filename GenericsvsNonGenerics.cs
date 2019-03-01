using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//This is a program that tests run time performance of ArrayList versus List<>.
public static class Program {
   public static void Main() {
      ValueTypePerfTest();
      ReferenceTypePerfTest();
   }

   private static void ValueTypePerfTest() {
      const Int32 count = 100000000;

      using (new OperationTimer("List<Int32>")) {
         List<Int32> l = new List<Int32>();
         for (Int32 n = 0; n < count; n++) {
            l.Add(n);                // No boxing
            Int32 x = l[n];          // No unboxing
         }
         l = null;  // Make sure this gets garbage collected
      }

      using (new OperationTimer("ArrayList of Int32")) {
         ArrayList a = new ArrayList();
         for (Int32 n = 0; n < count; n++) {
            a.Add(n);                  // Boxing
            Int32 x = (Int32) a[n];    // Unboxing
            //Every time this value is boxed and unboxed it is a memory operation on the managed heap.a
         }
         a = null;  // Make sure this gets garbage collected
      }
   }
//Reference types should perform much much better than value types for non-Generics.
//This is because the primary bottleneck here are the managed boxing operations.
   private static void ReferenceTypePerfTest() {
      const Int32 count = 100000000;

      using (new OperationTimer("List<String>")) {
         List<String> l = new List<String>();
         for (Int32 n = 0; n < count; n++) {
            l.Add("X");                // Reference copy
            String x = l[n];           // Reference copy
         }
         l = null;  // Make sure this gets garbage collected
      }

      using (new OperationTimer("ArrayList of String")) {
         ArrayList a = new ArrayList();
         for (Int32 n = 0; n < count; n++) {
            a.Add("X");                // Reference copy
            String x = (String) a[n];  // Cast check & reference copy
         }
         a = null;  // Make sure this gets garbage collected
      }
   }
}

// This class is useful for doing operation performance timing
//IDisposable allows for explicit disposal of the defined type.
internal sealed class OperationTimer : IDisposable {
   private Stopwatch m_stopwatch;
   private String m_text;
   private Int32  m_collectionCount;

   public OperationTimer(String text) {
      PrepareForOperation();

      m_text = text;
      //Tracks the number of garbagecollects.
      m_collectionCount = GC.CollectionCount(0);

      // This should be the last statement in this
      // method to keep timing as accurate as possible
      m_stopwatch = Stopwatch.StartNew();
   }
//Prints out the runtime performance of the algorithm when this class is disposed of.
//As well as the number of garbage collects performed.
   public void Dispose() {
      Console.WriteLine("{0} (GCs={1,3}) {2}", (m_stopwatch.Elapsed),
         GC.CollectionCount(0) - m_collectionCount, m_text);
   }
//Cleans up afterward.
   private static void PrepareForOperation() {
      GC.Collect();
      GC.WaitForPendingFinalizers();
      GC.Collect();
   }
}
/* Output:
00:00:01.6246959 (GCs=  6) List<Int32>
00:00:10.8555008 (GCs=390) ArrayList of Int32
00:00:02.5427847 (GCs=  4) List<String>
00:00:02.7944831 (GCs=  7) ArrayList of String
*/


//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
