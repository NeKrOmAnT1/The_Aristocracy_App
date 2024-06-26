﻿using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using CommonLibrarySTI;
using Application_for_the_Administrator.Views;

namespace Application_for_the_Administrator.ModelViews
{
    class Product_Card_Add_ViewModel : ViewModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Size { get; set; }
        public byte[] ProductImage { get; set; }
        public ICommand ReturnCatalogCommand { get; set; }
        public ICommand AddTovarCommand { get; set; }
        public ICommand SelectImageCommand { get; set; }

       public Product_Card_Add_ViewModel()
        {
            SelectImageCommand = new DelegateCommand(SelectImage);
            ReturnCatalogCommand = new DelegateCommand(() => CommonLibrarySTI.WindowManager.OpenWindow<Main_Catalog_WindowAdmin>(new Main_Catalog_Admin_ViewModel()));
            AddTovarCommand = new DelegateCommand(() => CommonLibrarySTI.Methods.AddProduct(Name, Price, Description, Size, ProductImage));
        }
        private void SelectImage()
        {
            ProductImage = CommonLibrarySTI.Methods.SelectImage();
        }
    }
}
