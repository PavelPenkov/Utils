using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Synapse.Utils;

namespace Utils.Tests
{
    [TestClass]
    public class DicUtilsTest
    {
        public class Person {
            public Person(int id, string name, string ssn) {
                Id = id;
                Name = name;
                Ssn = ssn;
            }

            public string Name { get; set;}
            public int Id;
            private string Ssn { get; set; }
        }
        
        [TestMethod]
        public void Should_List_Public_Props() {
            var p = new Person(666, "Adam", "SR71");
            var result = p.ToDictionary();

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Adam", result["Name"]);
        }
    }
}
