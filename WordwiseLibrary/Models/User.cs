using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordwiseLibrary.Models
{
    public class User
    {
        // Unique identifier for user
        public int UserID { get; set; }

        // Credential for account name
        public string Username { get; set; }

        // Credential for account password
        public string Password { get; set; }
    }
}
