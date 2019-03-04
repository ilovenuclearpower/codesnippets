//This is the core .NET definition of various interfaces.
//All methods defined here *Must* be defined in classes that inherit the interface.


public interface IDisposable {
   void Dispose();
}
//Intended to produce cleanup code for the type it's called on.

public interface IEnumerable {
   IEnumerator GetEnumerator();
}
//Requires that the Enumerable allows calling code to get an Enumerator variable.

public interface IEnumerable<out T> : IEnumerable {
   new IEnumerator<T> GetEnumerator();
}
//A generic implementation of IEnumerable.

public interface ICollection<T> : IEnumerable<T>, IEnumerable {
   void    Add(T item);
   void    Clear();
   Boolean Contains(T item);
   void    CopyTo(T[] array, Int32 arrayIndex);
   Boolean Remove(T item);
   Int32   Count      { get; } // Read-only property
   Boolean
//ICollection *inherits* both of the above interfaces, and also defines that you must be able to
//Add items, determine whether the collection contains an item, etc.
//If your type inherits from these interfaces, all of those methods *must* be defined
//exactly according to these signatures.
//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
