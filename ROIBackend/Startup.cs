using Microsoft.Extensions.DependencyInjection;
using ROIBackend.Model;
using ROIBackend.Service;

namespace ROIBackend
{
 
    public class Startup
    {
      

        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddSingleton<IStaffService, StaffServices>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
         
        }
    }
}
