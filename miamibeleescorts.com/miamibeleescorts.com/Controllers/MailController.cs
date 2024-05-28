using miamibeleescorts.com.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using System.ComponentModel.DataAnnotations;

namespace miamibeleescorts.com.Controllers
{
    public class MailController : Controller
    {
        [HttpPost]
        public IActionResult ProcessForm(BuyNowModel bn, ContactUsModel cu, LogicModel l, JoinFormModel j)
        {
            if (ModelState.IsValid)
            {
                string body;
                if (!string.IsNullOrEmpty(bn.BuyFirstName)) // Check if formData contains fields specific to the first method
                {
                    body = ConstructBodyFromBuyNowModel(bn);
                    l.Subject = $"Miami Bele Escorts Booking Form: {bn.BuyFirstName}";
                }
                else if (!string.IsNullOrEmpty(cu.ContactFullName)) // Check if mailModel contains fields specific to the second method
                {
                    body = ConstructBodyFromContactUsModel(cu);
                    l.Subject = $"Miami Bele Escorts Contact Form: {cu.ContactFullName}";
                }
                else if (!string.IsNullOrEmpty(j.JoinFirstName)) // Check if mailModel contains fields specific to the second method
                {
                    body = ConstructBodyFromJoinUsModel(j);
                    l.Subject = $"Miami Bele Escorts Employment Form: {j.JoinFirstName}";
                }
                else
                {
                    // Handle the case where neither set of data is present
                    return BadRequest("Invalid form data");
                }


                using (var client = new SmtpClient())
                {
                    client.Host = l.Smtp; // Your SMTP server (e.g., Gmail)
                    client.Port = l.Port; // SMTP Port (Gmail uses 587)
                    //client.EnableSsl = true;
                    //client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(l.Login, l.Password);
                    var message = new MailMessage();
                    message.From = new MailAddress(l.FromEmail, l.FromName); // Your email address
                    string[] toEmails = l.ToEmail.Split(',');
                    foreach (string email in toEmails)
                    {
                        message.To.Add(email.Trim());
                    }
                    message.Subject = l.Subject; // Email subject
                    message.IsBodyHtml = true;
                    message.Body = body;



                    client.Send(message);
                }
                return RedirectToAction("thankyou", "Home");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }

            return RedirectToAction("Index", "Home");
        }

        private string ConstructBodyFromBuyNowModel(BuyNowModel bn)
        {
            return $"Booking request from Miami Bele Escorts. <br /><br />" +
                   $"Details: <br /><br />" +
                   $"Escort Name: {bn.BuyEscortname}<br>" +
                   $"Escort Name Alternative: {bn.BuyEscortname1}<br>" +
                   $"First Name: {bn.BuyFirstName}<br>" +
                   $"Phone: {bn.BuyPhone}<br>" +
                   $"Email: {bn.BuyEmail}<br>" +
                   //$"Last Name: {bn.BuyLastName}<br>" +
                   $"On Which Date: {bn.BuyHotelName}<br>" +
                   $"Hotel Room: {bn.BuyHotelRoom}<br>" +
                   $"Request: {bn.BuyRequest}<br>";
        }

        private string ConstructBodyFromContactUsModel(ContactUsModel cu)
        {
            return $"There is a contact request from Miami Bele Escorts<br />" +
                   $"Details: <br />" +
                   $"FullName: {cu.ContactFullName}<br>" +
                   //$"Phone: {cu.ContactPhone}<br>" +
                   $"Email: {cu.ContactEmail}<br>" +
                   //$"Subject: {cu.ContactSubject}<br>" +
                   $"Message: {cu.ContactMessage}<br>";
        }
        private string ConstructBodyFromJoinUsModel(JoinFormModel j)
        {
            return "Employment request from Miami Bele Escorts.<br />" +
                $"Details:<br /> " +
                $"<br />First Name: {j.JoinFirstName}. " +
                $"<br />Last Name: {j.JoinLastName}. " +
                $"<br />Age: {j.JoinAge}. " +
                $"<br />Email: {j.JoinEmail}. " +
                $"<br />Nationality: {j.JoinNationality}. " +
                $"<br />Phone no: {j.JoinPhone}. " +
                $"<br />Short Description: {j.JoinShortDescription}. " +
                $"<br />Height: {j.JoinHeight}. " +
                $"<br />Weight: {j.JoinWeight}";

        }
    }
}
