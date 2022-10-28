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
        private List <Agent> agents;
        private Dictionary<int, string> agentType = new Dictionary<int, string>();
        public AgentAdd(DB _database, AgentList _agentList, List<Agent> _agents)
        {
            database = _database;
            agentList = _agentList;
            agents = _agents;
            InitializeComponent();
        }

        private void buttonSaveAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(agents.Where(a => a.INN == textBoxINN.Text || a.Phone == textBoxPhone.Text).ToList().Count >= 1)
                {
                    MessageBox.Show("Агент с таким телефоном или ИНН уже существует");
                    return;
                }
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
            buttonSaveAdd.Enabled = false;
        }

        private bool check()
        {
            char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (textBoxTitle.Text.Trim() == "")
            {
                label11.Visible = true;
                return false;
            }
            else
                label11.Visible = false;
            if (textBoxINN.Text.Trim() == "")
            {
                label12.Text = "Пустое поле";
                label12.Visible = true;
                return false;
            }
            else
                label12.Visible = false;
            if (textBoxPhone.Text.Trim() == "")
            {
                label13.Text = "Пустое поле";
                label13.Visible = true;
                return false;
            }
            else
                label13.Visible = false;
            if (textBoxPriority.Text.Trim() == "")
            {
                label14.Text = "Пустое поле";
                label14.Visible = true;
                return false;
            }
            else
                label14.Visible = false;
            foreach (char i in textBoxINN.Text)
            {
                if (!nums.Contains(i))
                {
                    label12.Text = "Только целые числа";
                    label12.Visible = true;
                    return false;
                }
            }
            foreach (char i in textBoxPhone.Text)
            {
                if (!nums.Contains(i))
                {
                    label13.Text = "Только целые числа";
                    label13.Visible = true;
                    return false;
                }
            }
            foreach (char i in textBoxPriority.Text)
            {
                if (!nums.Contains(i))
                {
                    label14.Text = "Только целые числа";
                    label14.Visible = true;
                    return false;
                }
            }
            return true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            buttonSaveAdd.Enabled = check();
        }
    }
}
