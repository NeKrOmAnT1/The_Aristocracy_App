﻿using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Application_for_the_Client.ModelViews
{
    internal class MainWindow_ViewModel : ViewModelBase
    {
        public string regEmail {  get; set; }
        public string regPass {  get; set; }
        public string authEmail { get; set; }
        public string authPass { get; set; }
        public ICommand RegUserCommand { get; set; }
        public ICommand AuthUserCommand { get; set; }
       public MainWindow_ViewModel()
        {
            RegUserCommand = new DelegateCommand(()=> Methods.Methods.RegUser(regEmail, regPass));
            AuthUserCommand = new DelegateCommand(()=> Methods.Methods.LogUser(authEmail, authPass));
        }
    }
}
