using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_prep
{
    class PartTimer : Employee
    {
        public decimal HourlyRate { get; set; }
        public int Hours { get; set; }

        public PartTimer(string firstName, string lastName, decimal salary, int hours, decimal hourlyRate)
            : base(firstName, lastName, salary)
        {
            HourlyRate = hourlyRate;
            Hours = hours;
        }
    }
}
