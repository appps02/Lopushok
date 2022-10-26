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
    public partial class ProductEdit : Form
    {
        private int ID;
        private Product product;
        private DB database;
        public ProductEdit(Product _product, int _ID, DB _database)
        {
            ID = _ID;
            product = _product;
            database = _database;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (database.request($@"UPDATE Product SET Title = '{textBoxTitle.Text}', ArticleNumber = '{textBoxArticleNumber.Text}', Image = '{textBoxPicture.Text}', MinCostForAgent = {textBoxCost.Text.Replace(",00", "")} WHERE ID = {ID}") == 1)
            {
                MessageBox.Show("Продукт изменен");
            }
            else
                MessageBox.Show("Продукт не был изменен или было изменено больше");
            Close();
        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            textBoxTitle.Text = product.Title;
            textBoxArticleNumber.Text = product.article.ToString();
            textBoxPicture.Text = product.image;
            textBoxCost.Text = product.cost.ToString();
        }
    }
}
