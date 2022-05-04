using System;
using System.Collections.Generic;
using System.Text;

namespace AlxKor.SoftwareDevelop.Domain
{
    public class Settings
    {
        /// <summary>
        /// Количество рабочих часов в сутках
        /// </summary>
        public const byte HoursPerDay = 8;

        /// <summary>
        /// Количество рабочих часов в месяце
        /// </summary>
        public const byte HoursPerMonth = 160;

        /// <summary>
        /// Зарплата менеджера
        /// </summary>
        public const int ManagerSalary = 200000;

        /// <summary>
        /// Бонус менеджера в месяц
        /// </summary>
        public const int ManagerBonus = 20000;

        /// <summary>
        /// Зарплата наемного работника
        /// </summary>
        public const int EmployeeSalary = 120000;
    }
}
