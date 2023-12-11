using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_for_the_Client.ModelViews
{
    class ProductCard_ViewModel : ViewModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Size { get; set; }

        public ProductCard_ViewModel() 
        {
            Name = "Кроссовки";
            Description = "Кроссовки высокий профиль кроссовок не стесняет движений голеностопа, что не повредит никак Вашей ножке. де.Помимо этого, адежное сцепление.Их современный дизайн сочетает в себе элементы классического стиля и передовых технологий, что делает их невероятно комфортными и практичными. Стильный сетчатый рисунок завершает облик кроссовок, которые подойдут как для спорта, так и для повседневного ношения. Будут хорошо сочетаться с любой одеждой и в любую погоду. ";
            Price = 12990;
        }
    }
}
