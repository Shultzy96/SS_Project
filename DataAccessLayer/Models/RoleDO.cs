using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class RoleDO
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; } //(120)
        public string RoleDescription { get; set; } //(255)

    }
}
