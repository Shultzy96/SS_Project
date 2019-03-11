using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class LoginDO
    {
        public int UserID { get; set; }
        public int ProfileID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string JobTitle { get; set; }
        public string RoleName { get; set; }
    }
}
