//Defines a "point" class that inherits the IComparable interface.
public sealed class Point : IComparable<Point> {
   private Int32 m_x, m_y;

   public Point(Int32 x, Int32 y) {
      m_x = x;
      m_y = y;
   }

   // This method implements IComparable<T>.CompareTo() for Point
   public Int32 CompareTo(Point other) {
      return Math.Sign(Math.Sqrt(m_x * m_x + m_y * m_y)
         - Math.Sqrt(other.m_x * other.m_x + other.m_y * other.m_y));
   }
   //CompareTo must be defined per IComparable. This does math to determine the "size"
   //Of the two compared points.

   public override String ToString() {
      return String.Format("({0}, {1})", m_x, m_y);
   }
}


public static class Program {
   public static void Main() {
      Point[] points = new Point[] {
         new Point(3, 3),
         new Point(1, 2),
      };

      // Here is a call to Point's IComparable<T> CompareTo method
      if (points[0].CompareTo(points[1]) > 0) {
         Point tempPoint = points[0];
         points[0] = points[1];
         points[1] = tempPoint;
      }
      Console.WriteLine("Points from closest to (0, 0) to farthest:");
      foreach (Point p in points)
         Console.WriteLine(p);
   }
}

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
