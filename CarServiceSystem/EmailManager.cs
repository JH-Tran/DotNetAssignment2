using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace CarServiceSystem
{
    public class EmailManager
    {
        public static void SendInvoice(ServiceLog log, int cost)
        {
            
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("fishsmtp7@gmail.com", "rlbf xeme fynq gnpe");
                MailMessage newMail = new MailMessage();

                string email = log.Customer.Email;

                newMail.From = new MailAddress("fishsmtp7@gmail.com");
                newMail.To.Add(new MailAddress(email));
                newMail.Subject = "Service Confirmation";
                newMail.IsBodyHtml = true;
                newMail.Body = $"<p>Dear {log.Customer.GetFullName()}, <br><br>" +
                               $"We are pleased to inform you that {log.Mechanic.GetFullName()} has completed the following work on your {log.Car.GetName()}<br>" +
                               $"Service Date/Time: {log.CompletionDateTime.ToLongDateString()}<br>" +
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

        //Checks if a given string is a valid email
        public static bool IsValidEmail(string input)
        {
            try
            {
                MailAddress m = new MailAddress(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
