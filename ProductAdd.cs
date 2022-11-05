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
    public partial class ProductAdd : Form
    {
        private string filename = "";
        private ProductList productList;
        private DB database;
        private List<Product> products = new List<Product>();
        public ProductAdd(ProductList _productList, DB _database, List<Product> _products)
        {

            InitializeComponent();
            productList = _productList;
            database = _database;
            products = _products;
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лопушокDataSet.ProductType". При необходимости она может быть перемещена или удалена.
            this.productTypeTableAdapter.Fill(this.лопушокDataSet.ProductType);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.picture;
            filename = "";
        }

        private void buttonChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png" +
                                    "|Все файлы (*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = new Bitmap($@"{openFileDialog.FileName}");
                    filename = openFileDialog.FileName;
                }
                catch(System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден или поврежден");
                    pictureBox.Image = Properties.Resources.picture;
                    filename = "";
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Label[] label = Controls.OfType<Label>().ToArray();
            TextBox[] textBoxes = {textBoxName, textBoxArticleNum, textBoxMinCost};
            foreach(TextBox textBox in textBoxes)
            {
                if (textBox.Text == "")
                    label.Where(l => l.Tag == textBox.Tag).First().Text = "Пустое поле";
                else
                    label.Where(l => l.Tag == textBox.Tag).First().Text = "";
            }
            if (textBoxMinCost.Text != "")
            {
                char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                foreach(char i in textBoxMinCost.Text)
                {
                    if (!chars.Contains(i))
                    {
                        label8.Text = "Только целые числа;\nБез пробелов";
                        break;
                    }
                    else
                    {
                        label8.Text = "";
                    }
                }
            }
            if (textBoxArticleNum.Text.Length > 6)
            {
                label7.Text = label7.Text + "\nНе более 6 символов";
            }
            else
                label7.Text = label7.Text.Replace("\nНе более 6 символов", "");
            buttonSave.Enabled = check();
        }

        private bool check()
        {
            Label[] labes = { label6, label7, label8 };
            foreach (Label lab in labes)
                if (lab.Text != "")
                    return false;
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(products.Where(p => p.article.ToString() == textBoxArticleNum.Text).Count() != 0)
                {
                    MessageBox.Show("Продукт с таким артикулом уже есть.");
                    return;
                }
                database.request($@"INSERT INTO [Product] VALUES('{textBoxName.Text}', {Convert.ToInt32(comboBoxTypeProd.SelectedValue)}, '{textBoxArticleNum.Text}',
                '{textBoxDescription.Text}', '{filename}', NULL, NULL, {Convert.ToInt32(textBoxMinCost.Text)})");
                MessageBox.Show("Продукт внесен в базу.");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message);
            }
        }
    }
}
