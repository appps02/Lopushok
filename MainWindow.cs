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
            try
            {
                ProductList productList = new ProductList(this);
                productList.Show();
                Hide();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                var choice = MessageBox.Show("Не удалось подключится к базе данных из-за отсутствия файла базы данных или из-за повреждения. Вы хотите указать местоположение файла?", "Ошибка подключения", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.ShowDialog();
                    string filename = openFileDialog.FileName;
                    DB.Connection = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Lopushok"].ConnectionString.Replace($@"{System.Configuration.ConfigurationManager.ConnectionStrings["Lopushok"].ConnectionString}", $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={filename}"));
                }
                else
                    return;
            }
        }

        private void AgentList_Click(object sender, EventArgs e)
        {
            try
            {
                ProductList productList = new ProductList(this);
                productList.Show();
                Hide();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                var choice = MessageBox.Show("Не удалось подключится к базе данных из-за отсутствия файла базы данных или из-за повреждения. Вы хотите указать местоположение файла?", "Ошибка подключения", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.ShowDialog();
                    string filename = openFileDialog.FileName;
                    DB.Connection = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Lopushok"].ConnectionString.Replace($@"{System.Configuration.ConfigurationManager.ConnectionStrings["Lopushok"].ConnectionString}", $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={filename}"));
                }
                else
                    return;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
