using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.eFolderAttachments
{
    public class Attachment
    {
        public Attachment()
        {
            document = new eFolderAttachments.Document();
            pages = new List<eFolderAttachments.Pages>();
        }
        public string title { get; set; }
        public string attachmentId { get; set; }
        public Document document { get; set; }
        public DateTime dateCreated { get; set; }
        public string createdBy { get; set; }
        public string createByName { get; set; }
        public int? attachmentType { get; set; } 
        public int? fileSize { get; set; }
        public bool isActive { get; set; }
        public int? rotation { get; set; }
        public List<Pages> pages { get; set; }

    }
}
