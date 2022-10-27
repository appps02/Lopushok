namespace Lopushok
{
    partial class AgentList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentList));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Редактирование = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiltr = new System.Windows.Forms.ComboBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonEmail = new System.Windows.Forms.RadioButton();
            this.radioButtonPhone = new System.Windows.Forms.RadioButton();
            this.radioButtonSearch = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ASC = new System.Windows.Forms.ToolStripMenuItem();
            this.DESC = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Редактирование});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Редактирование
            // 
            this.Редактирование.HeaderText = "Редактирование";
            this.Редактирование.Name = "Редактирование";
            this.Редактирование.Text = "Редактирование";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxFiltr);
            this.panel1.Controls.Add(this.comboBoxSort);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 67);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фильтрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сортировка";
            // 
            // comboBoxFiltr
            // 
            this.comboBoxFiltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltr.FormattingEnabled = true;
            this.comboBoxFiltr.Items.AddRange(new object[] {
            "Все типы"});
            this.comboBoxFiltr.Location = new System.Drawing.Point(419, 17);
            this.comboBoxFiltr.Name = "comboBoxFiltr";
            this.comboBoxFiltr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltr.TabIndex = 5;
            this.comboBoxFiltr.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltr_SelectedIndexChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Без сортировки",
            "По наименование",
            "По приоритету"});
            this.comboBoxSort.Location = new System.Drawing.Point(292, 17);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSort.TabIndex = 4;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEmail);
            this.groupBox1.Controls.Add(this.radioButtonPhone);
            this.groupBox1.Controls.Add(this.radioButtonSearch);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // radioButtonEmail
            // 
            this.radioButtonEmail.AutoSize = true;
            this.radioButtonEmail.Location = new System.Drawing.Point(188, 41);
            this.radioButtonEmail.Name = "radioButtonEmail";
            this.radioButtonEmail.Size = new System.Drawing.Size(70, 17);
            this.radioButtonEmail.TabIndex = 3;
            this.radioButtonEmail.TabStop = true;
            this.radioButtonEmail.Text = "По почте";
            this.radioButtonEmail.UseVisualStyleBackColor = true;
            this.radioButtonEmail.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPhone
            // 
            this.radioButtonPhone.AutoSize = true;
            this.radioButtonPhone.Location = new System.Drawing.Point(97, 41);
            this.radioButtonPhone.Name = "radioButtonPhone";
            this.radioButtonPhone.Size = new System.Drawing.Size(90, 17);
            this.radioButtonPhone.TabIndex = 2;
            this.radioButtonPhone.TabStop = true;
            this.radioButtonPhone.Text = "По телефону";
            this.radioButtonPhone.UseVisualStyleBackColor = true;
            this.radioButtonPhone.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSearch
            // 
            this.radioButtonSearch.AutoSize = true;
            this.radioButtonSearch.Location = new System.Drawing.Point(6, 41);
            this.radioButtonSearch.Name = "radioButtonSearch";
            this.radioButtonSearch.Size = new System.Drawing.Size(92, 17);
            this.radioButtonSearch.TabIndex = 1;
            this.radioButtonSearch.TabStop = true;
            this.radioButtonSearch.Text = "По названию";
            this.radioButtonSearch.UseVisualStyleBackColor = true;
            this.radioButtonSearch.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(267, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(555, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(236, 61);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ASC,
            this.DESC});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(166, 48);
            this.ContextMenuStrip.Click += new System.EventHandler(this.ContextMenuStrip_Click);
            // 
            // ASC
            // 
            this.ASC.Name = "ASC";
            this.ASC.Size = new System.Drawing.Size(165, 22);
            this.ASC.Text = "По возрастанию";
            // 
            // DESC
            // 
            this.DESC.Name = "DESC";
            this.DESC.Size = new System.Drawing.Size(165, 22);
            this.DESC.Text = "По убыванию";
            // 
            // AgentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgentList";
            this.Text = "Лопушок - Список агентов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgentList_FormClosing);
            this.Load += new System.EventHandler(this.AgentList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Редактирование;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltr;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonEmail;
        private System.Windows.Forms.RadioButton radioButtonPhone;
        private System.Windows.Forms.RadioButton radioButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ASC;
        private System.Windows.Forms.ToolStripMenuItem DESC;
    }
}