using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string UserName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phoneno {  get; set; }    

    }
}
