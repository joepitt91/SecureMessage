using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Message
{
    class Message
    {
        internal string MessageID;
        internal byte[] From;
        internal string FromDisplayName;
        internal byte[] To;
        internal string ToDisplayName;
        internal string Subject;
        internal DateTime Sent;
        internal bool Expires;
        internal DateTime ExpiryDate;
        internal string Body;
        internal int AttachmentCound;
        internal List<Attachment> Attachments;
    }
}
