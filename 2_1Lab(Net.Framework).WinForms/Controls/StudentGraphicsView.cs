using _2_1Lab_Net.Framework_.Application.IStores;
using _2_1Lab_Net.Framework_.WinForms.Services;
using LiveCharts;
using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1Lab_Net.Framework_.WinForms.Controls
{
    public partial class StudentGraphicsView : UserControl
    {
        private IStudentService _studentStore;
        private INavigationService _navigationService;
        public StudentGraphicsView(IStudentService studentStore, INavigationService navigationService)
        {
            _studentStore = studentStore;
            _navigationService = navigationService;
            InitializeComponent();
            MakeStudentHistogram();
        }

        private void ToStudentTableButton_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo<StudentTableView>();
        }


        private void MakeStudentHistogram()
        {
            var histogram = new CartesianChart
            {
                Name = "Histogram",
                Dock = DockStyle.Fill,
            };

            var data = _studentStore.GetStudentSpecialitiesData();

            var values = new ChartValues<int>(data.Item2);

            histogram.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Специальности",
                Labels = data.Item1
            });

            histogram.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Студенты"
            });

            histogram.Series.Add(new LiveCharts.Wpf.ColumnSeries
            {
                Title = "Студенты",
                Values = values
            });

            GraphicPanel.Controls.Clear();
            GraphicPanel.Controls.Add(histogram);
        }

        private void UpdateGraph_Click(object sender, EventArgs e)
        {
            MakeStudentHistogram();
        }
    }
}
