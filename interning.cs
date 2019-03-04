
//Note - this is not true for version 4.5 of the CLR
String s1 = "Hello";
String s2 = "Hello";
Console.WriteLine(Object.ReferenceEquals(s1, s2));
//There are now *two* string literals with value "Hello" on the heap!
// Should be 'False'

s1 = String.Intern(s1);
s2 = String.Intern(s2);
Console.WriteLine(Object.ReferenceEquals(s1, s2));   
// 'True'
// The second intern call checked if s2's literal value  was on the heap, and if it did - stored that reference pointer.
// The CLR will *not* do this for you for performance reasons, you have to intern strings manually.

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
