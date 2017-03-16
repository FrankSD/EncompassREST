using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.eFolderAttachments
{
    public class Thumbnail
    {
        public string imageKey { get; set; }
        public string zipKey { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public decimal? horizonalResolution { get; set; }
        public decimal? verticalResolution { get; set; }
    }
}
