namespace Lopushok
{
    partial class AgentAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentAdd));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.textBoxKPP = new System.Windows.Forms.TextBox();
            this.textBoxDirectorName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.comboBoxTypeAgent = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лопушокDataSet = new Lopushok.ЛопушокDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSaveAdd = new System.Windows.Forms.Button();
            this.buttonCancelAdd = new System.Windows.Forms.Button();
            this.agentTypeTableAdapter = new Lopushok.ЛопушокDataSetTableAdapters.AgentTypeTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPictureAdd = new System.Windows.Forms.Button();
            this.buttonPictureDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лопушокDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(117, 15);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Tag = "1";
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(117, 68);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddress.TabIndex = 1;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(117, 94);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(121, 20);
            this.textBoxINN.TabIndex = 2;
            this.textBoxINN.Tag = "2";
            this.textBoxINN.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxKPP
            // 
            this.textBoxKPP.Location = new System.Drawing.Point(117, 120);
            this.textBoxKPP.Name = "textBoxKPP";
            this.textBoxKPP.Size = new System.Drawing.Size(121, 20);
            this.textBoxKPP.TabIndex = 3;
            this.textBoxKPP.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxDirectorName
            // 
            this.textBoxDirectorName.Location = new System.Drawing.Point(117, 146);
            this.textBoxDirectorName.Name = "textBoxDirectorName";
            this.textBoxDirectorName.Size = new System.Drawing.Size(121, 20);
            this.textBoxDirectorName.TabIndex = 4;
            this.textBoxDirectorName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(117, 172);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(121, 20);
            this.textBoxPhone.TabIndex = 5;
            this.textBoxPhone.Tag = "3";
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(117, 198);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(117, 227);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriority.TabIndex = 8;
            this.textBoxPriority.Tag = "4";
            this.textBoxPriority.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // comboBoxTypeAgent
            // 
            this.comboBoxTypeAgent.DataSource = this.agentTypeBindingSource;
            this.comboBoxTypeAgent.DisplayMember = "Title";
            this.comboBoxTypeAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeAgent.FormattingEnabled = true;
            this.comboBoxTypeAgent.Location = new System.Drawing.Point(117, 41);
            this.comboBoxTypeAgent.Name = "comboBoxTypeAgent";
            this.comboBoxTypeAgent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeAgent.TabIndex = 10;
            this.comboBoxTypeAgent.ValueMember = "ID";
            this.comboBoxTypeAgent.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataMember = "AgentType";
            this.agentTypeBindingSource.DataSource = this.лопушокDataSet;
            // 
            // лопушокDataSet
            // 
            this.лопушокDataSet.DataSetName = "ЛопушокDataSet";
            this.лопушокDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип агента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ИНН";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "КПП";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Имя директора";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Электронная почта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Приоритет";
            // 
            // buttonSaveAdd
            // 
            this.buttonSaveAdd.Enabled = false;
            this.buttonSaveAdd.Location = new System.Drawing.Point(50, 275);
            this.buttonSaveAdd.Name = "buttonSaveAdd";
            this.buttonSaveAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAdd.TabIndex = 21;
            this.buttonSaveAdd.Text = "Сохранить";
            this.buttonSaveAdd.UseVisualStyleBackColor = true;
            this.buttonSaveAdd.Click += new System.EventHandler(this.buttonSaveAdd_Click);
            // 
            // buttonCancelAdd
            // 
            this.buttonCancelAdd.Location = new System.Drawing.Point(459, 275);
            this.buttonCancelAdd.Name = "buttonCancelAdd";
            this.buttonCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAdd.TabIndex = 22;
            this.buttonCancelAdd.Text = "Отмена";
            this.buttonCancelAdd.UseVisualStyleBackColor = true;
            this.buttonCancelAdd.Click += new System.EventHandler(this.buttonCancelAdd_Click);
            // 
            // agentTypeTableAdapter
            // 
            this.agentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 44;
            this.label11.Tag = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 45;
            this.label12.Tag = "2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(244, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 46;
            this.label13.Tag = "3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(244, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 47;
            this.label14.Tag = "4";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Lopushok.Properties.Resources.picture;
            this.pictureBox.Location = new System.Drawing.Point(364, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(182, 170);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 48;
            this.pictureBox.TabStop = false;
            // 
            // buttonPictureAdd
            // 
            this.buttonPictureAdd.Location = new System.Drawing.Point(364, 191);
            this.buttonPictureAdd.Name = "buttonPictureAdd";
            this.buttonPictureAdd.Size = new System.Drawing.Size(182, 23);
            this.buttonPictureAdd.TabIndex = 49;
            this.buttonPictureAdd.Text = "Добавить изображение";
            this.buttonPictureAdd.UseVisualStyleBackColor = true;
            this.buttonPictureAdd.Click += new System.EventHandler(this.buttonPictureAdd_Click);
            // 
            // buttonPictureDelete
            // 
            this.buttonPictureDelete.Location = new System.Drawing.Point(364, 220);
            this.buttonPictureDelete.Name = "buttonPictureDelete";
            this.buttonPictureDelete.Size = new System.Drawing.Size(182, 23);
            this.buttonPictureDelete.TabIndex = 50;
            this.buttonPictureDelete.Text = "Удалить изображение";
            this.buttonPictureDelete.UseVisualStyleBackColor = true;
            this.buttonPictureDelete.Click += new System.EventHandler(this.buttonPictureDelete_Click);
            // 
            // AgentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 320);
            this.Controls.Add(this.buttonPictureDelete);
            this.Controls.Add(this.buttonPictureAdd);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonCancelAdd);
            this.Controls.Add(this.buttonSaveAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeAgent);
            this.Controls.Add(this.textBoxPriority);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxDirectorName);
            this.Controls.Add(this.textBoxKPP);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgentAdd";
            this.Text = "Лопушок - Добавление агента";
            this.Load += new System.EventHandler(this.AgentAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лопушокDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.TextBox textBoxKPP;
        private System.Windows.Forms.TextBox textBoxDirectorName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxTypeAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSaveAdd;
        private System.Windows.Forms.Button buttonCancelAdd;
        private ЛопушокDataSet лопушокDataSet;
        private ЛопушокDataSetTableAdapters.AgentTypeTableAdapter agentTypeTableAdapter;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonPictureAdd;
        private System.Windows.Forms.Button buttonPictureDelete;
    }
}