using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreLibrary;

namespace Example03
{
    public partial class Form1 : Form
    {
        private Order order;
        private Customer customer;

        public Form1()
        {
            InitializeComponent();
            this.customer = new Customer();
            this.customer.Name = "張元鴻";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderScreen();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.order = new Order();

            this.order.Customer = this.customer;
            RenderScreen();
        }

        private void product1Button_Click(object sender, EventArgs e)
        {
            this.order.ProductList.Add(new Product() { Name = "豆漿", Price = 15 });
            RenderScreen();
        }

        private void product2Button_Click(object sender, EventArgs e)
        {
            this.order.ProductList.Add(new Product() { Name = "油條", Price = 15 });
            RenderScreen();
        }

        private void RenderScreen()
        {
            this.customerLabel.Text = this.customer.Name;
            this.orderButton.Text = "點餐";
            this.product1Button.Text = "豆漿";
            this.product2Button.Text = "油條";
            this.accoutButton.Text = "結帳";

            product1Button.Enabled = this.order != null;
            product2Button.Enabled = this.order != null;
            orderButton.Enabled = this.order == null;
            this.orderRichTextBox.Text = this.order != null ? this.order.GetDetail() : string.Empty;
        }

        private void accoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0}, 結帳金額:{1}，謝謝惠顧", this.order.Customer.Name, this.order.GetTotal()));

            this.order = null;
            RenderScreen();
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = tableComboBox.SelectedIndex;
            this.customer.Name = tableComboBox.Items[SelectedIndex].ToString() + "桌";
            RenderScreen();
        }
    }
}