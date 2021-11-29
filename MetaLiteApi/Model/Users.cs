using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MetaLiteApi
{
    [Table("Users")]
    public class Users
    {
        [Key]
        int userId { get; }

        [Required]
        public string Username {

            get { return Username; }
            set
            {
                if (!Helper.IsTooLong(value))
                {
                    Username = value;
                }
            }
        }

        [Required]
        public string password 
        { 
            get { return password; }
            set 
            {
                if (!Helper.IsTooLong(value))
                {
                    password = value;
                }
            }
        }

        [Required]
        public string Email 
        { 
            get { return Email; }
            set
            {
                if (!Helper.IsTooLong(value))
                {
                    Email = value;
                }
            }
        } 
    }
}
