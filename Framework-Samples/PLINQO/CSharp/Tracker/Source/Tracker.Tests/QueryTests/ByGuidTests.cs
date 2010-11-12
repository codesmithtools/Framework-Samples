﻿using System;
using System.Linq;
using CodeSmith.Data.Linq;
using NUnit.Framework;
using Tracker.Core.Data;
using Guid = System.Guid;

namespace Tracker.Tests.QueryTests
{
    [TestFixture]
    public class ByGuidTests
    {
        private Guid _guid1Id = Guid.NewGuid();
        private Guid _guid2Id = Guid.NewGuid();
        private Guid _guid2Alt = Guid.NewGuid();
        private Guid _guid3Id = Guid.NewGuid();
        private Guid _guid3Alt = Guid.NewGuid();

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            using (var db = new TrackerDataContext { Log = Console.Out })
            {
                db.Guid.InsertOnSubmit(new Core.Data.Guid
                {
                    Id = _guid1Id,
                    AlternateId = null
                });
                db.Guid.InsertOnSubmit(new Core.Data.Guid
                {
                    Id = _guid2Id,
                    AlternateId = _guid2Alt
                });
                db.Guid.InsertOnSubmit(new Core.Data.Guid
                {
                    Id = _guid3Id,
                    AlternateId = _guid3Alt
                });

                db.SubmitChanges();
            }
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            using (var db = new TrackerDataContext { Log = Console.Out })
            {
                db.Guid.Delete(_guid1Id);
                db.Guid.Delete(_guid2Id);
                db.Guid.Delete(_guid3Id);
            }
        }

        [Test]
        public void ByTest()
        {

            using (var db = new TrackerDataContext { Log = Console.Out })
            {
                var a = db.Guid.ById(_guid1Id).ToList();
                var b = db.Guid.ById(_guid2Id).ToList();

                var c = db.Guid.ById(_guid1Id, null).ToList();
                Assert.AreEqual(a.Count, c.Count);

                var d = db.Guid.ById(_guid1Id, _guid2Id).ToList();
                Assert.AreEqual(a.Count + b.Count, d.Count);
            }

        }

        [Test]
        public void ByNullableTest()
        {

            using (var db = new TrackerDataContext { Log = Console.Out })
            {
                var a = db.Guid.ByAlternateId((Guid?)null).ToList();
                var b = db.Guid.ByAlternateId(_guid2Alt).ToList();
                var c = db.Guid.ByAlternateId(_guid3Alt).ToList();

                var d = db.Guid.ByAlternateId(_guid2Alt, null).ToList();
                Assert.AreEqual(a.Count + b.Count, d.Count);

                var e = db.Guid.ByAlternateId(_guid2Alt, null, _guid3Alt).ToList();
                Assert.AreEqual(a.Count + b.Count + c.Count, e.Count);

                var f = db.Guid.ByAlternateId(ComparisonOperator.NotEquals, null).ToList();
                var g = db.Guid.ByAlternateId(ComparisonOperator.Equals, null).ToList();

            }

        }
    }
}
