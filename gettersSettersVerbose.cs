public sealed class Employee {
   private String m_Name;
   private Int32  m_Age;

   public String Name {
      get { return(m_Name); }
      set { m_Name = value; } // The 'value' keyword always identifies the new value.
   }
//These properties emit the get_Name and set_Name functions into the IL code and place
//them in the type definition.
//When you use the property - you do not need to be concerned with whether you are using the getter or setter
// Employee A = new Employee();
// A.Name = "stringString"; works just fine!
// Console.WriteLine(A.Name); also works just fine!
// This is because the C# compiler is written
// in such a way as to overload the . and = operators
// to automatically call the correct methods in the Employee class.
// However, if you set the property to private - you may/may not be able to
// invoke these methods as expected, and the compiler will throw an error
   public Int32 Age {
      get { return(m_Age); }
      set {
         if (value < 0)    // The 'value' keyword always identifies the new value.
            throw new ArgumentOutOfRangeException("value", value.ToString(),
               "The value must be greater than or equal to 0");
         m_Age = value;
      }
   }
} 

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
