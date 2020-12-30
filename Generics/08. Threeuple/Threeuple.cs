using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Threeuple<TFirst , TSecond, TThird>
    {
        
        public Threeuple(TFirst firstItem, TSecond secondItem,TThird thirdItem)
        {
            this.First = firstItem;
            this.Second = secondItem;
            this.Third = thirdItem;
        }
        public TFirst First { get; set; }
        public TSecond Second { get; set; }
        public TThird Third { get; set; }
        public override string ToString()
        {
            return $"{First} -> {Second} -> {Third}";
        }
    }
}
