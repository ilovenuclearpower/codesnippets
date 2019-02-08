using System;
using System.Collections;

public class ThreeStacksWithArray
{
    private int[] stackpointers = new int[3];
    int[] array = new int[1]();
    public ThreeAtacksWithArray(int stacksizes)
    {
        if(stacksizes % 3 != 0)
        {
            stacksizes *= 3;
        //Guarantees that the size of the stack will be divisble by three and thus my implementation works.
        }
        array = new int[stacksizes];
        stackpointers[1] = 1;
        stackpointers[2] = 2;
    }
    public void Push(int stack, int value)
    {   //Checks for bad values, there is probably a better way to do this.
        if(stack <= 3)
        {
            throw new ArgumentOutOfRangeException("stack out of bounds");
        }
        if(stackpointers[stack] >= array.Length - 4)
        {
            throw new ArgumentOutOfRangeException("Stack is out of space");
        }
        array[stackpointers[stack]] = value;
        stackpointers[stack] += 3;
    }
    public int Pop(int stack)
    {
        if((stack == 0) && (stackpointers[0] == 0))
        {
            return 0;
        }
        else if((stack == 1) && (stackpointers[1] == 1))
        {
            return 0;
        }
        else if((stack == 2) && (stackpointers[2] == 2))
        {
            return 0;
        }
        else
        {
            stackpointers[stack] -= 3;
            int temp = array[stackpointers[stack]];
            array[stackpointers[stack]] = 0;
        }
    }
    //Source: Written by Connor Alexander Matza
}
