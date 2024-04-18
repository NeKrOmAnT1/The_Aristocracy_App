using Application_for_the_Client.Models;
using Application_for_the_Client.Views;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Application_for_the_Client.Methods
{
    internal class Methods
    {
        public static void OpenProduct_Card()
        {
            ProductCard_Window window = new ProductCard_Window();
            window.Show();
            Window window1 = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Close();
            }
        } 
        public static void Open_Shopping_Cart()
        {
            ShoppingCart_Window window = new ShoppingCart_Window();
            window.Show();
            Window window1 = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Close();
            }
        }
        public static void OpenMain_Catalog_Window()
        {
            Main_Catalog_Window window = new Main_Catalog_Window();
            window.Show();
            Window window1 = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Close();
            }
        }
        public static void OutAccount()
        {
            MainWindow window = new MainWindow();
            window.Show();
            Window window1 = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Close();
            }
        }
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
                OpenMain_Catalog_Window();
            }
        }
        #region Для работы с продуктами
           
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
            #endregion
    }
}
