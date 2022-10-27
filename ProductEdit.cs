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
        private List<Product> products;
        private Product product;
        private DB database;
        public ProductEdit(Product _product, int _ID, DB _database, List<Product> _products)
        {
            ID = _ID;
            product = _product;
            database = _database;
            products = _products;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            textBoxArticleNumber.Text = textBoxArticleNumber.Text.Replace(" ", "");
            textBoxCost.Text = textBoxCost.Text.Replace(" ", "");
            if (products.Where(p => p.article.ToString() == textBoxArticleNumber.Text).ToList().Count >= 1)
            {
                MessageBox.Show("Продукт с таким артикулом уже есть");
                return;
            }
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
            textBoxCost.Text = product.cost.ToString().Replace(",00", "");
            buttonSave.Enabled = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var text = (TextBox)sender;
            buttonSave.Enabled = check();
        }

        private bool check()
        {
            if (textBoxArticleNumber.Text == "")
                label5.Visible = true;
            else
                label5.Visible = false;
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (char i in textBoxCost.Text)
            {
                if (!chars.Contains(i))
                {
                    label6.Text = "Только числа";
                    label6.Visible = true;
                }
                else
                    label6.Visible = false;
            }
            if (label6.Visible == true || label5.Visible == true)
                return false;
            else
                return true;
        }
    }
}
