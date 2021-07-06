﻿using io.harness.cfsdk.HarnessOpenAPIService;

using System;
using System.Collections.Generic;
using System.Text;

namespace io.harness.cfsdk.client.cache
{
    public class SegmentCache : IMyCache<string, Segment>
    {
        public Dictionary<string, Segment> CacheMap { get; set; }

        public SegmentCache()
        {
            CacheMap = new Dictionary<string, Segment>();
        }

        public void Put(string key, Segment value)
        {
            if (CacheMap.ContainsKey(key))
            {
                CacheMap.Remove(key);
            }
            CacheMap.Add(key, value);
        }

        public Segment getIfPresent(string key)
        {
            if (!CacheMap.ContainsKey(key))
            {
                return null;
            }
            return CacheMap[key];
        }

        public Dictionary<string, Segment> GetAllElements()
        {
            return CacheMap;
        }
        public void Delete(String key)
        {
            CacheMap.Remove(key);
        }
    }
}
