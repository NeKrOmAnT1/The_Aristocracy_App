using Application_for_the_Administrator.Methods;
using Application_for_the_Administrator.Models;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommonLibrarySTI;
using Application_for_the_Administrator.Views;

namespace Application_for_the_Administrator.ModelViews
{
    internal class Main_Catalog_Admin_ViewModel : ViewModelBase
    {
        public ObservableCollection<CommonLibrarySTI.Models.ProductModel> Tovar { get; set; }
        public CommonLibrarySTI.Models.ProductModel SelectedItem { get; set; }
        public string AdminName { get { return Methods.Methods.LoggedAdminName.Trim().Replace("\"", ""); } }
        public byte[] ProductImage { get; set; }
        public ICommand OpenAddWindowCommand { get; set; }
        public ICommand OpenEditWindowCommand { get; set; }
        public ICommand OutAuthWindowCommand { get; set; }
        public ICommand DeleteCommand { get; set; }


        public Main_Catalog_Admin_ViewModel()
        {
            DeleteCommand = new DelegateCommand(() => Methods.Methods.Delete(SelectedItem.Id));

            OpenEditWindowCommand = new DelegateCommand(()=>CommonLibrarySTI.WindowManager.OpenWindow<Product_Card_Edit_WindowAdmin>(SelectedItem));
            OpenAddWindowCommand = new DelegateCommand(()=> CommonLibrarySTI.WindowManager.OpenWindow<Product_Card_Add_WindowAdmin>());
            OutAuthWindowCommand = new DelegateCommand(() => CommonLibrarySTI.WindowManager.OpenWindow<MainWindowAuthAdmin>());
            Tovar = CommonLibrarySTI.Methods.LoadData(Tovar);
        }
    }
}
