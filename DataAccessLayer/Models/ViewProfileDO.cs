
namespace DataAccessLayer.Models
{
   public class ViewProfileDO
    {
        public int ProfileID { get; set; }
        public string UserFirstName { get; set; } //(60) Charaters
        public string UserLastName { get; set; } //(82) Charaters
        public string Email { get; set; } //(82) Charaters
        public string UserName { get; set; } //(32) Charaters
        public string Bio { get; set; } //(500) Charaters
        public string JobTitle { get; set; } //(120) Charaters
        public string Achievements { get; set; } //(255) Charaters
        public string Posts { get; set; } //(500) Charaters
    }
}
