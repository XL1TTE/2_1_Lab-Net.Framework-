using _2_1Lab_Net.Framework_.Domain;
using _2_1Lab_Net.Framework_.Domain.IRepositories;
using _2_1Lab_Net.Framework_.Domain.IStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Lab_Net.Framework_.Application
{
    public class StudentStore : IStudentStore
    {
        public StudentStore(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public IStudentRepository studentRepository { get; set; }


        public bool IsStudentExist(Student student)
        {
            return studentRepository.IsStudentExist(student);
        }
        public void AddStudent(Student student)
        {
            studentRepository.AddStudent(student);
        }

        public void UpdateStudent(Student studentToUpdate, Student student)
        {
            studentRepository.UpdateStudent(studentToUpdate, student);
        }

        public List<Student> GetAllStudents()
        {
            return studentRepository.GetAllStudents();
        }

        public void RemoveStudent(Student student)
        {
            studentRepository.RemoveStudent(student);
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
