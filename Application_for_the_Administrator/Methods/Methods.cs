using Application_for_the_Administrator.Models;
using Application_for_the_Administrator.ModelViews;
using Application_for_the_Administrator.Views;
using Microsoft.Win32;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;

namespace Application_for_the_Administrator.Methods
{
    class Methods
    {
        #region Для Main_Catalog_WindowAdmin
        public static void OpenProduct_Card_Add_WindowAdmin()
        {
            Product_Card_Add_WindowAdmin window = new Product_Card_Add_WindowAdmin();
            window.Show();
            Window window1 = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Close();
            }
        }
        public static void OpenProduct_Card_Edit_WindowAdmin(ProductModel selectedProduct)
        {
            Product_Card_Edit_WindowAdmin window = new Product_Card_Edit_WindowAdmin();
            window.Show();
            window.DataContext = new Product_Card_Edit_ViewModel(selectedProduct);
            Window window1 = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Close();
            }
        }
        public static void OutInMainWindowAuthAdmin()
        {
            MainWindowAuthAdmin window = new MainWindowAuthAdmin();
            window.Show();
            Window window1 = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Close();
            }
        }
        #endregion
        public static void OpenMain_Catalog_WindowAdminn()
        {
            Main_Catalog_WindowAdmin window = new Main_Catalog_WindowAdmin();
            window.Show();
            Window window1 = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Close();
            }
        }
        #region Запросы к API(ADMIN)
        public const string BaseUrl = "https://localhost:7227";
        public static string LoggedAdminName { get; private set; }
        public static bool LogAdmin( string pass, string email)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/AuthAdmin/Login", Method.Post);
            Admin admin = new Admin()
            {
                Email = email,
                Password = pass,
            };
            request.AddJsonBody(admin);
            var responce = client.Execute(request);
            if (responce.StatusCode == System.Net.HttpStatusCode.OK)
            {
                LoggedAdminName = responce.Content;
                OpenMain_Catalog_WindowAdminn();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Check(bool isValid, MainWindowAuthAdmin_ViewModel viewModel)
        {
            if (!isValid)
                viewModel.ErrorMessageVisibility = Visibility.Visible;
            else
                viewModel.ErrorMessageVisibility = Visibility.Collapsed;
        }
        #endregion
        #region Для работы с продуктами
        public static void Delete(int selectID)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest($"Product/DeleteProduct/{selectID}", Method.Delete);
            var response = client.Execute(request);
        }
        public static string AddProduct(string Name, decimal Price, string Description, decimal Size, byte[] Photo)
        {
            var client = new RestClient(BaseUrl);
            Random rnd = new Random();
            var request = new RestRequest("Product/AddProduct", Method.Post);
            ProductModel card = new ProductModel()
            {
                Productname = Name,
                Productprice = Price,
                Productdescription = Description,
                Productsize = Size,
                Id = rnd.Next(1000),
                ProductImage = Photo
            };
            request.AddJsonBody(card);
            var response = client.Execute(request);
            MessageBox.Show(response.Content);
            string content = response.Content;
            return content;
        }
        public static string EditProduct(string Name, decimal Price, string Description, decimal Size, byte[] Photo, int selectID)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest($"Product/UpdateProduct/{selectID}", Method.Put);
            ProductModel updateProduct = new ProductModel()
            {
                Productname = Name,
                Productprice = Price,
                Productdescription = Description,
                Productsize = Size,
                ProductImage = Photo,
                Id = selectID
            };
            request.AddJsonBody(updateProduct);
            var response = client.Execute(request);
            MessageBox.Show(response.Content);
            return response.Content;
        }
        public static List<ProductModel> GetProducts()
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest($"/Product/GetProduct", Method.Get);
            var responce = client.Execute(request);
            var result = new List<ProductModel>();
            try
            {
                result = JsonConvert.DeserializeObject<List<ProductModel>>(responce.Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            return result;
        }
        public static ObservableCollection<ProductModel> LoadData(ObservableCollection<ProductModel> collection)
        {
            List<ProductModel> productData = GetProducts();
            return new ObservableCollection<ProductModel>(productData);
        }
        public static byte[] SelectImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                byte[] fileBytes = File.ReadAllBytes(openFileDialog.FileName);
                return fileBytes;
            }

            return null;
        }
        #endregion
    }
}
