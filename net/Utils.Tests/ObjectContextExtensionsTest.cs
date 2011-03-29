using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Synapse.Utils;

namespace Utils.Tests
{
    [TestClass]
    public class ObjectContextTest
    {
        public class Person {
            public class Address {
                public string City { get; set; }
            }

            public string Name { get; set; }
            public Address Addr { get; set; }
        }

        [TestMethod]
        public void Should_Include_First_Level_Props() {
            Expression<Func<Person, object>> expr = p => p.Addr;
            string result = ObjectQueryExtensions.GetIncludeString(expr);

            Assert.AreEqual("Addr", result);
        }

        [TestMethod]
        public void Should_Include_Second_Level_Props() {
            Expression<Func<Person, object>> expr = p => p.Addr.City;
            string result = ObjectQueryExtensions.GetIncludeString(expr);

            Assert.AreEqual("Addr.City", result);
        }
    }
}
