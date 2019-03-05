using System;

//This demonstrates the use of "callvirt" versus "call" IL instructions on nonvirtual methods.
//Call is *only* used for static methods, callvirt is used for instance methods and virtual methods.
public sealed class Program {
   public Int32 GetFive() { return 5; }
   public static void Main() {
      Program p = null;
      Int32 x = p.GetFive(); // In C#, NullReferenceException is thrown
      //If you used call instead of callvirt for instance methods, this would work fine.
      //callvirt checks for null variables on the object passed in when it checks for type.
      //Some other languages may not exhibit this behavior.
      //If GetFive() were a statis method, you could omit the p.Method() pointers.
   }
}

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
