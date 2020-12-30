using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<TFirst , TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }
        public Tuple(TFirst firstItem, TSecond secondItem)
        {
            this.First = firstItem;
            this.Second = secondItem;
        }
        public override string ToString()
        {
            return $"{First} -> {Second}";
        }
    }
}
