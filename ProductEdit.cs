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
        private string filename = "";
        private List<Product> products;
        private Product product;
        private DB database;
        private PictureBox PictureBox;
        public ProductEdit(Product _product, DB _database, List<Product> _products, PictureBox _pictureBox)
        {
            product = _product;
            database = _database;
            products = _products;
            PictureBox = _pictureBox;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (products.Where(p => p.article.ToString() == textBoxArticleNum.Text && p.id != product.id) .Count() > 0)
                {
                    MessageBox.Show("Продукт с таким артикулом уже есть.");
                    return;
                }
                database.request($@"UPDATE [Product] SET Title = '{textBoxName.Text}', ProductTypeID = {Convert.ToInt32(comboBoxTypeProd.SelectedValue)}, ArticleNumber = '{textBoxArticleNum.Text}', 
                [Product].[Description] = '{textBoxDescription.Text}', Image = '{filename}', MinCostForAgent = {Convert.ToInt32(textBoxMinCost.Text)} WHERE ID = {product.id}");
                MessageBox.Show("Продукт внесен в базу.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message);
            }
        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лопушокDataSet.ProductType". При необходимости она может быть перемещена или удалена.
            this.productTypeTableAdapter.Fill(this.лопушокDataSet.ProductType);
            DataRow row = DB.Data_Table($"SELECT [Product].[Description] FROM [Product] WHERE [Product].[ID] = {product.id}").Rows[0];
            textBoxDescription.Text = row[0].ToString();
            textBoxName.Text = product.Title;
            textBoxArticleNum.Text = product.article.ToString();
            textBoxMinCost.Text = product.cost.ToString().Replace(",00", "");
            pictureBox.Image = PictureBox.Image;
            comboBoxTypeProd.Text = product.type;
            filename = product.image;
            buttonSave.Enabled = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Label[] label = Controls.OfType<Label>().ToArray();
            TextBox[] textBoxes = { textBoxName, textBoxArticleNum, textBoxMinCost };
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == "")
                    label.Where(l => l.Tag == textBox.Tag).First().Text = "Пустое поле";
                else
                    label.Where(l => l.Tag == textBox.Tag).First().Text = "";
            }
            if (textBoxMinCost.Text != "")
            {
                char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                foreach (char i in textBoxMinCost.Text)
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

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Вы хотите удалить данный продукт?", "Удаление продукта", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                database.request($"DELETE FROM [Product] WHERE ID = {product.id}");
                MessageBox.Show("Продукт удален");
                Close();
            }
            else
                return;
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
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден или поврежден");
                    pictureBox.Image = Properties.Resources.picture;
                    filename = "";
                }
                finally
                {
                    buttonSave.Enabled = true;
                }
            }
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.picture;
            filename = "";
            buttonSave.Enabled = true;
        }
    }
}
