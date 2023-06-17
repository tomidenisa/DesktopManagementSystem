using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRUDOP2
{
    public class GmailAuth
    {
        private string clientId = "629095940802-33l5lmh8dec3ik38n9off66ef6li985g.apps.googleusercontent.com";
        private string clientSecret = "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";
        private string[] scopes = { GmailService.Scope.MailGoogleCom };

        public async Task<string> GetAccessTokenAsync()
        {
            UserCredential credential;
            using (var stream = new FileStream(@"C:\Users\denit\Downloads\client_secret_629095940802-33l5lmh8dec3ik38n9off66ef6li985g.apps.googleusercontent.com.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None);
            }

            string accessToken = credential.Token.AccessToken;
            return accessToken;
        }
    }
}

