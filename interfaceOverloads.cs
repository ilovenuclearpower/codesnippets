using System;

// This class implements the generic IComparable<T> interface twice
public sealed class Number: IComparable<Int32>, IComparable<String> {
   private Int32 m_val = 5;

   // You are allowed to implement both of these methods
   // because they have different signatures and are valid
   // interface implementations.
   // This method implements IComparable<Int32>'s CompareTo
   public Int32 CompareTo(Int32 n) {
      return m_val.CompareTo(n);
   }

   // This method implements IComparable<String>'s CompareTo
   public Int32 CompareTo(String s) {
   //here we automatically rollup the conversion from String to Int32.
   //Reducing the amount of casts required to use the class.
      return m_val.CompareTo(Int32.Parse(s));
   }
}

public static class Program {
   public static void Main() {
      Number n = new Number();
      //m_val = 5 here due to default field.

      // Here, I compare the value in n with an Int32 (5)
      IComparable<Int32> cInt32 = n;
      Int32 result = cInt32.CompareTo(5);

      // Here, I compare the value in n with a String ("5")
      IComparable<String> cString = n;
      result = cString.CompareTo("5");
   }
}

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
