using Application_for_the_Client.Models;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_for_the_Client.ModelViews
{
    internal class Main_Catalog_Window_ViewModel : ViewModelBase
    { 
        public ObservableCollection<ProductModel> Tovar { get; set; }
        public ProductModel SelectedItem { get; set; }
        public Main_Catalog_Window_ViewModel()
        {
            Tovar = new ObservableCollection<ProductModel>();
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });     Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
            Tovar.Add(new ProductModel { Id = 3, Productname = "Товар 3", Productprice = 300 });
            Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });Tovar.Add(new ProductModel { Id = 1, Productname = "Товар 1", Productprice = 100 });
            Tovar.Add(new ProductModel { Id = 2, Productname = "Товар 2", Productprice = 200 });
          
        }
    }
}
