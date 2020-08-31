using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class LRUPractice
    {
        private readonly int _capacity;
        private Dictionary<int, NodeList> d;
        NodeList head = new NodeList();
        NodeList tail = new NodeList();

        public LRUPractice(int capacity)
        {
            _capacity = capacity;
            d = new Dictionary<int, NodeList>();
            head.next = tail;
            tail.prev = head;
        }

        public int Get(int key)
        {
            int result = -1;
            if (d.ContainsKey(key))
            {
                NodeList node = d[key];
                result = node.value;
                RemoveNode(node);
                AddNode(node);
            }

            return result;
        }

        public void Put(int key, int value)
        {
            if (d.ContainsKey(key))
            {
                var node = d[key];
                RemoveNode(node);
                node.value = value;
                AddNode(node);
            }
            else
            {
                if (d.Count == _capacity)
                {
                    d.Remove(tail.prev.key);
                    RemoveNode(tail.prev);
                }
                var newNode = new NodeList() { key = key, value = value };
                AddNode(newNode);
                d.Add(key, newNode);
            }
        }

        public void RemoveNode(NodeList node)
        {
            var node_next = node.next;
            var node_prev = node.prev;

            node.prev.next = node_next;
            node.next.prev = node_prev;
        }

        public void AddNode(NodeList node)
        {
            var head_next = head.next;
            head.next = node;
            node.prev = head;
            node.next = head_next;
            head_next.prev = node;
        }
    }

    public class NodeList
    {
        public int key;
        public int value;
        public NodeList prev;
        public NodeList next;
    }
}
