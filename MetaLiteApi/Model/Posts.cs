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
        public int postId { get; }

        public string Title 
        { 
            get { return Title; } 
            set 
            {
                if (!Helper.IsTooLong(value))
                {
                    Title = value;
                }
            } 
        }

        public string Describstion 
        { 
            get { return Describstion; }
            set { }
        }

        public Image Image 
        { 
            get { return Image; }
            set { } 
        }

        [ForeignKey("UserId")]
        public Users User
        {
            get { return User; } 
            set { }
        }

        
    }
}
