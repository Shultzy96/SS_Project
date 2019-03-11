using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class PayBO
    {
        public decimal HourlyRate { get; set; } // (18.0)
        public decimal NumbHours { get; set; } //User Input
        public decimal TotPay { get; set; } //Pay Calculation
    }
}
