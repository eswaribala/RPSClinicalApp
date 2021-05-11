using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSClinicalApp.Models
{
   public class User
    {
        [PrimaryKey,AutoIncrement]
        public long Id { get; set; }
        [MaxLength(50)]
        public String FirstName { get; set; }
        [MaxLength(50)]
        public String LastName { get; set; }
        public String DOB { get; set; }
        [MaxLength(150)]
        public String Email { get; set; }
        public long PhoneNo { get; set; }
        [MaxLength(10)]
        public String Password { get; set; }
    }
}
