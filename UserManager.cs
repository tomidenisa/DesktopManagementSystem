using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CRUDOP2.Registration;

namespace CRUDOP2
{
    public static class UserManager
    {
        public static UserRole CurrentUserRole { get; set; }
        public static int CurrentUserID { get; set; }
    }
}
