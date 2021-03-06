﻿using System;
using System.Net.Http;
using Microsoft.AspNetCore.Authentication;

namespace ActiveLogin.Authentication.GrandId.AspNetCore
{
    public interface IGrandIdAuthenticationBuilder
    {
        AuthenticationBuilder AuthenticationBuilder { get; }

        void ConfigureHttpClient(Action<HttpClient> configureHttpClient);
        void ConfigureHttpClientHandler(Action<HttpClientHandler> configureHttpClientHandler);
        void EnableHttpClient();
    }
}