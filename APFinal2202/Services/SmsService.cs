using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace APFinal2202.Services
{
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {

            const string ACCOUNT_SID = "AC78bf851173148cd39d1524624d5e0e2b";
            const string AUTH_TOKEN = "fc9c16744f07b27f1979048feac3c88d";

            TwilioClient.Init(ACCOUNT_SID, AUTH_TOKEN);

            var sms = MessageResource.CreateAsync(
                body: message.Body,
                from: new PhoneNumber("(925)329-3625"),
                to: new PhoneNumber(message.Destination));

            return Task.FromResult(0);
        }
    }
}