namespace Lopushok
{ 
    partial class AgentEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentEdit));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeAgent = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лопушокDataSet = new Lopushok.ЛопушокDataSet();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.textBoxLogo = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxDirectorName = new System.Windows.Forms.TextBox();
            this.textBoxKPP = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.agentTypeTableAdapter = new Lopushok.ЛопушокDataSetTableAdapters.AgentTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лопушокDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Приоритет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Логотип";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Электронная почта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Имя директора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "КПП";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "ИНН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Тип агента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Название";
            // 
            // comboBoxTypeAgent
            // 
            this.comboBoxTypeAgent.DataSource = this.agentTypeBindingSource;
            this.comboBoxTypeAgent.DisplayMember = "Title";
            this.comboBoxTypeAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeAgent.FormattingEnabled = true;
            this.comboBoxTypeAgent.Location = new System.Drawing.Point(131, 31);
            this.comboBoxTypeAgent.Name = "comboBoxTypeAgent";
            this.comboBoxTypeAgent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeAgent.TabIndex = 30;
            this.comboBoxTypeAgent.ValueMember = "ID";
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
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(131, 240);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriority.TabIndex = 29;
            // 
            // textBoxLogo
            // 
            this.textBoxLogo.Location = new System.Drawing.Point(131, 214);
            this.textBoxLogo.Name = "textBoxLogo";
            this.textBoxLogo.Size = new System.Drawing.Size(121, 20);
            this.textBoxLogo.TabIndex = 28;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(131, 188);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEmail.TabIndex = 27;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(131, 162);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(121, 20);
            this.textBoxPhone.TabIndex = 26;
            // 
            // textBoxDirectorName
            // 
            this.textBoxDirectorName.Location = new System.Drawing.Point(131, 136);
            this.textBoxDirectorName.Name = "textBoxDirectorName";
            this.textBoxDirectorName.Size = new System.Drawing.Size(121, 20);
            this.textBoxDirectorName.TabIndex = 25;
            // 
            // textBoxKPP
            // 
            this.textBoxKPP.Location = new System.Drawing.Point(131, 110);
            this.textBoxKPP.Name = "textBoxKPP";
            this.textBoxKPP.Size = new System.Drawing.Size(121, 20);
            this.textBoxKPP.TabIndex = 24;
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(131, 84);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(121, 20);
            this.textBoxINN.TabIndex = 23;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(131, 58);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddress.TabIndex = 22;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(131, 5);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitle.TabIndex = 21;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(15, 282);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(75, 23);
            this.SaveChanges.TabIndex = 41;
            this.SaveChanges.Text = "Обновить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(177, 282);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 42;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // agentTypeTableAdapter
            // 
            this.agentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // AgentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 326);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.textBoxLogo);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxDirectorName);
            this.Controls.Add(this.textBoxKPP);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgentEdit";
            this.Text = "Лопушок - Редактирование агента";
            this.Load += new System.EventHandler(this.AgentEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лопушокDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeAgent;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.TextBox textBoxLogo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxDirectorName;
        private System.Windows.Forms.TextBox textBoxKPP;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button Delete;
        private ЛопушокDataSet лопушокDataSet;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private ЛопушокDataSetTableAdapters.AgentTypeTableAdapter agentTypeTableAdapter;
    }
}