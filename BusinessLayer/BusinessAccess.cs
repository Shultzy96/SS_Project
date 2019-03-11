using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessAccess
    {
       public decimal PaycheckCalc(PayBO item)
        {
            //decimal payCheck = 0;
         
            decimal hours = item.NumbHours;
            decimal rate = item.HourlyRate;

            decimal TotPay = hours * rate;
          
           

            return TotPay;
        }
    }
}
