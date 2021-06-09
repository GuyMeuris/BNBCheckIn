using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace BnBCheckIn_Api.Helper
{   
    public class EmailSender : IEmailSender
    {
        // First we need to include our 'MailJetSettings'-object using depency injection
        // in order to retrieve our MailJet keys.

        private readonly MailJetSettings _mailJetSettings;

        public EmailSender(IOptions<MailJetSettings> mailjetSettings)
        {
            _mailJetSettings = mailjetSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient(_mailJetSettings.PublicKey,
                _mailJetSettings.PrivateKey);

            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
               .Property(Send.FromEmail, _mailJetSettings.Email)
               .Property(Send.FromName, "B&BCheckIn")
               .Property(Send.Subject, subject)
               .Property(Send.HtmlPart, htmlMessage)
               .Property(Send.Recipients, new JArray {
                new JObject {
                 {"Email", email}
                 }
                   });

            MailjetResponse response = await client.PostAsync(request);

        }
    }
    
}
