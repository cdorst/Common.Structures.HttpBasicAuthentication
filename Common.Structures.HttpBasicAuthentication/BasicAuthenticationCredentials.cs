﻿using Common.Structures.HttpAuthentication;
using System.Net.Http.Headers;
using static System.Convert;
using static System.Text.Encoding;

namespace Common.Structures.HttpBasicAuthentication
{
    public class BasicAuthenticationCredentials : IHttpAuthentication
    {
        private const string Basic = nameof(Basic);

        public BasicAuthenticationCredentials(string user, string secret)
        {
            User = user;
            Secret = secret;
        }

        public string User { get; set; }
        public string Secret { get; set; }

        public AuthenticationHeaderValue Header
            => new AuthenticationHeaderValue(Basic, HeaderValue);

        private string HeaderValue
            => ToBase64String(UTF8.GetBytes($"{User}:{Secret}"));
    }
}
