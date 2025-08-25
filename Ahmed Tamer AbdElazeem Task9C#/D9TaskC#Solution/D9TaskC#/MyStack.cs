using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9TaskC_
{
    internal class MyStack<T>
    {
        private T[] items;
        private int top;

        public MyStack(int size)
        {
            items = new T[size];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                throw new InvalidOperationException("Stack is full!");
            }
            items[++top] = item;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return items[top--];
        }

        public T Peek()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return items[top];
        }

        public bool IsEmpty()
        {   
          return top == -1;
        }   
   }
}
