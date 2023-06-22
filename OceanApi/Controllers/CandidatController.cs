using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using System.Collections.Generic;
using OceanApi.Models;

namespace OceanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatController : ControllerBase
    {
        public static List<Candidat> candidats = new List<Candidat>
        {
            new Candidat { Id = 1, nom = "hamid", prenom = "yassine", email = "email@gg.com", telephone = "0638521484", Niveau_etude = "4eme", Dernier_employeur = "rachid", cv = "hht" }
        };

        [HttpGet("get")]
        [Authorize]
        public ActionResult<List<Candidat>> Get()
        {
            return Ok(candidats);
        }

        [HttpPost]     
        public ActionResult<Candidat> Post(Candidat candidat)
        {
            candidats.Add(candidat);
            SendEmail(candidat); // Call the SendEmail method to send an email to the candidate
            return Ok(candidat);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var candidat = candidats.Find(c => c.Id == id);
            if (candidat == null)
                return NotFound();

            candidats.Remove(candidat);
            return NoContent();
        }

        private void SendEmail(Candidat candidat)
        {
            // Create the email message
            var message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse("liza.nitzsche61@ethereal.email"));
            message.To.Add(MailboxAddress.Parse("liza.nitzsche61@ethereal.email"));
            message.Subject = "Thank you for your application";
            message.Body = new TextPart("plain")
            {
                Text = $"Dear {candidat.nom},\n\nThank you for your application. We have received your details and will review them soon.\n\nBest regards,\nThe OceanApi Team"
            };

            // Configure and send the email
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.ethereal.email", 587, false);
                client.Authenticate("liza.nitzsche61@ethereal.email", "bKWr4CyhjfF5ddDT8U");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
