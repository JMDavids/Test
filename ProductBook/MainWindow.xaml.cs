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
using System.Xml.Linq;

namespace ProductBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List <Product> ProductList = new List <Product>();
        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            Product product  = new Product();
            product.productTitle = txtproductTitle.Text;
            product.productPrice = double.Parse(txtproductPrice.Text);
            product.productPublisher = txtproductPublisher.Text;
            lblProductPriceWithVAT.Content = product.CalculatePrice();

            ProductList.Add(product);

            dvgDisplayProduct
        }
    }
}
