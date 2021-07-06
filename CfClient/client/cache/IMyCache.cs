using io.harness.cfsdk.HarnessOpenAPIService;
using System;
using System.Collections.Generic;
using System.Text;

namespace io.harness.cfsdk.client.cache
{
    public interface IMyCache<K,V> : ICache<K, V>
    {
        Dictionary<K, V> CacheMap { get; set; }

        new public void Put(K key, V value)
        {
            if (CacheMap.ContainsKey(key))
            {
                CacheMap.Remove(key);
            }
            CacheMap.Add(key, value);
        }

        new public V getIfPresent(K key)
        {
            if (!CacheMap.ContainsKey(key))
            {
                return default(V);
            }
            return CacheMap[key];
        }

        public Dictionary<K, V> GetAllElements()
        {
            return CacheMap;
        }

    }
}
