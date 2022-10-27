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
    public partial class AgentList : Form
    {
        private string column_order, order, like, cmd, query = @"SELECT [Agent].[Title] AS [Наименование], [AgentType].[Title] AS [Тип агента], Logo AS [Логотип], Phone AS [Телефон]
                                                                        FROM [Agent]
                                                                        INNER JOIN [AgentType] ON [AgentType].[ID] = [Agent].[AgentTypeID]";
        private bool search = false, sort = false, filtr = false;
        private DB dataBase = new DB();
        public List<Agent> agents = new List<Agent>();
        private MainWindow mainWindow;
        public AgentList(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
            InitializeComponent();
            comboBoxFiltr.Text = "Все типы";
            comboBoxSort.Text = "Без сортировки";
            Query();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSort.SelectedIndex == 0)
            {
                sort = false;
                Query();
            }
            else if(comboBoxSort.SelectedIndex == 1)
            {
                column_order = "[Agent].[Title]";
                ContextMenuStrip.Show();
            }
            else
            {
                column_order = "[Agent].[Priority]";
                ContextMenuStrip.Show();
            }

        }

        private void comboBoxFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltr.SelectedIndex == 0)
                filtr = false;
            else
                filtr = true;
            Query();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPhone.Checked == true)
            {
                like = "[Agent].[Phone]";
            }
            else if (radioButtonEmail.Checked == true)
            {
                like = "[Agent].[Email]";
            }
            else
            {
                like = "[Agent].[Title]";
            }
        }

        private void AgentList_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in DB.Data_Table("SELECT DISTINCT Title FROM AgentType").Rows)
            {
                comboBoxFiltr.Items.Add(row[0].ToString());
            }
        }

        private void ContextMenuStrip_Click(object sender, EventArgs e)
        {
            var i = (ContextMenuStrip)sender;
            if (i.Items[0].Selected)
                order = "ASC";
            else
                order = "DESC";
            sort = true;
            Query();
        }

        public void refresh()
        {
            agents.Clear();
            agents = Agent.table_agents(dataBase.ListofAgents());
            dataGridView1.DataSource = DB.Data_Table(cmd);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;
            if (senderGrid.CurrentCell is DataGridViewButtonCell && e.RowIndex >= 0)
            {
                AgentEdit agentEdit = new AgentEdit(this, dataBase, dataGridView1);
                agentEdit.ShowDialog();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgentAdd agentAdd = new AgentAdd(dataBase, this);
            agentAdd.ShowDialog();
        }

        private void AgentList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DB.Connection.State == ConnectionState.Open)
                DB.Connection.Close();
            mainWindow.Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                search = false;
            else
                search = true;
            Query();
        }

        private void Query()
        {
            if (search == true && sort == false && filtr == false)
            {
                cmd = query + $" WHERE {like} LIKE '%{textBoxSearch.Text}%'";
            }
            else if (search == false && sort == true && filtr == false)
            {
                cmd = query + $" ORDER BY {column_order} {order}";
            }
            else if (search == true && sort == true && filtr == false)
            {
                cmd = query + $" WHERE {like} LIKE '%{textBoxSearch.Text}%'" + $" ORDER BY {column_order} {order}";
            }
            else if (search == false && sort == false && filtr == true)
            {
                cmd = query + $" WHERE [AgentType].[Title] = '{comboBoxFiltr.Text}'";
            }
            else if (search == true && sort == false && filtr == true)
            {
                cmd = query + $" WHERE [AgentType].[Title] = '{comboBoxFiltr.Text}' AND {like} LIKE '%{textBoxSearch.Text}%'";
            }
            else if (search == false && sort == true && filtr == true)
            {
                cmd = query + $" WHERE [AgentType].[Title] = '{comboBoxFiltr.Text}' ORDER BY {column_order} {order}";
            }
            else if (search == true && sort == true && filtr == true)
            {
                cmd = query + $" WHERE [AgentType].[Title] = '{comboBoxFiltr.Text}' AND {like} LIKE '%{textBoxSearch.Text}%' ORDER BY {column_order} {order}";
            }
            else
                cmd = query;
            refresh();
        }
    }
}
