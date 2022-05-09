using AlxKor.SoftwareDevelop.Domain;
using AlxKor.SoftwareDevelop.Domain.Persons;
using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace AlxKor.SoftwareDevelop.Persistance.SoftwareDevelopTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ManagerTotalPayTest()
        {
            Manager manager = new Manager("test", new List<TimeRecord>()
            {
                new TimeRecord(DateTime.Now.AddDays(-3), "test", 8, "test1"),
                new TimeRecord(DateTime.Now.AddDays(-2), "test", 9, "test2"),
                new TimeRecord(DateTime.Now.AddDays(-1), "test", 7, "test3"),
            });
            Assert.IsTrue(manager.TotalPay == 29750); 
        }
    }
}