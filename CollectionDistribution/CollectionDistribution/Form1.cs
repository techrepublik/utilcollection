using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionDistribution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Product.PopulateProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenderedAmount = Convert.ToDouble(textBox1.Text);
            dataGridView1.DataSource = UtilCollection.GetCollectionProducts(Product.PopulateProducts(), tenderedAmount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Product.PopulateProducts();
        }
    }
}
