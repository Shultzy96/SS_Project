
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
   public class PayrollDO
    {
        public int PayrollID { get; set; }
        public string JobTitle { get; set; } //(120)
        public string JobDescription { get; set; } //(255)
        public decimal HourlyRate { get; set; } // (18.0)
        public decimal Salary { get; set; } // (18.0)
    }
}
