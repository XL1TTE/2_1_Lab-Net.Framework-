using _2_1Lab_Net.Framework_.Domain;
using _2_1Lab_Net.Framework_.Domain.IStores;
using _2_1Lab_Net.Framework_.WinForms.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1Lab_Net.Framework_.WinForms.Controls
{
    public partial class StudentTableView : UserControl, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private ObservableCollection<Student> studentsToShow;
        public ObservableCollection<Student> StudentToShow
        {
            get { return studentsToShow; }
            set { studentsToShow = value; OnPropertyChanged(); }
        }
        private readonly IStudentStore _studentStore;
        private readonly INavigationService _navigationService;
        public StudentTableView(IStudentStore studentStore, INavigationService navigationService)
        {
            _studentStore = studentStore;
            _navigationService = navigationService;
            InitializeComponent();
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            StudentToShow = new ObservableCollection<Student>(_studentStore.GetAllStudents());

            StudentTable.DataSource = StudentToShow;
                
            StudentTable.Columns[0].HeaderText = "Имя";
            StudentTable.Columns[1].HeaderText = "Группа";
            StudentTable.Columns[2].HeaderText = "Специальность";

        }
        private void AddStudentButton_Click(object sender, EventArgs e)
        {

            var studentToAdd = BuildStudentFromForm();
            if (!_studentStore.IsStudentExist(studentToAdd))
            {
                _studentStore.AddStudent(studentToAdd);

                LoadStudentData();
            }
            else
            {
                MessageBox.Show("Студент с такими данными уже существует, если хотите изменить его данные, нажмите кнопку изменить.");
            }


        }
        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            var studentToDelete = BuildStudentFromForm();
            _studentStore.RemoveStudent(studentToDelete);

            LoadStudentData();

        }

        private void SelectedStudentChangedHandler(object sender, EventArgs e)
        {
            var student = BuildStudentFromTable();
            if (student != null)
            {

                StudentNameBox.Text = student.Name;
                StudentGroupBox.Text = student.Group;
                StudentSpecialityBox.Text = student.Speciality;

            }
        }

        private Student BuildStudentFromForm()
        {
            var student = new Student
            {
                Name = StudentNameBox.Text,
                Speciality = StudentSpecialityBox.Text,
                Group = StudentGroupBox.Text,

            };
            return student;
        }

        private Student BuildStudentFromTable()
        {
            if (StudentTable.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = StudentTable.SelectedRows[0];

                Student student = (Student)selectedRow.DataBoundItem;

                return student;
            }
            else
            {
                return null;
            }
        }

        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            var Student = BuildStudentFromForm();
            var StudentToUpdate = BuildStudentFromTable();
            if(StudentToUpdate != null)
            {
                _studentStore.UpdateStudent(StudentToUpdate, Student);
                LoadStudentData();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выделите студента, данные которого хотите обновить в таблицы.");
            }

        }

        private void GoToGraphicButton_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo<StudentGraphicsView>();
        }
    }
}
