namespace Lopushok
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.FiltComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.maximumpage = new System.Windows.Forms.Label();
            this.curpage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.поВозрастниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбиваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdoIA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отАДоЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отЯДоАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.UpDown.SuspendLayout();
            this.AdoIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(3, 4);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(242, 20);
            this.SearchtextBox.TabIndex = 0;
            this.SearchtextBox.Text = "Поиск";
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            this.SearchtextBox.Leave += new System.EventHandler(this.SearchtextBox_Leave);
            // 
            // SortComboBox
            // 
            this.SortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Без сортировки",
            "По названию",
            "По цене",
            "По артикулу"});
            this.SortComboBox.Location = new System.Drawing.Point(251, 4);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(129, 21);
            this.SortComboBox.TabIndex = 1;
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
            // 
            // FiltComboBox
            // 
            this.FiltComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltComboBox.FormattingEnabled = true;
            this.FiltComboBox.Items.AddRange(new object[] {
            "Все типы",
            "Три слоя",
            "Два слоя",
            "Один слой",
            "Детская",
            "Супер мягкая"});
            this.FiltComboBox.Location = new System.Drawing.Point(386, 4);
            this.FiltComboBox.Name = "FiltComboBox";
            this.FiltComboBox.Size = new System.Drawing.Size(135, 21);
            this.FiltComboBox.TabIndex = 2;
            this.FiltComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchtextBox);
            this.panel1.Controls.Add(this.SortComboBox);
            this.panel1.Controls.Add(this.FiltComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 41);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фильтрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортировка";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 479);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(524, 426);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.SystemColors.Control;
            this.Right.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Right.FlatAppearance.BorderSize = 0;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.ForeColor = System.Drawing.Color.Black;
            this.Right.Location = new System.Drawing.Point(511, 482);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(16, 23);
            this.Right.TabIndex = 4;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.SystemColors.Control;
            this.Left.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Left.FlatAppearance.BorderSize = 0;
            this.Left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left.ForeColor = System.Drawing.Color.Black;
            this.Left.Location = new System.Drawing.Point(433, 482);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(16, 23);
            this.Left.TabIndex = 5;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // maximumpage
            // 
            this.maximumpage.AutoSize = true;
            this.maximumpage.Location = new System.Drawing.Point(492, 487);
            this.maximumpage.Name = "maximumpage";
            this.maximumpage.Size = new System.Drawing.Size(13, 13);
            this.maximumpage.TabIndex = 6;
            this.maximumpage.Text = "1";
            // 
            // curpage
            // 
            this.curpage.AutoSize = true;
            this.curpage.Location = new System.Drawing.Point(455, 487);
            this.curpage.Name = "curpage";
            this.curpage.Size = new System.Drawing.Size(13, 13);
            this.curpage.TabIndex = 7;
            this.curpage.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "...";
            // 
            // UpDown
            // 
            this.UpDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастниюToolStripMenuItem,
            this.поУбиваниюToolStripMenuItem});
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(166, 48);
            this.UpDown.Click += new System.EventHandler(this.UpDown_Click);
            // 
            // поВозрастниюToolStripMenuItem
            // 
            this.поВозрастниюToolStripMenuItem.Name = "поВозрастниюToolStripMenuItem";
            this.поВозрастниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поВозрастниюToolStripMenuItem.Text = "По возрастанию";
            // 
            // поУбиваниюToolStripMenuItem
            // 
            this.поУбиваниюToolStripMenuItem.Name = "поУбиваниюToolStripMenuItem";
            this.поУбиваниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поУбиваниюToolStripMenuItem.Text = "По убыванию";
            // 
            // AdoIA
            // 
            this.AdoIA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отАДоЯToolStripMenuItem,
            this.отЯДоАToolStripMenuItem});
            this.AdoIA.Name = "AdoIA";
            this.AdoIA.Size = new System.Drawing.Size(126, 48);
            this.AdoIA.Click += new System.EventHandler(this.AdoIA_Click);
            // 
            // отАДоЯToolStripMenuItem
            // 
            this.отАДоЯToolStripMenuItem.Name = "отАДоЯToolStripMenuItem";
            this.отАДоЯToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.отАДоЯToolStripMenuItem.Text = "От А до Я";
            // 
            // отЯДоАToolStripMenuItem
            // 
            this.отЯДоАToolStripMenuItem.Name = "отЯДоАToolStripMenuItem";
            this.отЯДоАToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.отЯДоАToolStripMenuItem.Text = "От Я до А";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(530, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.curpage);
            this.Controls.Add(this.maximumpage);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lopushok";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.UpDown.ResumeLayout(false);
            this.AdoIA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.ComboBox FiltComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Label maximumpage;
        private System.Windows.Forms.Label curpage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip UpDown;
        private System.Windows.Forms.ToolStripMenuItem поВозрастниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбиваниюToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip AdoIA;
        private System.Windows.Forms.ToolStripMenuItem отАДоЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отЯДоАToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

