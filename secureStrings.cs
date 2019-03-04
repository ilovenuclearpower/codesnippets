using System;
using System.Security;
using System.Runtime.InteropServices;


//This demonstrates the SecureString class.
public static class Program {
   public static void Main() {
   //Creates an "unsafe" buffer of memory (unmanaged) that contains an encrypted block of data.
   //that can be decrypted into a buffer.
      using (SecureString ss = new SecureString()) {
         Console.Write("Please enter password: ");
         while (true) {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.Enter) break;

            // Append password characters into the SecureString
            //This will pull the encrypted buffer out, re encrypt it with the appended car
            //and reinsert it at the location.
            ss.AppendChar(cki.KeyChar);
            Console.Write("*");
         }
         Console.WriteLine();

         // Password entered, display it for demonstration purposes
         DisplaySecureString(ss);
         //This is awful for performance.
      }
      // After 'using', the SecureString is Disposed; no sensitive data in memory
   }

   // This method is unsafe because it accesses unmanaged memory
   private unsafe static void DisplaySecureString(SecureString ss) {
      Char* pc = null;
      try {
         // Decrypt the SecureString into an unmanaged memory buffer
         pc = (Char*) Marshal.SecureStringToCoTaskMemUnicode(ss);

         // Access the unmanaged memory buffer that
         // contains the decrypted SecureString
         for (Int32 index = 0; pc[index] != 0; index++)
            Console.Write(pc[index]);
      }
      finally {
         // Make sure we zero and free the unmanaged memory buffer that contains
         // the decrypted SecureString characters
         if (pc != null)
            Marshal.ZeroFreeCoTaskMemUnicode((IntPtr) pc);
            //this operation guarantees that the buffer is zeroed at the conclusion of the method.
            //Preventing "insecure" storage of passwords inside the application memory
      }
   }

// Richter, Jeffrey. CLR via C# (Developer Reference) . Pearson Education. Kindle Edition. 
