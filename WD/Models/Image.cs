using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WD.Models
{
    public class Image
    {
        public long ImageID { get; set; }
        public long PostId { get; set; }
        public byte[] TinyImage { get; set; }
        public byte[] Small { get; set; }
        public byte[] Medium { get; set; }
        public byte[] Large { get; set; }
    }
}
