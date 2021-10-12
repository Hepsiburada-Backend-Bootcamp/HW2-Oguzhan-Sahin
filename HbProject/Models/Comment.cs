using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbHomework.Models
{
    public class Comment : Model
    {
        public static int CommentCount = 0;
        public Comment()
        {
            CommentCount++;
        }
        public int Id { get; set; }
        public string NickName { get; set; }
        public string UserComment { get; set; }
        public DateTime Date { get; set; }
        public float Score { get; set; }
        public Product Product { get; set; }
    }
}
