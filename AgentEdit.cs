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
    public partial class AgentEdit : Form
    {
        private AgentList agentList;
        private DB database;
        private DataGridView DataGridView;
        private List<Agent> agent;
        private int ID;
        public AgentEdit(AgentList _agentList, DB _database, DataGridView _dataGridView)
        {
            agentList = _agentList;
            database = _database;
            DataGridView = _dataGridView;
            InitializeComponent();
        }


        private void AgentEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лопушокDataSet.AgentType". При необходимости она может быть перемещена или удалена.
            this.agentTypeTableAdapter.Fill(this.лопушокDataSet.AgentType);
            this.agent = agentList.agents.Where(a => a.Title == DataGridView.CurrentRow.Cells[1].Value.ToString() && a.Phone == DataGridView.CurrentRow.Cells[4].Value.ToString()).ToList();
            if (agent.Count == 0 || agent.Count > 1)
            {
                MessageBox.Show("Агент не найден.");
                this.Close();
            }
            comboBoxTypeAgent.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            textBoxTitle.Text = agent[0].Title;
            textBoxAddress.Text = agent[0].Address;
            textBoxINN.Text = agent[0].INN;
            textBoxKPP.Text = agent[0].KPP;
            textBoxDirectorName.Text = agent[0].DirectorName;
            textBoxPhone.Text = agent[0].Phone;
            textBoxEmail.Text = agent[0].Email;
            textBoxLogo.Text = agent[0].Logo;
            textBoxPriority.Text = agent[0].Priority.ToString();
            DataRow ID = DB.Data_Table($"SELECT [ID] FROM [Agent] WHERE [Title] = '{agent[0].Title}' AND [INN] = '{agent[0].INN}'").Rows[0];
            this.ID = Convert.ToInt32(ID.ItemArray[0]);
            SaveChanges.Enabled = false;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var choice = MessageBox.Show("Вы уверены, что хотите удалить агента?", "Удаление", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    if (database.request($@"DELETE
                            FROM [Agent]
                            WHERE [INN] = '{agent[0].INN}'") != 0)
                    {
                        MessageBox.Show("Агент удалён");
                        this.Close();
                    }

                    else
                        MessageBox.Show("Агент не найден.");
                    agentList.refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
        }
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (agent.Where(a => a.INN == textBoxINN.Text || a.Phone == textBoxPhone.Text).ToList().Count >= 1)
                {
                    MessageBox.Show("Агент с таким телефоном или ИНН уже существует");
                    return;
                }
                database.request($@"UPDATE [Agent] SET Title = '{textBoxTitle.Text}', AgentTypeID = {comboBoxTypeAgent.SelectedValue}, Address = '{textBoxAddress.Text}', 
                INN = '{textBoxINN.Text}', KPP = '{textBoxKPP.Text}', DirectorName = '{textBoxDirectorName.Text}', Phone = '{textBoxPhone.Text}', Email = '{textBoxEmail.Text}', 
                Logo = '{textBoxLogo.Text}', Priority = {Convert.ToInt32(textBoxPriority.Text)} WHERE ID = {this.ID}");
                agentList.refresh();
                MessageBox.Show("Изменения внесены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            SaveChanges.Enabled = check();
        }

        private bool check()
        {
            char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if(textBoxTitle.Text.Trim() == "")
            {
                label11.Visible = true;
                return false;
            }
            else
                label11.Visible = false;
            if(textBoxINN.Text.Trim() == "")
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
                if(!nums.Contains(i))
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
    }
}
