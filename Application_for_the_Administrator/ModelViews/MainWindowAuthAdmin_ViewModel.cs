using Application_for_the_Administrator.Views;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Converters;

namespace Application_for_the_Administrator.ModelViews
{
    class MainWindowAuthAdmin_ViewModel : ViewModelBase
    {
        public string EmailAdmin { get; set; }
        public string PasswordAdmin { get; set; }
        public ICommand AuthCommand { get; set; }
        public Visibility ErrorMessageVisibility { get; set; }
        public MainWindowAuthAdmin_ViewModel()
        {
            ErrorMessageVisibility = Visibility.Collapsed;
            AuthCommand = new DelegateCommand(() =>
            {
                Auth();
                if (CommonLibrarySTI.Methods.LogAdmin(PasswordAdmin, EmailAdmin))
                {
                    CommonLibrarySTI.WindowManager.OpenWindow<Main_Catalog_WindowAdmin>(new Main_Catalog_Admin_ViewModel());
                }
            });
        }
        private void Auth()
        {
            bool isValid = CommonLibrarySTI.Methods.LogAdmin(PasswordAdmin, EmailAdmin);
            Methods.Methods.Check(isValid, this);
            RaisePropertyChanged(nameof(ErrorMessageVisibility)); 
        }
    }
}
