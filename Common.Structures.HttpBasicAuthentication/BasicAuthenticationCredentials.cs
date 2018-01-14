using Common.Structures.HttpAuthentication;
using static System.Convert;
using static System.Text.Encoding;

namespace Common.Structures.HttpBasicAuthentication
{
    public class BasicAuthenticationCredentials : HttpAuthentication.HttpAuthentication
    {
        public BasicAuthenticationCredentials(string user, string secret)
            : base(PrefixType.Basic, ToBase64String(UTF8.GetBytes($"{user}:{secret}")))
        {
            User = user;
        }

        public string User { get; set; }
    }
}
