using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public List<Products> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Products>();
            products.Add(new Products()
            {
                ProductName = "Яблоки",
                ProductPrice = "129.90",
                ProductImage = "Data/1.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Products()
            {
                ProductName = "Клубника",
                ProductPrice = "35.90",
                ProductImage = "Data/2.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Products()
            {
                ProductName = "Апельсины",
                ProductPrice = "96.90",
                ProductImage = "Data/3.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Products()
            {
                ProductName = "Стиральная машина",
                ProductPrice = "2540.90",
                ProductImage = "Data/4.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Products()
            {
                ProductName = "Пылесос",
                ProductPrice = "1375.90",
                ProductImage = "Data/5.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Products()
            {
                ProductName = "Утюг",
                ProductPrice = "960.90",
                ProductImage = "Data/6.png",
                ProductCategory = ProductCategories.Appliances
            });
            lstBox.ItemsSource = products;
        }

    }
}
