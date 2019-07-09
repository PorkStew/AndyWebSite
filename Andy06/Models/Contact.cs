using System.Net;
using System.Net.Mail;

namespace Andy06.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string GetMessage { get; set; }


        public void sendEmail()
        {
            MailMessage messages = new System.Net.Mail.MailMessage();
            //from a fake email to send to you
            string fromEmail = "WebsiteEmailSender123@gmail.com";
            string password = "maximus11711A";
            //change this email once complete to main 
            string toEmail = "andyclay23@gmail.com";
            messages.From = new MailAddress(fromEmail);
            messages.To.Add(toEmail);
            messages.Subject = Subject;

            messages.Body = GetMessage + " " + EmailAddress;
            messages.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromEmail, password);

                smtpClient.Send(messages.From.ToString(), messages.To.ToString(), messages.Subject, messages.Body);
            }
        }
    }

}