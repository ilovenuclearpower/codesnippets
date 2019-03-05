using System;

class Program
{
    static void Main()
    {
        int value1 = 555;
        int value2 = 7777;

        // Use bitwise and operator.
        int and = value1 & value2;
        //Will flip the bit to 0 unless both bits are set.

        // Display bits.
        Console.WriteLine(GetIntBinaryString(value1));
        Console.WriteLine(GetIntBinaryString(value2));
        Console.WriteLine(GetIntBinaryString(and));
        //Returns an integer representation of the binary strings.
        
    }

    static string GetIntBinaryString(int value)
    {
        return Convert.ToString(value, 2).PadLeft(32, '0');
        //Converts it to base 2 then pads it with 0s to make it 32 digits.
    }
}
