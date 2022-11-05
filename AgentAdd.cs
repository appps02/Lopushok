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
        private string filename = "";
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
                database.SaveChanges(textBoxTitle.Text, Convert.ToInt32(comboBoxTypeAgent.SelectedValue), textBoxAddress.Text, textBoxINN.Text, textBoxKPP.Text, textBoxDirectorName.Text, textBoxPhone.Text, textBoxEmail.Text, filename, Convert.ToInt32(textBoxPriority.Text));
                MessageBox.Show("Агент внесен в базу успешно");
                Close();
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
            Label[] labels = { label11, label12, label13, label14 };
            foreach(Label label in labels)
            {
                if (label.Text != "")
                    return false;
            }
            return true;
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
            textBoxes = textBoxes.Where(l=>Convert.ToInt32(l.Tag) != 1).ToArray();
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach(TextBox textBox in textBoxes)
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

            buttonSaveAdd.Enabled = check();
        }

        private void buttonPictureDelete_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.picture;
            filename = "";
        }

        private void buttonPictureAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = new Bitmap(openFileDialog.FileName);
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
    }
}
