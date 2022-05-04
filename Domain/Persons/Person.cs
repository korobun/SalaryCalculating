using System;
using System.Collections.Generic;

namespace AlxKor.SoftwareDevelop.Domain
{
    public class Person
    {
        public string Name { get; }
        public List<TimeRecord> TimeRecords { get; }
        public Person(string name, List<TimeRecord> timeRecords)
        {
            Name = name;
            TimeRecords = timeRecords;
        }

    }
}
