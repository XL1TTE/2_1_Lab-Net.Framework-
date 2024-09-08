using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Lab_Net.Framework_.Domain.IRepositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();

        bool IsStudentExist(Student student);
        void AddStudent(Student student);
        void UpdateStudent(Student studentToUpdate, Student Student);
        void RemoveStudent(Student student);
    }
}
