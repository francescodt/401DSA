using System;
using System.Collections;
using System.Text;
using DataStructures;
using DataStructures.Stack;


namespace Challenges.QueueStacks
{
    public class PseudoQueue<T>
    {
        Stacks<T> stack1 = new Stacks<T>();
        Stacks<T> stack2 = new Stacks<T>();

            
        public void Enqueue(T value)
        {

            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);


            while (stack2 != null)
            {
                stack1.Push(stack2.Pop());
            }
        }

        public T Dequeue()
        {
            if (stack1.IsEmpty())
                throw new StackEmptyException();
            T result = (T)stack1.Peek();
            stack1.Pop();
            return result;
        }



        

    }
}
