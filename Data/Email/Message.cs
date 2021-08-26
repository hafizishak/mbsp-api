using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using MimeKit;

namespace Iaf.API.Data.Email
{
public class Message
{
    public List<MailboxAddress> To { get; set; }
    public List<MailboxAddress> Cc { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public IFormFileCollection Attachments { get; set; }
    public FormFile Attachment { get; set; }
    public Message(IEnumerable<string> to, IEnumerable<string> cc, string subject, string content, FormFile attachments)
    {
        To = new List<MailboxAddress>();
        Cc = new List<MailboxAddress>();
 
        To.AddRange(to.Select(x => new MailboxAddress(x)));
        Cc.AddRange(cc.Select(x => new MailboxAddress(x)));
        Subject = subject;
        Content = content;   
        Attachment = attachments;     
    }
}
}