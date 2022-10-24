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
        private DB dataBase = new DB();
        private List<Agent> agents = new List<Agent>();
        private MainWindow mainWindow;
        public AgentList(MainWindow _mainWindow)
        {
            InitializeComponent();
            agents = Agent.table_agents(dataBase.ListofAgents());
            refresh();
            mainWindow = _mainWindow;
        }

        public void refresh()
        {
            agents.Clear();
            agents = Agent.table_agents(dataBase.ListofAgents());
            dataGridView1.DataSource = DB.Data_Table(@"SELECT [Agent].[Title] AS [Наименование], [AgentType].[Title] AS [Тип агента], Logo AS [Логотип], Phone AS [Телефон]
                                                      FROM [Agent]
                                                      INNER JOIN [AgentType] ON [AgentType].[ID] = [Agent].[AgentTypeID]
                                                      ORDER BY [Agent].[ID] ASC");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;
            if(senderGrid.CurrentCell is DataGridViewButtonCell && e.RowIndex >= 0)
            {

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
    }
}
