using Microsoft.Win32;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static CommonLibrarySTI.Models;

namespace CommonLibrarySTI
{
    public class Methods
    {
        //Запрос на регистрацию 
        public const string BaseUrl = "https://localhost:7227";
        public static void RegUser(string email, string pass)
        {

            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/AuthUser/Register", Method.Post);
            User user = new User()
            {
                Email = email,
                Password = pass
            };
            request.AddJsonBody(user);
            var responce = client.Execute(request);
            MessageBox.Show(responce.Content);
        }
        public static void LogUser(string pass, string email)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/AuthUser/Login", Method.Post);
            User user = new User()
            {
                Email = email,
                Password = pass,
            };
            request.AddJsonBody(user);
            var responce = client.Execute(request);
            MessageBox.Show(responce.Content);
            if (responce.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //OpenMain_Catalog_Window();
                MessageBox.Show("Увидел");
                WindowManager.OpenWindow<Window>();
            }
        }
        #region Для работы с продуктами

       
        public static ObservableCollection<ProductModel> LoadData(ObservableCollection<ProductModel> collection)
        {
            List<ProductModel> productData = GetProducts();
            return new ObservableCollection<ProductModel>(productData);
        }
        #endregion
        public static string LoggedAdminName { get; private set; }
        public static bool LogAdmin(string pass, string email)
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
                //OpenMain_Catalog_WindowAdminn();
                return true;
            }
            else
            {
                return false;
            }
        }
        //public static void Check(bool isValid, MainWindowAuthAdmin_ViewModel viewModel)
        //{
        //    if (!isValid)
        //        viewModel.ErrorMessageVisibility = Visibility.Visible;
        //    else
        //        viewModel.ErrorMessageVisibility = Visibility.Collapsed;
        //}
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
