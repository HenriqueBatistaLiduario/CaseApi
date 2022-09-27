using System;
using Api.CrossCutting.DependencyInjection;
using Api.Domain.Security;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Collections.Generic;

namespace application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Isso define o ambiente da aplicação, por exemplo Dev, QA/Stage, Prod. É considerado uma boa prática definir nas variáveis de ambiente. 
        // Aqui no VSCode a definição do ambiente como Development fica em .vscode/launch.json, e as variáveis estão no appsettings.json da camada Application
        // Environment.SetEnvironmentVariable("DB_CONNECTION", "COLOCAR STRING DE CONEXAO");
        // Environment.SetEnvironmentVariable("DATABASE", "MYSQL");
        // Environment.SetEnvironmentVariable("MIGRATION", "APLICAR");
        // Environment.SetEnvironmentVariable("Audience", "CaseApiAudience");
        // Environment.SetEnvironmentVariable("Issuer", "CaseApiIssuer");
        // Environment.SetEnvironmentVariable("Seconds", "28800");

        // Método chamado pelo tempo de execução para adicionar serviços ao contêiner.
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureService.ConfigureDependenciesService(services);
            ConfigureRepository.ConfigureDependenciesRepository(services);

            var signingConfigurations = new SigningConfigurations();
            services.AddSingleton(signingConfigurations);

            var tokenConfigurations = new TokenConfigurations();
            new ConfigureFromConfigurationOptions<TokenConfigurations>(Configuration.GetSection("TokenConfigurations")).Configure(tokenConfigurations);
            services.AddSingleton(tokenConfigurations);

            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(bearerOptions =>
            {
                var paramsValidation = bearerOptions.TokenValidationParameters;

                paramsValidation.IssuerSigningKey = signingConfigurations.Key;
                paramsValidation.ValidAudience = tokenConfigurations.Audience;
                paramsValidation.ValidIssuer = tokenConfigurations.Issuer;
                paramsValidation.ValidateIssuerSigningKey = true;  // Valida a assinatura de um token recebido                
                paramsValidation.ValidateLifetime = true; // Verifica se um token recebido não está expirado.
                // Tempo de tolerância para a expiração de um token (utilizado caso haja problemas de sincronismo de horário entre diferentes
                // computadores envolvidos no processo de comunicação) //ZERO=Indica que não existe tolerância de tempo para token expirado.
                paramsValidation.ClockSkew = TimeSpan.Zero;
            });

            // Ativa o uso do token como forma de autorizar o acesso a recursos deste projeto
            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme‌​)
                    .RequireAuthenticatedUser().Build());
            });

            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
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
                        Name = "Deloitte - Termo de consentimento de uso de dados pessoais",
                        Url = new Uri("https://deloitte.com")
                    }

                });

                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Informe um token:",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                s.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme {
                            Reference = new OpenApiReference {
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        }, new List<string>()
                    }
                });
            });
        }

        // Método chamado pelo tempo de execução para configurar o pipeline de solicitação HTTP.
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
