using System;
using System.Collections.Generic;
using System.Text;

namespace AlxKor.SoftwareDevelop.Domain.Persons
{
    public class Staff : Person
    {
        public int Salary { get; }
        public Staff(string name, List<TimeRecord> timeRecords, int salary) : base(name, timeRecords)
        {
            Salary = salary;
        }
    }
}
