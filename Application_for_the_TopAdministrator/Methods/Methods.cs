using Application_for_the_TopAdministrator.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Application_for_the_TopAdministrator.Methods
{
    class Methods
    {
        //Запрос на регистрацию 
        public const string BaseUrl = "https://localhost:7227";
        public static void RegUser(string Fio, string pass, string repeatpass, string email)
        {
            if (pass ==repeatpass)
            {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/AuthAdmin/Register", Method.Post);
            Admin Admin = new Admin()
            {
                Email = email,
                FIO = Fio,
                Password = pass
            };
            request.AddJsonBody(Admin);
            var responce = client.Execute(request);
                MessageBox.Show(responce.Content);
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}
