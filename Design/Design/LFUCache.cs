using System.Collections.Generic;
using System.Linq;

public class LFUCache
{
    int size = 0;
    int minFrequency = 0;
    public Dictionary<int, LinkedListNode<CacheItem>> cache = new Dictionary<int, LinkedListNode<CacheItem>>();
    public Dictionary<int, LinkedList<CacheItem>> freq = new Dictionary<int, LinkedList<CacheItem>>();
    public LFUCache(int capacity)
    {
        size = capacity;
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key))
            return -1;

        var item = cache[key];
        freq[item.Value.count].Remove(item);

        item.Value.count++;

        if (!freq.ContainsKey(item.Value.count))
        {
            freq.Add(item.Value.count, new LinkedList<CacheItem>());
        }
        freq[item.Value.count].AddLast(item);

        if (freq[minFrequency].Count == 0)
        {
            minFrequency++;
        }
        return item.Value.value;
    }

    public void Put(int key, int value)
    {

        var item = Get(key);

        if (item != -1)
        {
            cache[key].Value.value = value;
            return;
        }

        if (cache.Count == size)
        {
            var expired = freq[minFrequency].First();
            cache.Remove(expired.key);
            freq[minFrequency].RemoveFirst();
        }

        int keyprov = key;
        int valprov = value;
        var newItem = new CacheItem { key = keyprov, value = valprov, count = 1 };
        if (!freq.ContainsKey(1))
        {
            freq.Add(1, new LinkedList<CacheItem>());
        }
        var newNode = freq[1].AddLast(newItem);
        cache.Add(key, newNode);
        minFrequency = 1;
    }
}

public class CacheItem
{
    public int key;
    public int value;
    public int count;
}