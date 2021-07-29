using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCalculator.Objects
{
    public class FibonacciNumbersListNode
    {
        FibonacciNumbersListNode _previous, _next;

        public BigInteger Value
        { get; private set; }
        public FibonacciNumbersListNode Previous
        {
            get
            {
                if (_previous == null)
                {
                    if (_next == null)
                        throw new Exception("Missing 1 Fibonacci number");
                    _previous = new FibonacciNumbersListNode(_next.Value - Value, null, this);
                }
                return _previous;
            }
            protected set
            {
                _previous = value;
            }
        }
        public FibonacciNumbersListNode Next
        {
            get
            {
                if (_next == null)
                {
                    if (_previous == null)
                        throw new Exception("Missing 1 Fibonacci number");
                    _next = new FibonacciNumbersListNode(Value + _previous.Value, this);
                }
                return _next;
            }
            protected set
            {
                _next = value;
            }
        }
        public FibonacciNumbersListNode(BigInteger value, FibonacciNumbersListNode previous = null, FibonacciNumbersListNode next = null)
        {
            Value = value;
            _previous = previous;
            _next = next;
            if (_previous != null)
                _previous.Next = this;
            if (_next != null)
                _next.Previous = this;
        }
    }
}
