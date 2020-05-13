using System.Collections.Generic;

namespace src.web.Models.Entities
{
    public class User
    {
        public User()
        {
            Tokens = new HashSet<Token>();
        }
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
