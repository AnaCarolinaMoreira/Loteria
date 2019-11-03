using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
            Loteria lot = new Loteria(6, 2);
            lot.SortearJogos();
            lot.ExecutarSorteio();

            int[,] result = lot.ApurarResultado();
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)

                  
                    await context.Response.WriteAsync("\t" + result[i, j] );       
                    await context.Response.WriteAsync("\n");
                 //  await context.Response.WriteAsync("{0:00}\t"+result[i, j]);
                

                }


               // await context.Response.WriteAsync("Hello World!"+ numero.ToString());
            });
        }

    }
}
