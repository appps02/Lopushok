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
    public partial class AgentAdd : Form
    {
        private DB database;
        private AgentList agentList;
        private Dictionary<int, string> agentType = new Dictionary<int, string>();
        public AgentAdd(DB _database, AgentList _agentList)
        {
            database = _database;
            agentList = _agentList;
            InitializeComponent();
        }

        private void buttonSaveAdd_Click(object sender, EventArgs e)
        {
            try
            {
                database.SaveChanges(textBoxTitle.Text, Convert.ToInt32(comboBoxTypeAgent.SelectedValue), textBoxAddress.Text, textBoxINN.Text, textBoxKPP.Text, textBoxDirectorName.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxLogo.Text, Convert.ToInt32(textBoxPriority.Text));
                MessageBox.Show("Агент внесен в базу успешно");
                agentList.refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка\n{ex}");
            }
        }
        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgentAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лопушокDataSet.AgentType". При необходимости она может быть перемещена или удалена.
            this.agentTypeTableAdapter.Fill(this.лопушокDataSet.AgentType);

        }
    }
}
