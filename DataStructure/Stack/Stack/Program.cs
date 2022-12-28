internal class Stack
{
    static readonly int MAX = 10000;
    int top;
    int[] stack = new int[MAX];

    bool isEmpty()
    {
        return (top < 0);
    }

    public Stack() 
    {
        top = -1;
    }

    internal bool Push(int data)
    {
        if(top >= MAX)
        {
            Console.WriteLine("Stack Overflow");
            return false;
        }
        else
        {
            stack[++top] = data;
            return true;
        }
    }

    internal int Pop()
    {
        if( top < 0)
        {
            Console.WriteLine("Stack Underflow");
            return 0;
        }
        else
        {
            return stack[top--];
        }
    }

    internal void Peek()
    {
        if(top < 0)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }
        else
        {
            Console.WriteLine(stack[top]);
        }
    }

    internal void PrintStack()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }
        else
        {
            Console.WriteLine("Items in the stack are: ");
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Stack myStack  = new Stack();

        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);

        myStack.PrintStack();

        myStack.Peek();

        Console.WriteLine("Item popped from Stack: {0}", myStack.Pop());

        myStack.PrintStack();

    }
}