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

            const string ACCOUNT_SID = "ACca95547b1aea15670c8961464ecdc0df";
            const string AUTH_TOKEN = "f53898756484b46ce91c39c89d017ad2";

            TwilioClient.Init(ACCOUNT_SID, AUTH_TOKEN);

            MessageResource.CreateAsync(
                body: message.Body,
                from: new PhoneNumber("(616)940-5667"),
                to: new PhoneNumber(message.Destination));

            return Task.FromResult(0);
        }
    }
}