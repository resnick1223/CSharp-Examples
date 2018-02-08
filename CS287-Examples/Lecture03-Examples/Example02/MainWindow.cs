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
    public partial class MainWindow : Form
    {
        public List<Product> Products { get; set; }
        public Order MyOrder;

        public int SelectedProductIndex = -1;

        public MainWindow()
        {
            InitializeComponent();
            Products = new List<Product>();
            MyOrder = new Order();
            Render();
        }

        private void AddProduct1Button_Click(object sender, EventArgs e)
        {
            MyOrder.Add(Products[0]);
            Render();
        }

        private void AddProduct2Button_Click(object sender, EventArgs e)
        {
            MyOrder.Add(Products[1]);
            Render();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MyOrder.ProductList = new List<Product>();
            Render();
        }

        public void Render()
        {
            Product1Label.Text = string.Format("產品:{0}, 價格:{1}元", Products[0].Name, Products[0].Price);
            Product2Label.Text = string.Format("產品:{0}, 價格:{1}元", Products[1].Name, Products[1].Price);
            ShoppingCartRichTextBox.Text = MyOrder.ToText();
            TotalLabel.Text = string.Format("總金額: {0}元", MyOrder.GetTotalPrice());
        }

        private void Product1Label_Click(object sender, EventArgs e)
        {
            SelectedProductIndex = 0;
            Product1Label.BackColor = Color.MistyRose;
        }

        private void AddProductMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagementWindow pmWindow = new ProductManagementWindow();
            pmWindow.ShowDialog();
        }
    }
}