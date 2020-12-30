using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustoStack<T> : IEnumerable<T>
    {
        private List<T> MyStack;
        public int count = 0;
        public CustoStack()
        {
            this.MyStack = new List<T>();
        }
        public void Push(T element)
        {
            this.MyStack.Add(element);
            count++;
        }
        public T Pop()
        {
            if (this.MyStack.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            var element = this.MyStack[this.MyStack.Count-1];
            this.MyStack.RemoveAt(this.MyStack.Count-1);
            return element;

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.MyStack.Count - 1; i >= 0; i--)
            {
                yield return this.MyStack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
