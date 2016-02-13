using Microsoft.AspNet.Identity;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class EmailService
    {
        public static void SendEmail(IdentityMessage message)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator =
                   new HttpBasicAuthenticator("api",
                                              "key-d26f3bbe12bfa229e702900d1969c335");
            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                "sandbox0dcf244c222b4c5f99426d36b97f1490.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Paathshaala <postmaster@sandbox0dcf244c222b4c5f99426d36b97f1490.mailgun.org>");
            request.AddParameter("to", message.Destination);//"Sai Kasyap <raghusaikasyap@gmail.com>");
            request.AddParameter("subject", message.Subject);
            request.AddParameter("text", message.Body);
            request.Method = Method.POST;
            try {
                client.Execute(request);
            }
            catch(Exception e)
            {
                RuntimeException.LogExceptionWithSource(e,"Could not send confirmation Email to " + message.Destination + "CallBackURL : " + message.Body);
            }            
        }
    }
}
