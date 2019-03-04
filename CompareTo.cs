
//NonGeneric CompareTo
private void SomeMethod1() {
   Int32 x = 1, y = 2;
   IComparable c = x;

   // CompareTo expects an Object; passing y (an Int32) is OK
   c.CompareTo(y);     // y is boxed here

   // CompareTo expects an Object; passing "2" (a String) compiles
   // but an ArgumentException is thrown at runtime
   c.CompareTo("2");
   //The CompareTo method doesn't have a comparison definition
   //For string to int without a case.
   //Since we boxed the Int32 and the string, they are both of type
   //"Object"
   //And will compile
   //but when passed to the CompareTo method, it will not be able
   //to examine them for comparison - throwing a runtime error.
   //Generics allow you to have compiletime safety.
}

Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
