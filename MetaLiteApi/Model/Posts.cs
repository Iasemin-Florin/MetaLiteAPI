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
        [Required]
        private string _title;
        [Required]
        private string _describstion;
        [Required]
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


        public Posts(string title, string describstion, string image)
        {
            Title = title;
            Describstion = describstion;
            Image = image;
        }
        
    }
}
