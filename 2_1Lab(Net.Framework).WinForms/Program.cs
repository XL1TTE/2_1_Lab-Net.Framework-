using _2_1Lab_Net.Framework_.Application;
using _2_1Lab_Net.Framework_.Application.IStores;
using _2_1Lab_Net.Framework_.Infrastracture;
using _2_1Lab_Net.Framework_.Infrastracture.IRepositories;
using _2_1Lab_Net.Framework_.WinForms.Controls;
using _2_1Lab_Net.Framework_.WinForms.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1Lab_Net.Framework_.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IStudentRepository, StudentRepository>()
                .AddSingleton<IStudentService, StudentService>()
                .AddSingleton<StudentListForm>()
                .AddSingleton<StudentTableView>()
                .AddSingleton<StudentGraphicsView>()
                .AddSingleton<Func<Type, UserControl>>(p => type => (UserControl)p.GetRequiredService(type))
                .AddSingleton<INavigationService, NavigationService>()
                .BuildServiceProvider();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(serviceProvider.GetRequiredService<StudentListForm>());
        }
    }
}
