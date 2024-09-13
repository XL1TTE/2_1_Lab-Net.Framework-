using _2_1Lab_Net.Framework_.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Lab_Net.Framework_.Application.DataTransferObjects
{
    public static class DtoMappers
    {
        #region Student Mappers

        public static Student StudentMapper(StudentDto studentDto)
        {
            return new Student
            {
                Name = studentDto.Name,
                Group = studentDto.Group,
                Speciality = studentDto.Speciality,
            };
        }
        public static StudentDto StudentMapper(Student student)
        {
            return new StudentDto
            {
                Name = student.Name,
                Group = student.Group,
                Speciality = student.Speciality,
            };
        }
        public static List<StudentDto> StudentMapper(List<Student> students)
        {
            List<StudentDto> result = new List<StudentDto>();
            foreach (var student in students)
            {
                var Student = StudentMapper(student);
                result.Add(Student);
            }
            return result;
        }
        public static List<Student> StudentMapper(List<StudentDto> students)
        {
            List<Student> result = new List<Student>();
            foreach (var student in students)
            {
                var Student = StudentMapper(student);
                result.Add(Student);
            }
            return result;
        }

        #endregion
    }
}
