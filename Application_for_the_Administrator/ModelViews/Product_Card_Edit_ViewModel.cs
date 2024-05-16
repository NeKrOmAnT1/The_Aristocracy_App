using Application_for_the_Administrator.Models;
using Application_for_the_Administrator.Views;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommonLibrarySTI;

namespace Application_for_the_Administrator.ModelViews
{
    internal class Product_Card_Edit_ViewModel : ViewModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ProductImage { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public ICommand ReturnCatalogCommand { get; set; }
        public ICommand SelectImageCommand { get; set; }
        public ICommand EditProductCommand { get; set; }

        public Product_Card_Edit_ViewModel(CommonLibrarySTI.Models.ProductModel selectedProduct) 
        {
            ReturnCatalogCommand = new DelegateCommand(() => CommonLibrarySTI.WindowManager.OpenWindow<Main_Catalog_WindowAdmin>());
            SelectImageCommand = new DelegateCommand(SelectImage);
            EditProductCommand = new DelegateCommand(() => CommonLibrarySTI.Methods.EditProduct(Name, Price, Description, Size, ProductImage, selectedProduct.Id));
            Name = selectedProduct.Productname;
            Description = selectedProduct.Productdescription;
            Price = selectedProduct.Productprice;
            ProductImage = selectedProduct.ProductImage;
        }
        private void SelectImage()
        {
            ProductImage = CommonLibrarySTI.Methods.SelectImage();
        }
    }
}
