using System;
using System.Collections.Generic;
using System.Text;

namespace AlxKor.SoftwareDevelop.Domain.Persons
{
    public class Manager : Staff
    {
        public decimal TotalPay { get; }
        public Manager(string name, List<TimeRecord> timeRecords) : base(name, timeRecords, 200000)
        {
            TotalPay = 0;
            decimal payPerHour = Settings.ManagerSalary / Settings.HoursPerMonth;            
            decimal bonusPerDay = Settings.ManagerBonus / Settings.HoursPerMonth * Settings.HoursPerDay;

            foreach (var timeRecord in timeRecords)
            {
                if (timeRecord.HoursCount <= Settings.HoursPerDay)
                {
                    TotalPay += timeRecord.HoursCount * payPerHour;
                } else // переработки
                {
                    TotalPay += (Settings.HoursPerDay * payPerHour + bonusPerDay);
                }
            }
        }
    }
}
