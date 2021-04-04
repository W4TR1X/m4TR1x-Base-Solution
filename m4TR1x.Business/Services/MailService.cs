using m4TR1x.Business.Interfaces;
using m4TR1x.Core.Models;
using m4TR1x.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mail;
using System.Text;

namespace m4TR1x.Business.Services
{
    public class MailService : BaseService, IMailService
    {
        private const int SMTP_PORT = 25;
        private const string SMTP_IP = "";

        private const string DEVELOPER_MAIL_ADDRESS = "";
        private const string SENDER_MAIL_ADDRESS = "";

        private const string FOOTER_TEXT = "";

        public MailModel ComposeMail(string title)
        {
            return new MailModel()
            {
                Title = title
            };
        }

        private string MailTop(MailModel model) =>
            @"<!DOCTYPE html><html xmlns=""https: //www.w3.org/1999/xhtml"" lang=""tr""><head><meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">" +
            @"<title>" + model.Title + @"</title><meta http-equiv=""X-UA-Compatible"" content=""IE=edge""><meta name=""viewport"" content=""width=device-width, initial-scale=1"">" +
            @"<style>body{font: 62.5%/1.3 normal Helvetica, sans-serif;}p{font-size: 1.6em;}h1{font-size: 1.9em;}table{border-collapse: collapse; width: 100%;}" +
            @"td, th{text-align: center; border: 1px solid #ddd; padding:.5em 5px; font-size: 1.2em;}th{background-color:#444;font-weight: bold;color: #fff;}.emp-sales " +
            @"tr:hover{background-color: #f2f2f2;color: #000;}.emp-sales td:hover{background-color: #fff2f2 !important;color: #000;}caption{margin: 0; font-weight: bold; " +
            @"font-size: 1.3em; background: #eee; padding: 10px; border: 1px solid #ddd;}</style></head><body><h1>" + model.Title + "</h1><p>" + model.FirstWords + "</p>";

        private string MailBottom(MailModel model) =>
            @"<p>" + model.LastWords + @"<br/><br/>Bilgilerinize, <br/>Saygılarımızla, <br/>İyi Çalışmalar...</p><table><tr><td style=""border-style:none;font-family: 'Open Sans', " +
            @"Arial, sans-serif; font-size: 11px; line-height: 18px; color: #999999;"" align=""center"" valign=""top""><a style=""font-family: 'Open Sans', Arial, sans-serif; " +
            @"font-size: 18px; line-height: 22px; color: #000000; text-transform: uppercase; letter-spacing: 2px; padding-bottom: 12px;"" href=""#"" target=""_blank"" rel=""noopener"">" +
            @"[" + model.MailState + "]</a><br>© " + DateTime.Now.Year + " " + FOOTER_TEXT + "</td></tr></table></body></html>";

        public Exception SendMail(MailModel model, List<Attachment> attachments = null)
        {
            if (model == null || model.ToList == null)
            {
                return new ArgumentNullException(nameof(model));
            }

            try
            {
                var sb = new StringBuilder();
                sb.Append(MailTop(model));
                sb.Append(@"<table class=""emp-sales""><thead><tr>");

                foreach (var c in model.Columns)
                {
                    sb.Append(@"<th scope=""col"">" + c + "</th>");
                }

                sb.Append("</tr></thead><tbody>");

                foreach (var r in model.Rows)
                {
                    sb.Append("<tr>");

                    foreach (var c in r.Columns)
                    {
                        sb.Append("<td>" + c + "</td>");
                    }

                    sb.Append("</tr>");
                }

                sb.Append("</tbody></table>");

                sb.Append(MailBottom(model));

                var mail = new MailMessage();
                var smtp = new SmtpClient(SMTP_IP);

                mail.Subject = model.Subject;
                mail.From = new MailAddress(SENDER_MAIL_ADDRESS, model.SenderSystem);
                smtp.Credentials = new System.Net.NetworkCredential();

                mail.ReplyToList.Add(new MailAddress(DEVELOPER_MAIL_ADDRESS));

                if (attachments != null && attachments.Count > 0)
                {
                    foreach (var a in attachments)
                    {
                        mail.Attachments.Add(a);
                    }
                }

                if (Debugger.IsAttached)
                {
                    mail.To.Add(DEVELOPER_MAIL_ADDRESS);
                }
                else
                {
                    mail.To.Add(string.Join(", ", model.ToList));

                    if (model.CcList != null && model.CcList.Count > 0)
                    {
                        mail.CC.Add(string.Join(", ", model.CcList));
                    }
                }

                mail.IsBodyHtml = true;

                mail.Body = sb.ToString();

                smtp.EnableSsl = false;
                smtp.Port = SMTP_PORT;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                return ex;
            }

            return null;
        }

        public override void Dispose(bool disposing)
        {

        }
    }
}
