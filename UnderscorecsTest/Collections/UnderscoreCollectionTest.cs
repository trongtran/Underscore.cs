using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Com.AsNet.Common.Underscore.Collections;
using System.Collections.Generic;

namespace Com.AsNet.Common.Underscore.Collections.Test
{
    [TestClass]
    public class UnderscoreCollectionTest
    {

        // Define Underscore object
        UnderscoreCollection _ = new UnderscoreCollection();

        // Array data
        private int[] arrayNum;
        private string[] arrayStr;

        // Generics
        List<string> listStr;
        List<Person> listObj;


        [TestInitialize]
        public void Setup()
        {
            arrayNum = new int[] { 1, 3, 4, 5, 6, 7 };
            arrayStr = new string[] { "first name", "second name", "third name" };

            listStr = new List<string>() { "trongtran", "thopham", "trungngo" };
            listObj = new List<Person>() { 
                new Person() {Id = 1, Name = "Trong Tran1"},
                new Person() {Id = 2, Name = "Trong Tran2"},
                new Person() {Id = 3, Name = "Trong Tran3"}
            };
        }

        [TestMethod]
        public void TestEach()
        {
            _.Each<int>(arrayNum, (num) => 
            {
                Assert.IsTrue(num > 0);
            });
        }

        [TestMethod]
        public void TestEachCount()
        {
            int realCount = arrayNum.Length;
            int cnt = 0;

            _.Each<int>(arrayNum, x => cnt++);

            Assert.AreEqual(realCount, cnt);
        }


        [TestMethod]
        public void TestEachSum()
        {
            int sum = 0;

            _.Each<int>(new int[] { 1, 2, 3 }, x => sum += x);

            Assert.AreEqual(6, sum);
        }


        [TestMethod]
        public void TestEachWithString()
        {
            // make sure all elements are not null
            _.Each<string>(arrayStr, str => Assert.IsNotNull(str));

            // Check data
            _.Each<string>(arrayStr, str => Assert.IsTrue(str.Contains("name")));
        }


        [TestMethod]
        public void TestEachWithList()
        {
            // make sure all elements are not null
            _.Each<string>(listStr, str => Assert.IsNotNull(str));
        }


        [TestMethod]
        public void TestEachWithObject()
        {
            // make sure all elements are not null
            _.Each<Person>(listObj, person =>
            {
                Assert.IsNotNull(person);

                Assert.IsTrue(person.Id > 0);
                Assert.IsNotNull(person.Name);
                Assert.IsTrue(person.Name.Contains("Trong Tran"));
            });
        }


        /// <summary>
        /// Define a person class for testing
        /// </summary>
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
