using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace CarServiceSystem
{
    public class EmailManager
    {
        private static SmtpClient client = new("smtp.gmail.com");
        private static System.Net.NetworkCredential networkCredential =  new("fishsmtp7@gmail.com", "rlbf xeme fynq gnpe");
        private static MailAddress fromAddress = new("fishsmtp7@gmail.com");
        public static void SendInvoice(ServiceLog log, decimal cost)
        {
            try
            {
                client.EnableSsl = true;
                client.Port = 587;
                client.Credentials = networkCredential;
                MailMessage newMail = new MailMessage();
                string email = log.Customer.Email;

                newMail.From = fromAddress;
                newMail.To.Add(new MailAddress(email));
                newMail.Subject = "Service Confirmation";
                newMail.IsBodyHtml = true;
                newMail.Body = $"<p>Dear {log.Customer.GetFullName()}, <br><br>" +
                               $"We are pleased to inform you that {log.Mechanic.GetFullName()} has completed the following work on your {log.Car.GetName()}<br>" +
                               $"Service Date/Time: {log.CompletionDateTime.ToString()}<br>" +
                               $"Description: {log.Task}<br><br>" +
                               $"The total cost will be ${cost}.<br>" +
                               $"Thank you for choosing {log.Mechanic.WorkShopName}<p>";
                client.SendMailAsync(newMail);
                MessageBox.Show("Email Sent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                MessageBox.Show("Error sending email. Pleach check your internet connection and try again. If the issue continues, please contact a service administrator.");
            }
        }



        public static void SendEmail(string toEmail, string subject, string body)
        {
            try 
            { 
                MailMessage newMail = new MailMessage();
                newMail.From = fromAddress;
                newMail.To.Add(new MailAddress(toEmail));
                newMail.Subject = subject;
                newMail.IsBodyHtml = true;
                newMail.Body = body;
                client.EnableSsl = true;
                client.Port = 587;
                client.Credentials = networkCredential;
                client.Send(newMail);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
        }

        //Checks if a given string is a valid email
        public static bool IsValidEmail(string input)
        {
            try
            {
                MailAddress m = new MailAddress(input);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
