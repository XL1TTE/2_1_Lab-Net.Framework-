using _2_1Lab_Net.Framework_.Application.DataTransferObjects;
using _2_1Lab_Net.Framework_.Application.IStores;
using _2_1Lab_Net.Framework_.Domain;
using _2_1Lab_Net.Framework_.Infrastracture.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Lab_Net.Framework_.Application
{
    public class StudentService : IStudentService
    {
        public IStudentRepository studentRepository { get; set; }
        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public bool IsStudentExist(StudentDto studentDto)
        {
            var student = DtoMappers.StudentMapper(studentDto);
            return studentRepository.IsStudentExist(student);
        }
        public void AddStudent(StudentDto studentDto)
        {
            var student = DtoMappers.StudentMapper(studentDto);
            studentRepository.AddStudent(student);
        }

        public void UpdateStudent(StudentDto studentToUpdate, StudentDto studentDto)
        {
            var StudentToUpdate = DtoMappers.StudentMapper(studentToUpdate);
            var Student = DtoMappers.StudentMapper(studentDto);
            studentRepository.UpdateStudent(StudentToUpdate, Student);
        }

        public List<StudentDto> GetAllStudents()
        {
            return DtoMappers.StudentMapper(studentRepository.GetAllStudents());
        }

        public void RemoveStudent(StudentDto student)
        {
            var Student = DtoMappers.StudentMapper(student);
            studentRepository.RemoveStudent(Student);
        }

        /// <summary>
        /// Return information about count of students in each speciality.
        /// </summary>
        /// <returns>(List of specialities, List of student applied to it.)</returns>
        public (List<string>, List<int>) GetStudentSpecialitiesData()
        {
            var SpecialitesValues = new List<int>();
            var SpicialitiesTitles = new List<string>();

            var specialtyCounts = studentRepository.GetAllStudents()
                .GroupBy(s => s.Speciality)
                .Select(g => new
                {
                    Title = g.Key,
                    Count = g.Count()
                }).ToList();

            foreach (var specialty in specialtyCounts)
            {
                SpicialitiesTitles.Add(specialty.Title);
                SpecialitesValues.Add(specialty.Count);

            }
            return (SpicialitiesTitles, SpecialitesValues);
        }
    }
}
