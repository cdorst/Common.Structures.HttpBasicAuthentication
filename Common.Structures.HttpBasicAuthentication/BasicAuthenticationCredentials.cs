using static System.Convert;
using static System.Text.Encoding;

namespace Common.Structures.HttpBasicAuthentication
{
    public class BasicAuthenticationCredentials : HttpAuthentication.HttpAuthentication
    {
        private const string Basic = nameof(Basic);

        public BasicAuthenticationCredentials(string user, string secret)
            : base(Basic, ToBase64String(UTF8.GetBytes($"{user}:{secret}")))
        {
        }
    }
}
