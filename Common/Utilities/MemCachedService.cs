
using Microsoft.Extensions.Options;
using NHibernate.Cfg.Loquacious;
using ServiceStack.Caching;

namespace TestApplication.Common.Utilities
{
    public class MemCachedService : ICacheService
    {
        private readonly IMemcachedClient _memcachedClient;
        private readonly CacheConfiguration _cacheConfig;
        public MemCachedService(IMemcachedClient memcachedClient, IOptions<CacheConfiguration> cacheConfig)
        {
            _memcachedClient = memcachedClient;
            _cacheConfig = cacheConfig.Value;
        }
        //public bool TryGet<T>(string cacheKey, out T value)
        //{
        //    //_memcachedClient.TryGet(cacheKey, out value);
        //    if (value == null) return false;
        //    else return true;
        //}
        //public T Set<T>(string cacheKey, T value)
        //{
        //    //bool result = _memcachedClient.Set(cacheKey, value, _cacheConfig.AbsoluteExpirationInHours);
        //    //_memcachedClient.TryGet(cacheKey, out value);
        //    return value;
        //}
        public void Remove(string cacheKey)
        {
            _memcachedClient.Remove(cacheKey);
        }

        public T Set<T>(string cacheKey, T value)
        {
            throw new System.NotImplementedException();
        }

        public bool TryGet<T>(string cacheKey, out T value)
        {
            throw new System.NotImplementedException();
        }
    }
}
