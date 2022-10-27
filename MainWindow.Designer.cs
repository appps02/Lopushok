namespace Lopushok
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ProductList = new System.Windows.Forms.Button();
            this.AgentList = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.Location = new System.Drawing.Point(12, 12);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(200, 60);
            this.ProductList.TabIndex = 0;
            this.ProductList.Text = "Продукты";
            this.ProductList.UseVisualStyleBackColor = true;
            this.ProductList.Click += new System.EventHandler(this.ProductList_Click);
            // 
            // AgentList
            // 
            this.AgentList.Location = new System.Drawing.Point(12, 77);
            this.AgentList.Name = "AgentList";
            this.AgentList.Size = new System.Drawing.Size(200, 60);
            this.AgentList.TabIndex = 1;
            this.AgentList.Text = "Агенты";
            this.AgentList.UseVisualStyleBackColor = true;
            this.AgentList.Click += new System.EventHandler(this.AgentList_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 143);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 60);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 216);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AgentList);
            this.Controls.Add(this.ProductList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Лопушок - Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductList;
        private System.Windows.Forms.Button AgentList;
        private System.Windows.Forms.Button Exit;
    }
}