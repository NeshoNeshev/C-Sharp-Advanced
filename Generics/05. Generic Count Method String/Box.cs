using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T> where T : IComparable
    {
        public int Counter = 0;
        public List<T> Value { get; set; }

        public Box()
        {
            this.Value = new List<T>();
        }
        public void Swap(int startIndex, int endIndex)
        {
            if (startIndex >= 0 && endIndex <= Value.Count)
            {
                var swap = Value[startIndex];
                Value[startIndex] = Value[endIndex];
                Value[endIndex] = swap;
            }
        }
        public void Counters(string input)
        {
            for (int i = 0; i < Value.Count; i++)
            {
                if (Value[i].CompareTo(input) > 0)
                {
                    Counter++;
                }
            }
        }
        public override string ToString()
        {

            return $"{this.Value.GetType()}: {Value}";
        }
    }
}
