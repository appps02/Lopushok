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
        private string filename;
        private DataGridView DataGridView;
        private Agent agent;
        private List <Agent> agents;
        private int ID;
        public AgentEdit(AgentList _agentList, DB _database, DataGridView _dataGridView, List<Agent> _agents)
        {
            agentList = _agentList;
            database = _database;
            DataGridView = _dataGridView;
            agents = _agents;
            InitializeComponent();
        }


        private void AgentEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лопушокDataSet.AgentType". При необходимости она может быть перемещена или удалена.
            this.agentTypeTableAdapter.Fill(this.лопушокDataSet.AgentType);
            List <Agent> agent = agentList.agents.Where(a => a.Title == DataGridView.CurrentRow.Cells[1].Value.ToString() && a.Phone == DataGridView.CurrentRow.Cells[4].Value.ToString()).ToList();
            if (agent.Count == 0 || agent.Count > 1)
            {
                MessageBox.Show("Агент не найден.");
                Close();
            }
            else
            {
                this.agent = agent.FirstOrDefault();
            }
            comboBoxTypeAgent.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            textBoxTitle.Text = this.agent.Title;
            textBoxAddress.Text = this.agent.Address;
            textBoxINN.Text = this.agent.INN;
            textBoxKPP.Text = this.agent.KPP;
            if (this.agent.Logo != "")
            {
                try
                {
                    pictureBox.Image = new Bitmap(this.agent.Logo);
                    filename = this.agent.Logo;
                }
                catch
                {
                    MessageBox.Show("Изображение не найдено или повреждено. Проверьте путь к изображению");
                    pictureBox.Image = Properties.Resources.picture;
                    filename = "";
                }
            }
            else
            {
                pictureBox.Image = Properties.Resources.picture;
                filename = "";
            }
            textBoxDirectorName.Text = this.agent.DirectorName;
            textBoxPhone.Text = this.agent.Phone;
            textBoxEmail.Text = this.agent.Email;
            textBoxPriority.Text = this.agent.Priority.ToString();
            ID = this.agent.ID;
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
                            WHERE [ID] = {agent.ID}") != 0)
                    {
                        MessageBox.Show("Агент удалён");
                        Close();
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
                if (agents.Where(a => a.INN == textBoxINN.Text && a.ID != agent.ID).ToList().Count > 0)
                {
                    MessageBox.Show("Агент с таким телефоном или ИНН уже существует");
                    return;
                }
                database.request($@"UPDATE [Agent] SET Title = '{textBoxTitle.Text}', AgentTypeID = {comboBoxTypeAgent.SelectedValue}, Address = '{textBoxAddress.Text}', 
                INN = '{textBoxINN.Text}', KPP = '{textBoxKPP.Text}', DirectorName = '{textBoxDirectorName.Text}', Phone = '{textBoxPhone.Text}', Email = '{textBoxEmail.Text}', 
                Logo = '{filename}', Priority = {Convert.ToInt32(textBoxPriority.Text)} WHERE ID = {ID}");
                agentList.refresh();
                MessageBox.Show("Изменения внесены.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBoxTitle.Text = textBoxTitle.Text.TrimStart();
            Label[] labels = { label11, label12, label13, label14 };
            TextBox[] textBoxes = { textBoxTitle, textBoxINN, textBoxPhone, textBoxPriority };
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == "")
                    labels.Where(l => l.Tag.Equals(textBox.Tag)).First().Text = "Пустое поле";
                else
                    labels.Where(l => l.Tag.Equals(textBox.Tag)).First().Text = labels.Where(l => l.Tag.Equals(textBox.Tag)).First().Text.Replace("Пустое поле", "");
            }
            textBoxes = textBoxes.Where(l => Convert.ToInt32(l.Tag) != 1).ToArray();
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (TextBox textBox in textBoxes)
            {
                foreach (char i in textBox.Text)
                {
                    if (textBox.Text != "" && !chars.Contains(i))
                    {
                        labels.Where(l => l.Tag.Equals(textBox.Tag)).First().Text = "Только целые\nчисла; Без пробелов";
                    }
                    else
                    {
                        labels.Where(l => l.Tag.Equals(textBox.Tag)).First().Text = labels.Where(l => l.Tag.Equals(textBox.Tag)).First().Text.Replace("Только целые\nчисла; Без пробелов", "");
                    }
                }
            }
            SaveChanges.Enabled = check();
        }

        private bool check()
        {
            Label[] labels = { label11, label12, label13, label14 };
            foreach (Label label in labels)
            {
                if (label.Text != "")
                    return false;
            }
            return true;
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = new Bitmap(openFileDialog.FileName);
                    filename = openFileDialog.FileName;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Файл не найден или поврежден");
                    pictureBox.Image = Properties.Resources.picture;
                    filename = "";
                }
            }
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.picture;
            filename = "";
            SaveChanges.Enabled = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
