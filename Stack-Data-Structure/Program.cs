namespace Stack_Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new(5);
            Console.WriteLine("Empty: " + stack.IsEmpty());
            Console.WriteLine("Full: " + stack.IsFull());
            stack.Push("Book 1");
            stack.Push("Book 2");
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            stack.Push("Book 3");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Push("Item1");
            stack.Push("Item2");
            stack.Push("Item3");
            stack.Push("Item4");
            stack.Push("Item5");
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.IsFull());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
