using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using PyShellLibrary;

namespace Example02
{
    public partial class Form1 : Form
    {
        private string currency;
        private string cashOrSight;
        private string buyOrSell;
        private JObject rates;

        public Form1()
        {
            InitializeComponent();
        }

        private void currencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency = currencyComboBox.SelectedItem.ToString();
        }

        private void cashOrSightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashOrSight = cashOrSightComboBox.SelectedIndex == 0 ? "cash" : "sight";
        }

        private void buyOrSellComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buyOrSell = buyOrSellComboBox.SelectedIndex == 0 ? "buy" : "sell";
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currency) || string.IsNullOrEmpty(cashOrSight) || string.IsNullOrEmpty(buyOrSell))
            {
                MessageBox.Show("有項目未選擇，請先選好");
            }
            else
            {
                if (rates == null)
                {
                    FetchData(this, null);
                }

                MessageBox.Show(rates[currency][cashOrSight][buyOrSell].ToString());
            }
        }

        private void FetchData(object sender, EventArgs e)
        {
            string pyFilePath = @"C:\Users\resnick\crawler-for-csharp\crawler.py";
            string jsonString = PyShell.Exec(pyFilePath);
            rates = JObject.Parse(jsonString);
        }
    }
}