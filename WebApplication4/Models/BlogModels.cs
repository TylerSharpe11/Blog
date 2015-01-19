using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }
        [Key]
        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public Nullable<DateTimeOffset> Updated { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string MediaURL { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("")]
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public DateTimeOffset Created { get; set; }
        public Nullable<DateTimeOffset> Updated { get; set; }
        public string UpdateReason { get; set; }
        public string Title { get; set; }

        public virtual Post ParentPost { get; set; }
        public virtual ApplicationUser Author { get; set; }
        //public virtual Comment ParentComment { get; set; }
    }
}