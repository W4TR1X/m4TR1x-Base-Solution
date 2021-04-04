using m4TR1x.Core.Models;
using m4TR1x.Core.Models.MailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Business.Interfaces
{
    public interface IMailService
    {
        MailModel ComposeMail(string title);

        Exception SendMail(MailModel model, List<Attachment> attachments = null);
    }
}
