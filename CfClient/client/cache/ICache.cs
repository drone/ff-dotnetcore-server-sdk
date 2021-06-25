using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace io.harness.cfsdk.client.cache
{
    public interface ICache<K, V>
    {

        public void PutAll(ICollection<KeyValuePair<K, V>> keyValuePairs)
        {
            foreach (var item in keyValuePairs)
            {
                Put(item);
            }
        }

        public void Put(K key, V value);
        public void Put(KeyValuePair<K, V> keyValuePair)
        {
            Put(keyValuePair.Key, keyValuePair.Value);
        }
        public V getIfPresent(K  key);
    }
}
