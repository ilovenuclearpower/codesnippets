using System;

public sealed class SomeType {
   private static String Name {
      get { return null; }
      set {}
   }

   static void MethodWithOutParam(out String n) { n = null; }

   public static void Main() {
      // For the line of code below, the C# compiler emits the following:
      // error CS0206: A property, indexer or dynamic member access may not
      // be passed as an out or ref parameter
      MethodWithOutParam(out Name);
      /* This error is thrown because a property implicitly defines get_Name and set_Name methods in the compiled
      assmebly , which are called when Name is referenced. They are not actually fields, you would need to access the field directly.
      (which of course, isn't allowed because of the way properties work */
   }
}

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
