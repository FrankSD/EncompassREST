using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.eFolderAttachments
{
    public class Annotation
    {
        public DateTime? dateCreated { get; set; }
        public string createdBy { get; set; }
        public string text { get; set; }
        public int? left { get; set; }
        public int? top { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public int? visibilityType { get; set; }
    }
}
