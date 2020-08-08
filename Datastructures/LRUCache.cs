using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class LRUCache
    {
        Node head = new Node();
        Node tail = new Node();
        int Capacity = 0;
        Dictionary<int, Node> dict;
        public LRUCache(int capacity)
        {
            Capacity = capacity;
            dict = new Dictionary<int, Node>();
            head.next = tail;
            tail.prev = head;
        }

        public int Get(int key)
        {
            int result = -1;
            if (dict.ContainsKey(key))
            {
                var node = dict[key];
                result = node.value;
                RemoveNode(node);
                AddNode(node);
            }
            return result;
        }

        public void Put(int key, int value)
        {
            Node n = new Node();
            if (dict.ContainsKey(key))
            {
                var node = dict[key];
                RemoveNode(node);
                node.value = value;
                AddNode(node);
            }
            else
            {
                if (dict.Count == Capacity)
                {
                    dict.Remove(tail.prev.key);
                    RemoveNode(tail.prev);
                }
                Node newNode = new Node();
                newNode.key = key;
                newNode.value = value;
                AddNode(newNode);
                dict.Add(key, newNode);
            }
        }

        public void AddNode(Node node)
        {
            var head_next = head.next;
            head.next = node;
            node.prev = head;
            node.next = head_next;
            head_next.prev = node;
        }

        public void RemoveNode(Node node)
        {
            Node node_next = node.next;
            Node node_prev = node.prev;

            node_next.prev = node_prev;
            node_prev.next = node_next;

        }
    }
    public class Node
    {
        public int key;
        public int value;
        public Node next;
        public Node prev;
    }
}
