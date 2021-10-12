using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HbHomework.Models
{
    public class Product : Model
    {

        public int ProductId { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        /*public float Score { get
            {
                float score = 0;
                foreach(Comment comment in Comments)
                {
                    score += comment.Score;
                }
                return score / Comment.CommentCount;
            } }*/
        //public ICollection<Comment> Comments { get; set; }
    }
}
