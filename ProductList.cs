using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Lopushok
{
    public partial class ProductList : Form
    {
        bool search, filtr, sort;
        private MainWindow mainWindow;
        string column;
        string order;
        int currentPage = 1;
        int maxPage = 0;

        public DB database = new DB();
        public List<Product> products = new List<Product>();
        public ProductList(MainWindow _mainWindow)
        {
            InitializeComponent();
            products = Product.table_class(database.Products());
            mainWindow = _mainWindow;
            update();

        }

        private void backtostart()
        {
            currentPage = 1;
            curpage.Text = currentPage.ToString();
        }

        private void nothing()
        {
            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(520, 100);
            panel.BorderStyle = BorderStyle.FixedSingle;
            Label label = new Label();
            label.Text = "Нет результатов";
            label.Location = new Point(193, 39);
            label.AutoSize = true;
            flowLayoutPanel1.Controls.Add(panel);
            panel.Controls.Add(label);
        }

        private void update()
        {
            flowLayoutPanel1.Controls.Clear();
            maxPage = Convert.ToInt32(Math.Ceiling(products.Count * 1.0 / 4));
            maximumpage.Text = Convert.ToString(maxPage);

            var listProducts = products.Skip((currentPage - 1) * 4).Take(4).ToList();
            if (listProducts.Count > 0)
            {
                foreach (Product p in listProducts)
                {
                    Panel panel = new Panel();
                    panel.BackColor = Color.White;
                    panel.Size = new Size(520, 100);
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(83, 68);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Location = new Point(3, 10);
                    if (p.image == "")
                    {
                        pictureBox.Image = Properties.Resources.picture;
                    }
                    else
                    {
                        pictureBox.Image = new Bitmap($@"{Application.StartupPath + p.image}");
                    }

                    Label label1 = new Label();
                    label1.Text = p.type;
                    label1.Location = new Point(107, 12);
                    label1.AutoSize = true;

                    Label label2 = new Label();
                    label2.Text = "|";
                    label2.Location = new Point(185, 12);
                    label2.AutoSize = true;

                    Button btn = new Button();
                    btn.Text = "Редактировать";
                    btn.Tag = p.article;
                    btn.Location = new Point(185, 33);
                    btn.BackColor = Color.Gainsboro;
                    btn.AutoSize = true;
                    btn.Click += new EventHandler(btn_Click);

                    Label label3 = new Label();
                    label3.Text = p.Title;
                    label3.Location = new Point(207, 11);
                    label3.AutoSize = true;

                    Label label4 = new Label();
                    label4.Text = p.article.ToString();
                    label4.Location = new Point(107, 33);
                    label4.AutoSize = true;

                    Label label5 = new Label();
                    label5.Text = p.cost.ToString();
                    label5.Location = new Point(435, 13);
                    label5.AutoSize = true;

                    Label label6 = new Label();
                    label6.Text = "Материалы:";
                    label6.Location = new Point(107, 54);
                    label6.AutoSize = true;

                    Label label7 = new Label();
                    label7.Text = p.Materials;
                    label7.Location = new Point(172, 54);
                    label7.Size = new Size(263, 40);

                    panel.Controls.Add(label1);
                    panel.Controls.Add(label2);
                    panel.Controls.Add(label3);
                    panel.Controls.Add(label4);
                    panel.Controls.Add(label5);
                    panel.Controls.Add(label6);
                    panel.Controls.Add(label7);
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(btn);
                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
            else
            {
                nothing();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                var btn = (Button)sender;
                DataRow row = DB.Data_Table($@"SELECT ID FROM Product WHERE ArticleNumber = '{btn.Tag.ToString()}'").Rows[0];
                int ID = Convert.ToInt32(row["ID"]);
                Product product = products.Where(p => p.article == Convert.ToInt32(btn.Tag)).First();
                ProductEdit productEdit = new ProductEdit(product, ID, database, products);
                productEdit.ShowDialog();
                products = Product.table_class(database.Products());
                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Left_Click(object sender, EventArgs e)
        {
            if (currentPage - 1 < 1)
                return;
            currentPage--;
            curpage.Text = currentPage.ToString();
            update();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 > maxPage)
                return;
            currentPage++;
            curpage.Text = currentPage.ToString();
            update();
        }

        private void AdoIA_Click(object sender, EventArgs e)
        {
            sort = true;
            if (AdoIA.Items[0].Selected)
            {
                order = "ASC";
                Query(search, filtr, sort);
            }
            if (AdoIA.Items[1].Selected)
            {
                order = "DESC";
                Query(search, filtr, sort);
            }
        }

        private void UpDown_Click(object sender, EventArgs e)
        {
            sort = true;
            if (UpDown.Items[0].Selected)
            {
                order = "ASC";
                Query(search, filtr, sort);
            }
            if (UpDown.Items[1].Selected)
            {
                order = "DESC";
                Query(search, filtr, sort);
            }
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchtextBox.Text == "")
            {
                search = false;
                Query(search, filtr, sort);
                return;
            }
            if (SearchtextBox.Text == "Поиск")
            {
                search = false;
                Query(search, filtr, sort);
                return;
            }
            search = true;
            Query(search, filtr, sort);
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortComboBox.Text == SortComboBox.Items[0].ToString())
            {
                sort = false;
                Query(search, filtr, sort);
                return;
            }
            if (SortComboBox.Text == SortComboBox.Items[1].ToString())
            {
                column = "[Product].[Title]";
                AdoIA.Show(MousePosition);
                return;
            }
            switch (SortComboBox.Text)
            {
                case "По цене":
                    column = "[Product].[MinCostForAgent]";
                    break;
                case "По артикулу":
                    column = "[Product].[ArticleNumber]";
                    break;
                default:
                    break;
            }
            UpDown.Show(MousePosition);
        }

        private void FiltComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (FiltComboBox.Text == "Все типы")
            {
                Query(search, false, sort);
                return;
            }
            filtr = true;
            Query(search, filtr, sort);
        }

        private void ProductList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DB.Connection.State == ConnectionState.Open)
                DB.Connection.Close();
            mainWindow.Show();
        }

        private void Query(bool search, bool filtr, bool sort)
        {
            backtostart();
            if (search == true && filtr == false && sort == false)
            {
                products.Clear();
                products = Product.table_class(database.Products_Search(SearchtextBox.Text));
                update();
            }

            if (search == false && filtr == true && sort == false)
            {
                products.Clear();
                products = Product.table_class(database.Products_Type(FiltComboBox.Text));
                update();
            }

            if (search == false && filtr == false && sort == true)
            {
                products.Clear();
                products = Product.table_class(database.Products_Order(column, order));
                update();
            }

            if (search == true && filtr == true && sort == false)
            {
                products.Clear();
                products = Product.table_class(database.Products_Search_Type(SearchtextBox.Text, FiltComboBox.Text));
                update();
            }

            if (search == true && filtr == false && sort == true)
            {
                products.Clear();
                products = Product.table_class(database.Products_Order_Search(column, order, SearchtextBox.Text));
                update();
            }

            if (search == false && filtr == true && sort == true)
            {
                products.Clear();
                products = Product.table_class(database.Products_Order_Type(column, order, FiltComboBox.Text));
                update();
            }

            if (search == true && filtr == true && sort == true)
            {
                products.Clear();
                products = Product.table_class(database.Products_Search_Type_Order(SearchtextBox.Text, FiltComboBox.Text, column, order));
                update();
            }

            if (search == false && filtr == false && sort == false)
            {
                products.Clear();
                products = Product.table_class(database.Products());
                update();
            }
        }

        private void SearchtextBox_Leave(object sender, EventArgs e)
        {
            if (SearchtextBox.Text == "")
            {
                SearchtextBox.Text = "Поиск";
                search = false;
                Query(search, filtr, sort);
            }
        }
    }
}
