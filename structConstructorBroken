
//This code does not compile.
internal struct Point {
   public Int32 m_x, m_y;

//This public constructor throws an error, public parameterless constructors
//Are out of bounds for structs
   public Point() {
      m_x = m_y = 5;
   }
}


internal sealed class Rectangle {
   public Point m_topLeft, m_bottomRight;
//This is why, to avoid confusing the developer when Rectangle() is initialized.
//Structs do not, by default, call their constructors when initialized.
//Instead their constructor must be explicitly invoked.
   public Rectangle() {
   }
}

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
