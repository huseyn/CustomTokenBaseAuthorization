using src.web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.web.auth
{
    public class TokenSessionInfo
    {
        public int UserId { get; set; }
        public DateTime ExpireDate { get; set; }
        public List<Claim> Claims { get; set; }
    }
}
