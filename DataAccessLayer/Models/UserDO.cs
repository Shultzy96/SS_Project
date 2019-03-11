
namespace DataAccessLayer.Models
{
    public class UserDO
    {
        public int UserID { get; set; }
        public int ProfileID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int PayrollID { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }

    }
}
