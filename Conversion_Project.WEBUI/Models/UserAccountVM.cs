using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conversion_Project.WEBUI.Models
{
    public class UserAccountVM
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime? RecordDate { get; set; }
    }
}
