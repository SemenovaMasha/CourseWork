namespace CourseWork
{
    partial class Admin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectivenessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Store";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clients";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sales";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(86, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 58);
            this.button5.TabIndex = 4;
            this.button5.Text = "Providers";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dataBaseToolStripMenuItem.Text = "DataBase";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.providersToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.storeToolStripMenuItem.Text = "Store";
            this.storeToolStripMenuItem.Click += new System.EventHandler(this.storeToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.orderToolStripMenuItem.Text = "Orders";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // providersToolStripMenuItem
            // 
            this.providersToolStripMenuItem.Name = "providersToolStripMenuItem";
            this.providersToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.providersToolStripMenuItem.Text = "Providers";
            this.providersToolStripMenuItem.Click += new System.EventHandler(this.providersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomesToolStripMenuItem,
            this.expencesToolStripMenuItem,
            this.effectivenessToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // incomesToolStripMenuItem
            // 
            this.incomesToolStripMenuItem.Name = "incomesToolStripMenuItem";
            this.incomesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.incomesToolStripMenuItem.Text = "Incomes";
            this.incomesToolStripMenuItem.Click += new System.EventHandler(this.incomesToolStripMenuItem_Click);
            // 
            // expencesToolStripMenuItem
            // 
            this.expencesToolStripMenuItem.Name = "expencesToolStripMenuItem";
            this.expencesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.expencesToolStripMenuItem.Text = "Expenses";
            this.expencesToolStripMenuItem.Click += new System.EventHandler(this.expencesToolStripMenuItem_Click);
            // 
            // effectivenessToolStripMenuItem
            // 
            this.effectivenessToolStripMenuItem.Name = "effectivenessToolStripMenuItem";
            this.effectivenessToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.effectivenessToolStripMenuItem.Text = "Effectiveness";
            this.effectivenessToolStripMenuItem.Click += new System.EventHandler(this.effectivenessToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(291, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 433);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectivenessToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

