using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2_1Lab_Net.Framework_.WinForms.Services.NavigationService;
using System.Windows.Forms;

namespace _2_1Lab_Net.Framework_.WinForms.Services
{
    public interface INavigationService
    {
        UserControl CurrentView { get; }

        event NavigatedHandler Navigated;
        void NavigateTo<ViewType>() where ViewType : UserControl;
    }
    public class NavigationService : INavigationService
    {
        public NavigationService(Func<Type, UserControl> viewFactory)
        {
            _viewFactory = viewFactory;
        }
        private readonly Func<Type, UserControl> _viewFactory;

        public UserControl CurrentView { get; set; }

        public delegate void NavigatedHandler(object sender, EventArgs e);
        public event NavigatedHandler Navigated;

        public void NavigateTo<ViewType>() where ViewType : UserControl
        {
            CurrentView = _viewFactory.Invoke(typeof(ViewType));
            Navigated?.Invoke(this, new EventArgs());
        }
    }
}
