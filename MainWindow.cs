using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList(this);
            productList.Show();
            this.Hide();
        }

        private void AgentList_Click(object sender, EventArgs e)
        {

        }

        private void MaterialList_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
