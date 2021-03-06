using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Swagger
{
    public class ConfigureerSwaggerOpties : IConfigureOptions<SwaggerGenOptions>
    {
        readonly IApiVersionDescriptionProvider _provider;

        // ctor met DI: 
        public ConfigureerSwaggerOpties(IApiVersionDescriptionProvider provider)
                => _provider = provider;

        // Zet alle omschrijvingen van alle versies in SwaggerDoc

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var desc in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(
                    desc.GroupName, new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = $"WEB-API {desc.ApiVersion}",
                        Version = desc.ApiVersion.ToString()
                    });
            }
        }
    }
}
