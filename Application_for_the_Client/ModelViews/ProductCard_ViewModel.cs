using Application_for_the_Client.Models;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommonLibrarySTI;
using Application_for_the_Client.Views;

namespace Application_for_the_Client.ModelViews
{
    class ProductCard_ViewModel : ViewModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public byte[] ProductImage { get; set; }
        public ICommand ReturnCatalogCommand { get; set; }

        public ProductCard_ViewModel(CommonLibrarySTI.Models.ProductModel selectedProduct) 
        {
            ReturnCatalogCommand = new DelegateCommand(() => CommonLibrarySTI.WindowManager.OpenWindow<Main_Catalog_Window>(new Main_Catalog_Window_ViewModel()));
            Name = selectedProduct.Productname;
            Description = selectedProduct.Productdescription;
            Price = selectedProduct.Productprice;
            ProductImage = selectedProduct.ProductImage;
            
        }
    }
}
