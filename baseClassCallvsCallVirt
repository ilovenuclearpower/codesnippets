internal class SomeClass {
   // ToString is a virtual method defined in the base class: Object.
   public override String ToString() {

      // Compiler uses the 'call' IL instruction to call
      // Object's ToString method nonvirtually.

      // If the compiler were to use 'callvirt' instead of 'call', this
      // method would call itself recursively until the stack overflowed.
      // This is because at runtime, callvirt would look for the base class
      // then see the override.
      // The "call" instruction explicitly ignores polymorphism
      // and will just call the overridden method directly.
      return base.ToString();
   }
}

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
