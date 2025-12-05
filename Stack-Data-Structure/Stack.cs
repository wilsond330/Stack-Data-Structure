using System;

public class Stack<stackType>
{
	private int top;
	private stackType[] stack;
	private bool isFull;
	private bool isEmpty;
	private int MAX_LENGTH;
	public Stack(int maxLength)
	{
		this.top = -1;
		this.MAX_LENGTH = maxLength;
		this.stack = new stackType[MAX_LENGTH];
		this.isEmpty = true;
		this.isFull = false;
	}
	public (stackType, bool) Pop()
	{
		stackType output = default(stackType);
		bool successful;
		if (!isEmpty)
		{
			isFull = false;
			output = stack[top];
			top--;
			if (top == -1)
			{
				isEmpty = true;
			}
			successful = true;
		}
		else
		{
			successful = false;
		}
		return (output, successful);
	}
	public (stackType, bool) Peek()
	{
        stackType output = default(stackType);
        bool successful;
        if (!isEmpty)
        {
            output = stack[top];
            successful = true;
        }
        else
        {
            successful = false;
        }
        return (output, successful);
    }
	public bool Push(stackType input)
	{
		bool successful;
		if (!isFull)
		{
			isEmpty = false;
            top++;
            stack[top] = input;
			if (top == MAX_LENGTH)
			{
				isFull = true;
			}
			successful = true;
		}
		else
		{
			successful = false;
		}
		return successful;
	}
	public bool IsEmpty()
	{
		return isEmpty;
	}
	public bool IsFull()
	{
		return isFull;
	}
}
