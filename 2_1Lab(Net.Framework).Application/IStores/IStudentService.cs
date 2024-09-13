using _2_1Lab_Net.Framework_.Application.DataTransferObjects;
using _2_1Lab_Net.Framework_.Infrastracture.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Lab_Net.Framework_.Application.IStores
{
    public interface IStudentService
    {
        IStudentRepository studentRepository { set; }

        /// <summary>
        /// Check if a student exist in DataBase.
        /// </summary>
        /// <param name="student">Student instance.</param>
        /// <returns>True if exist and False if does not.</returns>
        bool IsStudentExist(StudentDto student);
        /// <summary>
        /// Adds student to a database.
        /// </summary>
        /// <param name="student">Student instance.</param>
        void AddStudent(StudentDto student);
        /// <summary>
        /// Removes student from a database.
        /// </summary>
        /// <param name="student">Student instance.</param>
        void RemoveStudent(StudentDto student);
        /// <summary>
        /// Update student's data.
        /// </summary>
        /// <param name="studentToUpdate">Instance of student to change.</param>
        /// <param name="student">Instance of student to apply.</param>
        void UpdateStudent(StudentDto studentToUpdate, StudentDto student);
        /// <summary>
        /// Gets all students from DataBase.
        /// </summary>
        /// <returns>List of students.</returns>
        List<StudentDto> GetAllStudents();
        /// <summary>
        /// Get data about distribution of students by spectialities.
        /// </summary>
        /// <returns>(List of specialities, List of students counts.)</returns>
        (List<string>, List<int>) GetStudentSpecialitiesData();
    }

}
