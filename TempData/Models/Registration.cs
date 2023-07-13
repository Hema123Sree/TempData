using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempData.Models
{
    public class Registration
    {
        public  int Reg_Id { get; set; }
        public string Candiadate_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}