using LikeChecker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeChecker.EntityFramework
{
    public class VideoContext:DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}
