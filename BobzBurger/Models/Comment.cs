using System.ComponentModel.DataAnnotations;

// TODO : Remove or/redo?
namespace BobzBurger.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PhotoID { get; set; }
        public string UserFirstName { get; set; }
        [Required]
        [StringLength(250)]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
