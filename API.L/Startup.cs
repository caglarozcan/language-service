using API.Core.Services;
using API.Core.Services.Abstract;
using API.Data;
using API.Data.Repositories;
using API.Data.Repositories.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API.L
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

			services.AddDbContext<APIContext>(options => options.UseSqlServer(Configuration.GetConnectionString("APIContext")));

			services.AddScoped<ILanguageService, LanguageService>();

			services.AddScoped<ILanguageRepository, LanguageRepository>();
			services.AddScoped<ITranslationRepository, TranslationRepository>();

			services.AddControllers();

			services.AddSwaggerDocument();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseOpenApi();

			app.UseSwaggerUi3();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
