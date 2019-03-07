using System;

// Point is a value type.
//Structs are immutable on instantiation.
internal struct Point {
   private Int32 m_x, m_y;

   //Constructor function for a new point.
   public Point(Int32 x, Int32 y) {
      m_x = x;
      m_y = y;
   }
   
   //This method shouldn't exist, you shouldn't do this ever.
   public void Change(Int32 x, Int32 y) {
      m_x = x; m_y = y;
   }
   
   //Overrides the standard ToString() method for this struct. This is normal and common.
   public override String ToString() {
      return String.Format("({0}, {1})", m_x.ToString(), m_y.ToString());
   }
}

public sealed class Program {
   public static void Main() {
      Point p = new Point(1, 1);
      //This call will box point p to an object so it can call the ToString method.
      Console.WriteLine(p);
      
      //This changes the unboxed value before reboxing it and printing it out.
      p.Change(2, 2);
      Console.WriteLine(p);
      
      //Casting the point as type object will still let it correctly print out.
      Object o = p;
      Console.WriteLine(o);

      ((Point) o).Change(3, 3);
      Console.WriteLine(o);
      
      Console.WriteLine(p);

      p.Change(2, 2);
      Console.WriteLine(p);

      Object o = p;
      Console.WriteLine(o);
      
      //This returns (2,2)!
      
      ((Point) o).Change(3, 3);
      Console.WriteLine(o);
      //The reason is that the Change method has to cast the *boxed* point to a Point
      //Which doesn't refer to the point being cast - it's instead a brand - new point!
      //But the Change method doesn't act on o, it acts on the new point!
   }
}

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
   }
}

