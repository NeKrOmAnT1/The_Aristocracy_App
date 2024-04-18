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
    class ShoppingCart_ViewModel : ViewModelBase
    {
        public ObservableCollection<ProductModel> Tovar { get; set; }
        public ProductModel SelectedItem { get; set; }
        public int money { get; set; }
        public ICommand ReturnCatalogCommand { get; set; }
        public ICommand OpenProductCardCommand { get; set; }
        public ShoppingCart_ViewModel()
        {
            OpenProductCardCommand = new DelegateCommand(() => Methods.Methods.OpenProduct_Card());
            ReturnCatalogCommand = new DelegateCommand(() => Methods.Methods.OpenMain_Catalog_Window());
            money = 3213;
            Tovar = new ObservableCollection<ProductModel>();
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 }); Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 }); Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 }); Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });

        }
    }
}
