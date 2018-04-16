using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WD.Models
{
    public class Post
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }
        public long UploadedBy { get; set; }
        public DateTime UploadDate { get; set; }
        public string TwitterPost { get; set; }
        public bool Reviewed { get; set; }
        [NotMapped]
        public long[] RelatedIDs { get; set; }
        public long Likes { get; set; }
        public long Dislikes { get; set; }
    }
}
