using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace Andy06.Models
{
    public class Contact
    {
        public string name { get; set; }
        public string emailAddress { get; set; }
        public string subject { get; set; }
        public string message { get; set; }


        public void sendEmail()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("stewartclay166@gmail.com", "clayboydog");

            MailMessage mm = new MailMessage(emailAddress, "stewartclay166@gmail.com", subject, message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }
    }

}