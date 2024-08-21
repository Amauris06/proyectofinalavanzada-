using Microsoft.Extensions.DependencyInjection;

namespace Northwind
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceCollection services = new ServiceCollection();
             

            services.AddScoped<Form1>();
            var serviceprovider = services.BuildServiceProvider();







            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(serviceprovider.GetService <Form1>());


        }
    }
}