using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeChecker.Models
{
    public class Video
    {
        public int Id { get;private set; }
        public string Name { get; set; }
        public string Url { get; set; }
        //public int LikesCount { get; set; }
        //public int ViewsCount { get; set; }
        //public int CommentsCount { get; set; }
    }
}
