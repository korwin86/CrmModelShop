using CrmBl.Model;
using System;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }
        public SellerForm()
        {
            InitializeComponent();
        }
        public SellerForm(Seller seller) : this()
        {
            Seller = seller ?? new Seller();
            textBox1.Text = seller.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seller = Seller ?? new Seller();
            Seller.Name = textBox1.Text;
            Close();
        }
    }
}
