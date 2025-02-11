using Microsoft.VisualBasic.ApplicationServices;
using PlakDükkanıYöneticiModülü.Concrete_Repositories;
using PlakDükkanıYöneticiModülü.Concrete_Service;
using PlakDükkanıYöneticiModülü.Data;
using PlakDükkanıYöneticiModülü.Entities;

namespace PlakDükkanıYöneticiModülü
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
            var context = new AppDbContext();
            Application.Run(new Form1(new YöneticiService(new GenericRepository<Yönetici>(context)),new AlbumService(new GenericRepository<Album>(context))));
        }
    }
}