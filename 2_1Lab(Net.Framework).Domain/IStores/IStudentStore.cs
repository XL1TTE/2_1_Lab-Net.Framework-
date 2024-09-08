using _2_1Lab_Net.Framework_.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Lab_Net.Framework_.Domain.IStores
{
    public interface IStudentStore
    {
        IStudentRepository studentRepository { set; }

        bool IsStudentExist(Student student);
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        void UpdateStudent(Student studentToUpdate, Student student);
        List<Student> GetAllStudents();
        (List<string>, List<int>) GetStudentSpecialitiesData();
    }
}
