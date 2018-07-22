using GraphQL;
using GraphQL.Server.Transports.AspNetCore;
using GraphQL.Server.Transports.WebSockets;
using GraphQL.Server.Transports.WebSockets.Events;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GQ;
using Microsoft.AspNetCore.Mvc.Cors.Internal;


namespace Project.DistributedService.WebHostGQ
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
            services.AddCors(options =>
            {
                options.AddPolicy("localhost", builder =>
                {
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .AllowAnyMethod();
                });
            });


            services.AddSingleton<IBudgetProjectService, BudgetProjectService>();
            services.AddSingleton<IProjectManagementSystemProjectReportPlanItemsService, ProjectManagementSystemProjectReportPlanItemsService>();
            services.AddSingleton<IPriceRepertoryService, PriceRepertoryService>();


            services.AddSingleton<ProjectSchema>();
            services.AddSingleton<ProjectQuery>();

            #region budgetProjectType
            services.AddSingleton<BudgetProjectType>();
            #endregion
            #region projectManagementSystemProjectReportType
            services.AddSingleton<ProjectManagementSystemProjectReportPlanItemsType>();
            services.AddSingleton<PostProjectManagementSystemProjectReportPlanDocumentsType>();
            services.AddSingleton<PostProjectManagementSystemProjectReportPlanContractorsPriceType>();
            services.AddSingleton<PostProjectManagementSystemProjectReportAttachmentsDialogType>();
            services.AddSingleton<PostProjectManagementSystemProjectReportSendToCartableType>();
            #endregion
            #region priceRepertoryType
            services.AddSingleton<BasePriceRepertoryType>();
            services.AddSingleton<PriceRepertoryType>();
            services.AddSingleton<PriceRepertoryFinancialYearsType>();
            #endregion



            services.AddSingleton<IEventAggregator, SimpleEventAggregator>();
            services.AddSingleton<IDependencyResolver>(c => new FuncDependencyResolver(type => c.GetRequiredService(type)));

            services.AddSingleton<IHttpClientFactory, HttpClientFactory>();

            //services.AddAutoMapper();
            //services.AddNikGraphQL();

            services.AddGraphQLHttp();
            services.AddGraphQLWebSocket<ProjectSchema>();
            services.AddMvc(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("localhost"));               
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("localhost");

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseDefaultFiles();
            app.UseStaticFiles();
                    
            app.UseWebSockets();
            app.UseGraphQLWebSocket<ProjectSchema>(new GraphQLWebSocketsOptions());
            app.UseGraphQLHttp<ProjectSchema>(new GraphQLHttpOptions());            
            app.UseMvc();
        }
    }
}
