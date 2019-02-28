//This is a snippet and won't compile correctly.
String myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
var query =
         from pathname in Directory.GetFiles(myDocuments)
         let LastWriteTime = File.GetLastWriteTime(pathname)
         where LastWriteTime > (DateTime.Now - TimeSpan.FromDays(7))
         orderby LastWriteTime
         select new { Path = pathname, LastWriteTime };// Set of anonymous type objects
         //Looks a lot like SQL doesn't it?
         //Every returned object here is of the *same* anonymous type
         //So using an implicit collection in the later foreach query "just works".

foreach (var file in query)
   Console.WriteLine("LastWriteTime={0}, Path={1}", file.LastWriteTime, file.Path);

//Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
