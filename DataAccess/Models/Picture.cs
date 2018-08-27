using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Picture
    {
        public int PictureID { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int AmountOfLove { get; set; }
        public int Viewer { get; set; }
        public DateTime UploadDate { get; set; }
        public string HashTag { get; set; }

        public User Owner { get; set; }
    }
}
