﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlxKor.SoftwareDevelop.Domain.Persons
{
    internal class Freelancer : Person
    {
        public Freelancer(string name, List<TimeRecord> timeRecords) : base(name, timeRecords) { }
    }
}
