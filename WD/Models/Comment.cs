using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WD.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public byte[] TinyImage { get; set; }
        public string User { get; set; }
        public long UserId { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        [NotMapped]
        public int[] RealatedComments { get; set; }
    }
}
