using System;
using System.Collections.Generic;

public class MinStack
{
    internal class ListNode
    {
        public int Value;
        public ListNode next;
        public ListNode(int x) { Value = x; }

        public override string ToString()
        {
            if (this == null) return string.Empty;

            var list = new List<int>();
            var node = this;

            while (node != null)
            {
                list.Add(node.Value);
                node = node.next;
            }

            return string.Join(" > ", list);
        }
    }

    private ListNode _head, _tail;
    private ListNode _minNode;

    public MinStack()
    {
        _head = null;
        _tail = null;
        _minNode = null;
    }

    public void Push(int x)
    {
        if (_head == null)
        {
            _head = new ListNode(x);
            _tail = _head;
            _minNode = _head;
        }
        else
        {
            var newNode = new ListNode(x);
            _tail.next = newNode;
            _tail = newNode;

            if (x < _minNode.Value)
                _minNode = newNode;
        }

        Console.Out.WriteLine($"Push({x}): {_head}");
    }

    public void Pop()
    {
        if (_head.next == null)
        {
            _head = null;
            _tail = null;
            _minNode = null;
        }
        else
        {
            var node = _head;
            var previousNode = _head;
            _minNode = _head;

            while (node.next != null)
            {
                previousNode = node;

                if (node.Value < _minNode.Value)
                    _minNode = node;

                node = node.next;
            }

            previousNode.next = null;
            _tail = previousNode;
        }

        Console.Out.WriteLine($"Pop(): {_head}");
    }

    public int Top()
    {
        return _tail != null ? _tail.Value : 0;
    }

    public int GetMin()
    {
        return _minNode != null ? _minNode.Value : 0;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
