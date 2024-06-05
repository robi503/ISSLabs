using System.Configuration;
using LibraryApp.Controllers;
using LibraryApp.Data;
using LibraryApp.Repositories;
using LibraryApp.Services;
using LibraryApp.VIews;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            var dbContext = new LibraryContext(optionsBuilder.Options);
            CustomerRepository customerRepository = new(dbContext);  
            LibrarianRepository librarianRepository = new(dbContext);
            AccountsService service = new(customerRepository, librarianRepository);
            LoginController mainFormController = new(service);

            // Run the main form
            Application.Run(new LoginForm(mainFormController));
        }
    }
}
