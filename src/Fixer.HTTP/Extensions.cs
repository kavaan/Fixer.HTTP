using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Fixer.HTTP
{
    public static class Extensions
    {
        private const string SectionName = "httpClient";
        private const string RegistryName = "http.client";

        public static IFixerBuilder AddHttpClient(this IFixerBuilder builder, string sectionName = SectionName)
        {
            if (!builder.TryRegister(RegistryName))
            {
                return builder;
            }

            var options = builder.GetOptions<HttpClientOptions>(sectionName);
            builder.Services.AddSingleton(options);
            builder.Services.AddHttpClient<IHttpClient, FixerHttpClient>();

            return builder;
        }
    }
}
