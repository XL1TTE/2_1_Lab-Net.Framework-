﻿using _2_1Lab_Net.Framework_.Application;
using _2_1Lab_Net.Framework_.Application.IStores;
using _2_1Lab_Net.Framework_.Infrastracture;
using _2_1Lab_Net.Framework_.Infrastracture.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Lab_Net.Framework_.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _serviceProvider = new ServiceCollection()
            .AddSingleton<IStudentService, StudentService>()
            .AddSingleton<IStudentRepository, StudentRepository>()
            .AddSingleton<StudentConsoleHandler>()
            .BuildServiceProvider();

            var StudentConsoleHandler = _serviceProvider.GetRequiredService<StudentConsoleHandler>();

            var Exit = false;

            StudentConsoleHandler.UpdateConsole();

            while (!Exit)
            {

                Console.WriteLine("Введите номер операции.");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        StudentConsoleHandler.AddStudent();
                        break;
                    case "2":
                        StudentConsoleHandler.RemoveStudent();
                        break;

                    case "3":
                        StudentConsoleHandler.UpdateStudent();
                        break;
                    case "4":
                        StudentConsoleHandler.GetStudentSpecialitiesData();
                        break;
                    case "5":
                        Exit = true;
                        break;
                }

            }
        }
    }
}
