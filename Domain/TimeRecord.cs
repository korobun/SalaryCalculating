using System;
using System.Collections.Generic;
using System.Text;

namespace AlxKor.SoftwareDevelop.Domain
{
    public class TimeRecord
    {
        public DateTime Date { get; }
        public string Name { get; }
        public byte HoursCount{ get; }
        public string Description { get; }

        public TimeRecord(DateTime date, string name, byte hoursCount, string description)
        {
            Date = date;
            Name = name;
            HoursCount = hoursCount;
            Description = description;
        }
    }
}
