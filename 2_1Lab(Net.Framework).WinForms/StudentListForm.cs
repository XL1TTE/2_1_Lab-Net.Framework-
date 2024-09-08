using _2_1Lab_Net.Framework_.WinForms.Controls;
using _2_1Lab_Net.Framework_.WinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1Lab_Net.Framework_.WinForms
{
    public partial class StudentListForm : Form
    {
        private readonly INavigationService _navigationService;
        public StudentListForm(INavigationService navigationService)
        {
            _navigationService = navigationService;

            InitializeComponent();

            _navigationService.Navigated += UpdateView;

            _navigationService.NavigateTo<StudentGraphicsView>();
        }

        private void UpdateView(object sender, EventArgs e)
        {
            ViewChangePanel.Controls.Clear();

            var view = _navigationService.CurrentView;

            ViewChangePanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;

        }
    }
}
