using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.CrossCutting.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureService.ConfigureDependenciesService(services);
            ConfigureRepository.ConfigureDependenciesRepository(services);

            // Isso define o ambiente da aplicação, por exemplo Dev, QA/Stage, Prod. É considerado uma boa prática definir nas variáveis de ambiente. 
            // Aqui no VSCode a definição do ambiente como Development fica em .vscode/launch.json
            // Environment.SetEnvironmentVariable("DB_CONNECTION", "COLOCAR STRING DE CONEXAO");
            // Environment.SetEnvironmentVariable("DATABASE", "MYSQL");
            // Environment.SetEnvironmentVariable("MIGRATION", "APLICAR");
            // Environment.SetEnvironmentVariable("Audience", "ExemploAudience");
            // Environment.SetEnvironmentVariable("Issuer", "ExemploIssue");
            // Environment.SetEnvironmentVariable("Seconds", "28800");

            services.AddControllers();

            services.AddSwaggerGen(s =>
                s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "Deloitte. | Processo seletivo - Case de Henrique Batista",
                    Description = "API Rest utilizando o Framework .Net 5.0 (C#), considerando os requisitos solicitados pela Deloitte ao candidato.",
                    TermsOfService = new Uri("http://github.com"),
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Henrique Batista Liduario",
                        Email = "henrique.liduario@hotmail.com",
                        Url = new Uri("https://linked.in"),
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense
                    {
                        Name = "Termo de consentimento de uso de dados pessoais",
                        Url = new Uri("https://deloitte.com")
                    }

                })
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Henrique Batista | Case Deloitte.");
                s.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
