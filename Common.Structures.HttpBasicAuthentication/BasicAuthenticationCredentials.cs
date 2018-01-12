using Common.Structures.HttpAuthentication;
using static System.Convert;
using static System.Text.Encoding;

namespace Common.Structures.HttpBasicAuthentication
{
    public class BasicAuthenticationCredentials : HttpAuthentication
    {
        private const string Basic = nameof(Basic);

        private readonly string _secret;
        private readonly string _user;

        public BasicAuthenticationCredentials(string user, string secret) : base(Basic)
        {
            _secret = secret;
            _user = user;
        }

        protected override string Value
            => ToBase64String(UTF8.GetBytes($"{_user}:{_secret}"));
    }
}
