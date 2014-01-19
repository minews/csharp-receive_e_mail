using LumiSoft.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiveMail
{
    public class MailInfo
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public long Size { get; set; }
        public string Content { get; set; }
        public int AttachmentsLength { get; set; }
    }
}
