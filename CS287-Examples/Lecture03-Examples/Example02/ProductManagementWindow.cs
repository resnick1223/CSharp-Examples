using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppleStoreLibrary;

namespace Example02
{
    public partial class ProductManagementWindow : Form
    {
        public MainWindow ParentWindow { get; set; }

        public ProductManagementWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = int.Parse(IdTextBox.Text),
                Name = ProductNameTextBox.Text,
                Category = ProductCategoryComboBox.Items[ProductCategoryComboBox.SelectedIndex].ToString(),
                Price = int.Parse(ProductPriceTextBox.Text),
                SoldOut = ProductStatusComboBox.Items[ProductStatusComboBox.SelectedIndex].ToString() != "可訂購"
            };
            ParentWindow.Products.Add(product);
            ParentWindow.Render();
            MessageBox.Show(product.Price.ToString());
        }
    }
}