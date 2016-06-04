using BlogEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEngine.Services
{
    public class CacheProvider : ICacheProvider
    {
        public ICache GetCache()
        {
            return MemoryCache.Current;
        }
    }
}