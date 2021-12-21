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
        public static string FilePath = Environment.CurrentDirectory + "/FileDB/DBusers.txt";

        [Key]
        public int userId { get; set; }
        [Required]
        private string _username;
        [Required]
        private string _password;
        [Required]
        private string _email;

        
        public string Username {

            get { return _username; }
            set
            {
                if (!Helper.IsTooLong(value))
                {
                    _username = value;
                    Console.WriteLine("Virkede");
                }
                else
                {
                    throw new Exception("too long");
                }
            }
        }

        
        public string Password 
        { 
            get { return _password; }
            set 
            {
                if (!Helper.IsTooLong(value))
                {
                    _password = value;
                }
            }
        }

        
        public string Email 
        { 
            get { return _email; }
            set
            {
                if (!Helper.IsTooLong(value))
                {
                    _email = value;
                }
            }
        }

        public Users(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
