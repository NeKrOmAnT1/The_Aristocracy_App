using Application_for_the_Client.Models;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommonLibrarySTI;
using Application_for_the_Client.Views;

namespace Application_for_the_Client.ModelViews
{
    class ShoppingCart_ViewModel : ViewModelBase
    {
        public ObservableCollection<CommonLibrarySTI.Models.ProductModel> Tovar { get; set; }
        public CommonLibrarySTI.Models.ProductModel SelectedItem { get; set; }
        public int money { get; set; }
        public ICommand ReturnCatalogCommand { get; set; }
        public ICommand OpenProductCardCommand { get; set; }
        public ShoppingCart_ViewModel()
        {
            OpenProductCardCommand = new DelegateCommand(() => CommonLibrarySTI.WindowManager.OpenWindow<ProductCard_Window>(new ProductCard_ViewModel(SelectedItem)));
            ReturnCatalogCommand = new DelegateCommand(() => CommonLibrarySTI.WindowManager.OpenWindow<Main_Catalog_Window>(new Main_Catalog_Window_ViewModel()));
            money = 3213;

            Tovar = new ObservableCollection<CommonLibrarySTI.Models.ProductModel>();
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new CommonLibrarySTI.Models.ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
           
        }
    }
}
