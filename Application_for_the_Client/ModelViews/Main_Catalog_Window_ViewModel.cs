﻿using Application_for_the_Client.Models;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Application_for_the_Client.Views;
using CommonLibrarySTI;

namespace Application_for_the_Client.ModelViews
{
    internal class Main_Catalog_Window_ViewModel : ViewModelBase
    { 
        public ObservableCollection<CommonLibrarySTI.Models.ProductModel> Tovar { get; set; }
        public CommonLibrarySTI.Models.ProductModel SelectedItem { get; set; }
        public byte[] ProductImage { get; set; }
        public int money { get; set; }
        public ICommand OpenProductCardCommand { get; set; }
        public ICommand OpenShoppingCartCommand { get; set; }
        public ICommand OutAccountCommand { get; set; }

        public Main_Catalog_Window_ViewModel()
        {
            OutAccountCommand = new DelegateCommand(() => CommonLibrarySTI.WindowManager.OpenWindow<MainWindow>(new MainWindow_ViewModel()));
            OpenShoppingCartCommand = new DelegateCommand(()=> CommonLibrarySTI.WindowManager.OpenWindow<ShoppingCart_Window>(new ShoppingCart_ViewModel()));
            OpenProductCardCommand = new DelegateCommand(()=> CommonLibrarySTI.WindowManager.OpenWindow<ProductCard_Window>(new ProductCard_ViewModel(SelectedItem)));
            money = 3213;
            Tovar = CommonLibrarySTI.Methods.LoadData(Tovar);
        }

    }
}
