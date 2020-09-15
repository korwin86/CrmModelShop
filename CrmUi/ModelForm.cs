using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class ModelForm : Form
    {

        ShopComputerModel model = new ShopComputerModel();
        public ModelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var labels = new List<Label>();

            foreach (var cashDesk in model.CashDesks)
            {
                var label = new Label();
                var numericUpDown = new NumericUpDown();

                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(13, 13);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(35, 13);
                this.label1.TabIndex = 1;
                this.label1.Text = "label1";
 
                this.numericUpDown1.Location = new System.Drawing.Point(76, 11);
                this.numericUpDown1.Name = "numericUpDown1";
                this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
                this.numericUpDown1.TabIndex = 2;
            }

        }
    }
}
