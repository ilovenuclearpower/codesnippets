using System;

public static class Program {
    public static void Main() {
       /************************* First Example *************************/
       Base b = new Base();

       // Calls Dispose by using b's type: "Base's Dispose"
       b.Dispose();

       // Calls Dispose by using b's object's type: "Base's Dispose"
       ((IDisposable)b).Dispose();


       /************************* Second Example ************************/
       Derived d = new Derived();

       // Calls Dispose by using d's type: "Derived's Dispose"
       d.Dispose();

       // Calls Dispose by using d's object's type: "Derived's Dispose"
       ((IDisposable)d).Dispose();


       /************************* Third Example *************************/
       b = new Derived();
       //I am pretty sure this is an error.
       //The cast in the second call will convert b to Base 
       //before Dispose() is called.
       //Will investigate further.
       // Calls Dispose by using b's type: "Base's Dispose"
       b.Dispose();

       // Calls Dispose by using b's object's type: "Derived's Dispose"
       ((IDisposable)b).Dispose();
    }
}

// This class is derived from Object and it implements IDisposable
internal class Base : IDisposable {
   // This method is implicitly sealed and cannot be overridden
   public void Dispose() {
      Console.WriteLine("Base's Dispose");
   }
}

// This class is derived from Base and it re-implements IDisposable
internal class Derived : Base, IDisposable {
   // This method cannot override Base's Dispose. 'new' is used to indicate
   // that this method re-implements IDisposable's Dispose method
   new public void Dispose() {
      Console.WriteLine("Derived's Dispose");

      // NOTE: The next line shows how to call a base class's implementation (if desired)
      // base.Dispose();
    }
}

Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
