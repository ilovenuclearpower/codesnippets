//C# library implementation of Swap.
private static void Swap<T>(ref T o1, ref T o2) {
   T temp = o1;
   o1 = o2;
   o2 = temp;
}
//The important part here is that this method can accept arguments of any type, as long as the types
//are the same.
//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
