using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> menu = new Dictionary<string, double>()
        {
            {"Burger", 5.99},
            {"Pizza", 7.99},
            {"Salad", 4.99},
            {"Soda", 1.99},
            {"Water", 0.99}
        };

        public Form1()
        {
        
            InitializeComponent();

            foreach (var item in menu)
            {
                checkedListBox2.Items.Add($"{item.Key} - ${item.Value}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = 0.0;
            string orderSummary = "";

            foreach (var checkedItem in checkedListBox2.CheckedItems)
            {
                string item = checkedItem.ToString().Split('-')[0].Trim();
                total += menu[item];
                orderSummary += $"• {item}\n";
            }

            string address = textBox2.Text;

            if (orderSummary == "")
            {
                MessageBox.Show("❗ Please select at least one item.");
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("❗ Please enter your delivery address.");
                return;
            }

            MessageBox.Show(
                $"✅ Your order:\n{orderSummary}\n💵 Total: ${total:F2}\n📦 Deliver to: {address}",
                "Order Summary"
            );
        }

    }
}
