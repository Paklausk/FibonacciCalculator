using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCalculator.Objects
{
    public class FibonacciNumbersList
    {
        int _index = 0;
        FibonacciNumbersListNode _current;
        public FibonacciNumbersList(BigInteger firstValue, BigInteger secondValue)
        {
            _current = new FibonacciNumbersListNode(firstValue, null, new FibonacciNumbersListNode(secondValue));
        }
        public int Index
        {
            get
            {
                return _index;
            }
        }
        public BigInteger Previous
        {
            get
            {
                _current = _current.Previous;
                _index--;
                return Current;
            }
        }
        public BigInteger Current
        {
            get
            {
                return _current.Value;
            }
        }
        public BigInteger Next
        {
            get
            {
                _current = _current.Next;
                _index++;
                return Current;
            }
        }
    }
}
