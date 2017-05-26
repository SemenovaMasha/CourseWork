namespace CourseWork
{
    partial class OrderCon
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Chair = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chairMaterial = new System.Windows.Forms.ComboBox();
            this.chairHeight = new System.Windows.Forms.NumericUpDown();
            this.chairForm = new System.Windows.Forms.ComboBox();
            this.ChairType = new System.Windows.Forms.ComboBox();
            this.clientId = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tableWidth = new System.Windows.Forms.NumericUpDown();
            this.tableHeight = new System.Windows.Forms.NumericUpDown();
            this.legNumber = new System.Windows.Forms.NumericUpDown();
            this.tableMaterial = new System.Windows.Forms.ComboBox();
            this.tableForm = new System.Windows.Forms.ComboBox();
            this.tableType = new System.Windows.Forms.ComboBox();
            this.Cupboard = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.shelfNum = new System.Windows.Forms.NumericUpDown();
            this.cupWidth = new System.Windows.Forms.NumericUpDown();
            this.cupHeight = new System.Windows.Forms.NumericUpDown();
            this.doorMaterial = new System.Windows.Forms.ComboBox();
            this.cupMaterial = new System.Windows.Forms.ComboBox();
            this.cupType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chairHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legNumber)).BeginInit();
            this.Cupboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shelfNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(450, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Chair
            // 
            this.Chair.Controls.Add(this.label6);
            this.Chair.Controls.Add(this.label5);
            this.Chair.Controls.Add(this.label4);
            this.Chair.Controls.Add(this.label3);
            this.Chair.Controls.Add(this.chairMaterial);
            this.Chair.Controls.Add(this.chairHeight);
            this.Chair.Controls.Add(this.chairForm);
            this.Chair.Controls.Add(this.ChairType);
            this.Chair.Location = new System.Drawing.Point(450, 86);
            this.Chair.Name = "Chair";
            this.Chair.Size = new System.Drawing.Size(287, 286);
            this.Chair.TabIndex = 5;
            this.Chair.TabStop = false;
            this.Chair.Text = "Стул";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Высота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Форма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Материал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип";
            // 
            // chairMaterial
            // 
            this.chairMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chairMaterial.FormattingEnabled = true;
            this.chairMaterial.Location = new System.Drawing.Point(133, 62);
            this.chairMaterial.Name = "chairMaterial";
            this.chairMaterial.Size = new System.Drawing.Size(124, 21);
            this.chairMaterial.TabIndex = 5;
            // 
            // chairHeight
            // 
            this.chairHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.chairHeight.Location = new System.Drawing.Point(133, 116);
            this.chairHeight.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.chairHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.chairHeight.Name = "chairHeight";
            this.chairHeight.Size = new System.Drawing.Size(124, 20);
            this.chairHeight.TabIndex = 4;
            this.chairHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chairForm
            // 
            this.chairForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chairForm.FormattingEnabled = true;
            this.chairForm.Location = new System.Drawing.Point(133, 89);
            this.chairForm.Name = "chairForm";
            this.chairForm.Size = new System.Drawing.Size(124, 21);
            this.chairForm.TabIndex = 3;
            // 
            // ChairType
            // 
            this.ChairType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChairType.FormattingEnabled = true;
            this.ChairType.Location = new System.Drawing.Point(133, 35);
            this.ChairType.Name = "ChairType";
            this.ChairType.Size = new System.Drawing.Size(124, 21);
            this.ChairType.TabIndex = 2;
            this.ChairType.SelectedIndexChanged += new System.EventHandler(this.ChairType_SelectedIndexChanged);
            // 
            // clientId
            // 
            this.clientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientId.FormattingEnabled = true;
            this.clientId.Location = new System.Drawing.Point(583, 47);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(110, 21);
            this.clientId.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 441);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Заказать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Table
            // 
            this.Table.Controls.Add(this.label8);
            this.Table.Controls.Add(this.label13);
            this.Table.Controls.Add(this.label14);
            this.Table.Controls.Add(this.label15);
            this.Table.Controls.Add(this.label16);
            this.Table.Controls.Add(this.label17);
            this.Table.Controls.Add(this.tableWidth);
            this.Table.Controls.Add(this.tableHeight);
            this.Table.Controls.Add(this.legNumber);
            this.Table.Controls.Add(this.tableMaterial);
            this.Table.Controls.Add(this.tableForm);
            this.Table.Controls.Add(this.tableType);
            this.Table.Location = new System.Drawing.Point(1096, 86);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(287, 286);
            this.Table.TabIndex = 10;
            this.Table.TabStop = false;
            this.Table.Text = "Стол";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ширина";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Высота";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Форма";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Количество ножек";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Материал";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Тип";
            // 
            // tableWidth
            // 
            this.tableWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tableWidth.Location = new System.Drawing.Point(146, 165);
            this.tableWidth.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.tableWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tableWidth.Name = "tableWidth";
            this.tableWidth.Size = new System.Drawing.Size(113, 20);
            this.tableWidth.TabIndex = 15;
            this.tableWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tableHeight
            // 
            this.tableHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tableHeight.Location = new System.Drawing.Point(146, 142);
            this.tableHeight.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.tableHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tableHeight.Name = "tableHeight";
            this.tableHeight.Size = new System.Drawing.Size(113, 20);
            this.tableHeight.TabIndex = 14;
            this.tableHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // legNumber
            // 
            this.legNumber.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.legNumber.Location = new System.Drawing.Point(146, 88);
            this.legNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.legNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.legNumber.Name = "legNumber";
            this.legNumber.Size = new System.Drawing.Size(113, 20);
            this.legNumber.TabIndex = 13;
            this.legNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // tableMaterial
            // 
            this.tableMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableMaterial.FormattingEnabled = true;
            this.tableMaterial.Location = new System.Drawing.Point(146, 61);
            this.tableMaterial.Name = "tableMaterial";
            this.tableMaterial.Size = new System.Drawing.Size(113, 21);
            this.tableMaterial.TabIndex = 7;
            // 
            // tableForm
            // 
            this.tableForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableForm.FormattingEnabled = true;
            this.tableForm.Location = new System.Drawing.Point(146, 115);
            this.tableForm.Name = "tableForm";
            this.tableForm.Size = new System.Drawing.Size(113, 21);
            this.tableForm.TabIndex = 3;
            // 
            // tableType
            // 
            this.tableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableType.FormattingEnabled = true;
            this.tableType.Location = new System.Drawing.Point(146, 35);
            this.tableType.Name = "tableType";
            this.tableType.Size = new System.Drawing.Size(113, 21);
            this.tableType.TabIndex = 2;
            this.tableType.SelectedIndexChanged += new System.EventHandler(this.tableType_SelectedIndexChanged);
            // 
            // Cupboard
            // 
            this.Cupboard.Controls.Add(this.label11);
            this.Cupboard.Controls.Add(this.label12);
            this.Cupboard.Controls.Add(this.label19);
            this.Cupboard.Controls.Add(this.label7);
            this.Cupboard.Controls.Add(this.label9);
            this.Cupboard.Controls.Add(this.label10);
            this.Cupboard.Controls.Add(this.shelfNum);
            this.Cupboard.Controls.Add(this.cupWidth);
            this.Cupboard.Controls.Add(this.cupHeight);
            this.Cupboard.Controls.Add(this.doorMaterial);
            this.Cupboard.Controls.Add(this.cupMaterial);
            this.Cupboard.Controls.Add(this.cupType);
            this.Cupboard.Location = new System.Drawing.Point(776, 86);
            this.Cupboard.Name = "Cupboard";
            this.Cupboard.Size = new System.Drawing.Size(287, 286);
            this.Cupboard.TabIndex = 9;
            this.Cupboard.TabStop = false;
            this.Cupboard.Text = "Шкаф";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Количество полок";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Материал двери";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Ширина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Высота";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Материал";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Тип";
            // 
            // shelfNum
            // 
            this.shelfNum.Location = new System.Drawing.Point(142, 165);
            this.shelfNum.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.shelfNum.Name = "shelfNum";
            this.shelfNum.Size = new System.Drawing.Size(108, 20);
            this.shelfNum.TabIndex = 12;
            this.shelfNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cupWidth
            // 
            this.cupWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cupWidth.Location = new System.Drawing.Point(142, 112);
            this.cupWidth.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.cupWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cupWidth.Name = "cupWidth";
            this.cupWidth.Size = new System.Drawing.Size(108, 20);
            this.cupWidth.TabIndex = 10;
            this.cupWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cupHeight
            // 
            this.cupHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cupHeight.Location = new System.Drawing.Point(142, 89);
            this.cupHeight.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.cupHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cupHeight.Name = "cupHeight";
            this.cupHeight.Size = new System.Drawing.Size(108, 20);
            this.cupHeight.TabIndex = 9;
            this.cupHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // doorMaterial
            // 
            this.doorMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorMaterial.FormattingEnabled = true;
            this.doorMaterial.Location = new System.Drawing.Point(142, 138);
            this.doorMaterial.Name = "doorMaterial";
            this.doorMaterial.Size = new System.Drawing.Size(108, 21);
            this.doorMaterial.TabIndex = 8;
            // 
            // cupMaterial
            // 
            this.cupMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cupMaterial.FormattingEnabled = true;
            this.cupMaterial.Location = new System.Drawing.Point(142, 61);
            this.cupMaterial.Name = "cupMaterial";
            this.cupMaterial.Size = new System.Drawing.Size(108, 21);
            this.cupMaterial.TabIndex = 7;
            // 
            // cupType
            // 
            this.cupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cupType.FormattingEnabled = true;
            this.cupType.Location = new System.Drawing.Point(142, 34);
            this.cupType.Name = "cupType";
            this.cupType.Size = new System.Drawing.Size(108, 21);
            this.cupType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пользователь";
            // 
            // OrderCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Cupboard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.Chair);
            this.Controls.Add(this.comboBox1);
            this.Name = "OrderCon";
            this.Text = "Конструктор";
            this.Chair.ResumeLayout(false);
            this.Chair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chairHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legNumber)).EndInit();
            this.Cupboard.ResumeLayout(false);
            this.Cupboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shelfNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox Chair;
        private System.Windows.Forms.NumericUpDown chairHeight;
        private System.Windows.Forms.ComboBox chairForm;
        private System.Windows.Forms.ComboBox ChairType;
        private System.Windows.Forms.ComboBox clientId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox chairMaterial;
        private System.Windows.Forms.GroupBox Table;
        private System.Windows.Forms.ComboBox tableForm;
        private System.Windows.Forms.ComboBox tableType;
        private System.Windows.Forms.GroupBox Cupboard;
        private System.Windows.Forms.ComboBox cupType;
        private System.Windows.Forms.ComboBox tableMaterial;
        private System.Windows.Forms.ComboBox doorMaterial;
        private System.Windows.Forms.ComboBox cupMaterial;
        private System.Windows.Forms.NumericUpDown cupWidth;
        private System.Windows.Forms.NumericUpDown cupHeight;
        private System.Windows.Forms.NumericUpDown tableWidth;
        private System.Windows.Forms.NumericUpDown tableHeight;
        private System.Windows.Forms.NumericUpDown legNumber;
        private System.Windows.Forms.NumericUpDown shelfNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}