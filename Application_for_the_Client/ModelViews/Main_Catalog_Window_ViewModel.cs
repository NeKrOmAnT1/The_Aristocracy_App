using Application_for_the_Client.Models;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Application_for_the_Client.ModelViews
{
    internal class Main_Catalog_Window_ViewModel : ViewModelBase
    { 
        public ObservableCollection<ProductModel> Tovar { get; set; }
        public ProductModel SelectedItem { get; set; }
        public int money { get; set; }
        public ICommand OpenProductCardCommand { get; set; }
        public ICommand OpenShoppingCartCommand { get; set; }
        public ICommand OutAccountCommand { get; set; }

        public Main_Catalog_Window_ViewModel()
        {
            OutAccountCommand = new DelegateCommand(() => Methods.Methods.OutAccount());
            OpenShoppingCartCommand = new DelegateCommand(()=> Methods.Methods.Open_Shopping_Cart());
            OpenProductCardCommand = new DelegateCommand(()=> Methods.Methods.OpenProduct_Card());
            money = 3213;
            Tovar = Methods.Methods.LoadData(Tovar);
          
        }
    }
}
