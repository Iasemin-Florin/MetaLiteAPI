using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MetaLiteApi
{
    [Table("Posts")]
    public class Posts
    {
        [Key]
        public int postId { get; set; }
        private string _title;
        private string _describstion;
        private string _image;



        public string Title 
        { 
            get { return _title; } 
            set 
            {
                if (!Helper.IsTooLong(value))
                {
                    _title = value;
                }
            } 
        }

        public string Describstion 
        { 
            get { return _describstion; }
            set { _describstion = value; }
        }

        public string Image 
        { 
            get { return _image; }
            set { _image = value; } 
        }

        [ForeignKey("UserId")]
        public Users User
        {
            get { return User; } 
            set { }
        }

        public Posts(string title, string description, string image)
        {
            Title = title;
            Describstion = description;
            Image = image;
        }
        
    }
}
