/*
 * C# Program to Implement Stack with Push and Pop operations
 */
 //Stacks are one of the most basic datastructures and have been used
 //since the earliest days of computing.
 //Stacks support O(1) push, pop, and peek.
 //Stacks do not support searching or sorting.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {         
            stack st = new stack();
          while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU(size -- 10)");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        st.Push(Console.ReadLine());
                        break;
 
                    case 2: Console.WriteLine("Top element is: {0}", st.Peek());
                        break;
 
                    case 3: Console.WriteLine("Element removed: {0}", st.Pop());
                        break;
 
                    case 4: st.Display();
                        break;
 
                    case 5: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
 
    interface StackADT
    {
        Boolean isEmpty();
        void Push(Object element);
        Object Pop();
        Object Peek();
        void Display();
        // Methods that must be defined by anything that implements the StackADT interface.
    }
    class stack : StackADT
    {
        private int StackSize;
        public int StackSizeSet
        {
            get { return StackSize; }
            set { StackSize = value; }
        }
        public int top;
        Object[] item;
        public stack()
        {
            StackSizeSet = 10;
            item = new Object[StackSizeSet];
            top = -1;
        }
        //Parameterless constructor.
        public stack(int capacity)
        {
            StackSizeSet = capacity;
            item = new Object[StackSizeSet];
            top = -1;
        }
        // Builds a stack of a given size.
        public bool isEmpty()
        {
            if (top == -1) return true;
 
            return false;
        }
        public void Push(object element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
                //Basic errorchecking
            }
 
            else
            {
 
                item[++top] = element;
                //Increases your stack pointer *then* assigns the value at that pointer to the element.
                //Nice piece of tricky syntax.
                Console.WriteLine("Item pushed successfully!");
            }
        }
        public object Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
 
                return item[top--];
                //Moves your top pointer down the stack *after* returning the value at the previous top pointer.
                //Another clever bit of tricky syntax.
            }
        }
        public object Peek()
        {
            if (isEmpty())
            {
 
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top];
                //Shows the item based at the current stack pointer.
            }
        }
 
 
        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
 
                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
                //Output.
            }
        }
    }
}

//Taken from: https://www.sanfoundry.com/csharp-program-stack-push-pop/
