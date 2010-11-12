﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CodeSmith.Data.Caching;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Memcached;
using NUnit.Framework;
using Tracker.Core.Data;

namespace Tracker.Memcached.Tests.CacheTests
{
    [TestFixture]
    public class FromCacheTests : MemcachedTestBase
    {
        [Test]
        public void SimpleTest()
        {
            using (var db = new TrackerDataContext())
            {
                var query = db.Role.Where(r => r.Name == "Duck Roll");
                var roles = query.FromCache().ToList();

                Assert.IsInstanceOf(typeof(MemcachedProvider), CacheManager.GetProvider());

                var key = query.GetHashKey();

                var cache = CacheManager.Get<ICollection<Role>>(key);
                Assert.IsNotNull(cache);
                Assert.AreEqual(roles.Count, cache.Count);
            }
        }

        [Test]
        public void LongProfile()
        {
            using (var db = new TrackerDataContext())
            {
                var query = db.Role.Where(r => r.Name == "Duck Roll");
                var key = query.GetHashKey();
                var roles = query.FromCache("Long").ToList();

                Assert.IsInstanceOf(typeof(MemcachedProvider), CacheManager.GetProvider());

                var cache = CacheManager.Get<ICollection<Role>>(key);
                Assert.IsNotNull(cache);
                Assert.AreEqual(roles.Count, cache.Count);
            }
        }

        [Test]
        public void DurationTest()
        {
            using (var db = new TrackerDataContext())
            {
                var query = db.Role.Where(r => r.Name == "Test Role");
                var key = query.GetHashKey();
                var roles = query.FromCache(CacheSettings.FromDuration(2)).ToList();

                Assert.IsInstanceOf(typeof(MemcachedProvider), CacheManager.GetProvider());

                var cache = CacheManager.Get<ICollection<Role>>(key);
                Assert.IsNotNull(cache);
                Assert.AreEqual(roles.Count, cache.Count);

                System.Threading.Thread.Sleep(3000);

                cache = CacheManager.Get<ICollection<Role>>(key);
                Assert.IsNull(cache);
            }
        }

        [Test]
        public void AbsoluteExpirationTest()
        {
            using (var db = new TrackerDataContext())
            {
                var query = db.Role.Where(r => r.Name == "Test Role");
                var key = query.GetHashKey();
                var roles = query.FromCache(new CacheSettings(DateTime.Now.AddSeconds(2))).ToList();

                Assert.IsInstanceOf(typeof(MemcachedProvider), CacheManager.GetProvider());

                var cache = CacheManager.Get<ICollection<Role>>(key);
                Assert.IsNotNull(cache);
                Assert.AreEqual(roles.Count, cache.Count);

                System.Threading.Thread.Sleep(3000);

                cache = CacheManager.Get<ICollection<Role>>(key);
                Assert.IsNull(cache);
            }
        }

        [Test]
        public void NoCacheEmptyResultTest()
        {
            using (var db = new TrackerDataContext())
            {
                var guid = System.Guid.NewGuid().ToString();
                var query = db.Role.Where(r => r.Name == guid);
                var key = query.GetHashKey();
                var roles = query.FromCache(new CacheSettings(2) { CacheEmptyResult = false });

                Assert.IsNotNull(roles);
                Assert.AreEqual(0, roles.Count());

                Assert.IsInstanceOf(typeof(MemcachedProvider), CacheManager.GetProvider());


                var cache = CacheManager.Get<ICollection<Role>>(key);
                Assert.IsNull(cache);
            }
        }
    }
}