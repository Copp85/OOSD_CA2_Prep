using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_prep
{
    class Contractor : PartTimer
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Contractor(string firstName, string lastName, decimal salary, int hours, decimal hourlyRate,
            DateTime startDate, DateTime endDate)
            :base(firstName, lastName, salary, hours, hourlyRate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
