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

namespace Application_for_the_Administrator.ModelViews
{
    internal class Main_Catalog_Admin_ViewModel : ViewModelBase
    {
        public ObservableCollection<ProductModel> Tovar { get; set; }
        public ProductModel SelectedItem { get; set; }
        public string AdminName { get; set; }
        public byte[] ProductImage { get; set; }
        public ICommand OpenAddWindowCommand { get; set; }
        public ICommand OpenEditWindowCommand { get; set; }
        public ICommand OutAuthWindowCommand { get; set; }
        public ICommand DeleteCommand { get; set; }


        public Main_Catalog_Admin_ViewModel()
        {
            DeleteCommand = new DelegateCommand(() => Methods.Methods.Delete(SelectedItem.Id));

            OpenEditWindowCommand = new DelegateCommand(()=>Methods.Methods.OpenProduct_Card_Edit_WindowAdmin(SelectedItem));
            OpenAddWindowCommand = new DelegateCommand(()=> Methods.Methods.OpenProduct_Card_Add_WindowAdmin());
            OutAuthWindowCommand = new DelegateCommand(() => Methods.Methods.OutInMainWindowAuthAdmin());
            AdminName = "Мифтахов Роман";
            Tovar = Methods.Methods.LoadData(Tovar);
        }
    }
}
