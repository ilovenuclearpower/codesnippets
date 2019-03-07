using System;

public sealed class Program {
   public static void Main() {
      Int32 v = 5;   // Create an unboxed value type variable.

//Not from the book, but this is an example of a compile-time flag.
#if INEFFICIENT
      // When compiling the following line, v is boxed
      // three times, wasting time and memory.
      Console.WriteLine("{0}, {1}, {2}", v, v, v);
#else
      // The lines below have the same result, execute
      // much faster, and use less memory.
      Object o = v;  // Manually box v (just once).

      // No boxing occurs to compile the following line.
      Console.WriteLine("{0}, {1}, {2}", o, o, o);
#endif
     //The author commented this code fairly well, - but I'd like to add that the reason for this
     //is that the CLR *will* box a value type whenever needed automatically - for example
     //calling the "writeline" and "ToString()" methods.
     //However, boxing and unboxing has performance implications, so avoiding
     //doing so if you know that you are going to need to use a value type representing the same value
     //multiple times.
   }
}

Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
