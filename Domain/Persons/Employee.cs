using System;
using System.Collections.Generic;
using System.Text;

namespace AlxKor.SoftwareDevelop.Domain.Persons
{
    internal class Employee : Staff
    {
        public Employee(string name, List<TimeRecord> timeRecords) : base(name, timeRecords, 120000) { }
    }
}
