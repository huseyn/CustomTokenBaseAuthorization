using System;
using System.Collections.Generic;

namespace src.web.Models.Entities
{
    public class Role
    {
        public Role()
        {
            Claims = new HashSet<Claim>();
            Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public DateTime AddedDate { get; set; }

        public virtual ICollection<Claim> Claims { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
