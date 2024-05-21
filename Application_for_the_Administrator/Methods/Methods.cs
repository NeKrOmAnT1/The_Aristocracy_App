using Application_for_the_Administrator.Models;
using Application_for_the_Administrator.ModelViews;
using Application_for_the_Administrator.Views;
using Microsoft.Win32;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;

namespace Application_for_the_Administrator.Methods
{
    class Methods
    {
        public static void Check(bool isValid, MainWindowAuthAdmin_ViewModel viewModel)
        {
            if (!isValid)
                viewModel.ErrorMessageVisibility = Visibility.Visible;
            else
                viewModel.ErrorMessageVisibility = Visibility.Collapsed;
        }
    }
}
