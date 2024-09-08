using _2_1Lab_Net.Framework_.Domain.IStores;
using _2_1Lab_Net.Framework_.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Lab_Net.Framework_.ConsoleClient
{
    public class StudentConsoleHandler
    {
        private IStudentStore _studentStore;
        public StudentConsoleHandler(IStudentStore studentStore)
        {
            _studentStore = studentStore;
        }

        private void OutputAllStudentsToConsole()
        {

            string output = "";
            int counter = 0;
            var students = _studentStore.GetAllStudents();

            foreach (var student in students)
            {
                counter++;
                output += $"{counter}. {student.Name} | {student.Group} | {student.Speciality} \n";
            }

            Console.WriteLine(output);

        }

        private Student ConsoleBuildStudent()
        {
            Console.WriteLine("Введите имя: ");

            var name = Console.ReadLine();

            Console.WriteLine("Введите группу: ");

            var group = Console.ReadLine();

            Console.WriteLine("Введите специализацию: ");

            var speciality = Console.ReadLine();

            return new Student(name, speciality, group);
        }

        public void UpdateConsole()
        {
            Console.Clear();
            OutputAllStudentsToConsole();
            Console.WriteLine("\n Комманды: \n1. Добавить студента. \n2. Удалить студента. \n3. Обновить студента. \n4. Выйти.");

        }

        public void AddStudent()
        {
            var student = ConsoleBuildStudent();
            _studentStore.AddStudent(student);
            UpdateConsole();

        }

        public void RemoveStudent()
        {
            Console.WriteLine("Какого студента удалить (Введите номер)");
            var index = Int32.Parse(Console.ReadLine()) - 1;

            var student = _studentStore.GetAllStudents()[index];
            _studentStore.RemoveStudent(student);
            UpdateConsole();
        }

        public void UpdateStudent()
        {
            Console.WriteLine("Какого студента обновить (Введите номер)");
            var index = Int32.Parse(Console.ReadLine()) - 1;
            var student = ConsoleBuildStudent();

            _studentStore.GetAllStudents()[index] = student;
            UpdateConsole();
        }


    }
}
