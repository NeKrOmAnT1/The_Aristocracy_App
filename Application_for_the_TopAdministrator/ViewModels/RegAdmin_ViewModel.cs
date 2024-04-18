using Application_for_the_TopAdministrator.Models;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Application_for_the_TopAdministrator.ViewModels
{
    class RegAdmin_ViewModel : ViewModelBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FIO { get; set; }
        public ICommand RegAdminCommand { get; set; }
        public string RepeatPassword {  get; set; }

        public RegAdmin_ViewModel()
        {
            RegAdminCommand = new DelegateCommand(() => Methods.Methods.RegUser(FIO, Password, RepeatPassword, Email));
        }
    }
}
