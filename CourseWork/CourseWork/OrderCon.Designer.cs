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
            this.chairMaterial = new System.Windows.Forms.ComboBox();
            this.chairHeight = new System.Windows.Forms.NumericUpDown();
            this.chairForm = new System.Windows.Forms.ComboBox();
            this.ChairType = new System.Windows.Forms.ComboBox();
            this.clientId = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.GroupBox();
            this.tableForm = new System.Windows.Forms.ComboBox();
            this.tableType = new System.Windows.Forms.ComboBox();
            this.Cupboard = new System.Windows.Forms.GroupBox();
            this.cupType = new System.Windows.Forms.ComboBox();
            this.cupMaterial = new System.Windows.Forms.ComboBox();
            this.doorMaterial = new System.Windows.Forms.ComboBox();
            this.tableMaterial = new System.Windows.Forms.ComboBox();
            this.cupHeight = new System.Windows.Forms.NumericUpDown();
            this.cupWidth = new System.Windows.Forms.NumericUpDown();
            this.shelfNum = new System.Windows.Forms.NumericUpDown();
            this.legNumber = new System.Windows.Forms.NumericUpDown();
            this.tableWidth = new System.Windows.Forms.NumericUpDown();
            this.tableHeight = new System.Windows.Forms.NumericUpDown();
            this.Chair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chairHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Table.SuspendLayout();
            this.Cupboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cupHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(449, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Chair
            // 
            this.Chair.Controls.Add(this.chairMaterial);
            this.Chair.Controls.Add(this.chairHeight);
            this.Chair.Controls.Add(this.chairForm);
            this.Chair.Controls.Add(this.ChairType);
            this.Chair.Location = new System.Drawing.Point(449, 55);
            this.Chair.Name = "Chair";
            this.Chair.Size = new System.Drawing.Size(287, 286);
            this.Chair.TabIndex = 5;
            this.Chair.TabStop = false;
            this.Chair.Text = "Chair";
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
            this.clientId.Location = new System.Drawing.Point(582, 17);
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
            this.button1.Location = new System.Drawing.Point(460, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Table
            // 
            this.Table.Controls.Add(this.tableWidth);
            this.Table.Controls.Add(this.tableHeight);
            this.Table.Controls.Add(this.legNumber);
            this.Table.Controls.Add(this.tableMaterial);
            this.Table.Controls.Add(this.tableForm);
            this.Table.Controls.Add(this.tableType);
            this.Table.Location = new System.Drawing.Point(1054, 55);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(287, 286);
            this.Table.TabIndex = 10;
            this.Table.TabStop = false;
            this.Table.Text = "Table";
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
            this.Cupboard.Controls.Add(this.shelfNum);
            this.Cupboard.Controls.Add(this.cupWidth);
            this.Cupboard.Controls.Add(this.cupHeight);
            this.Cupboard.Controls.Add(this.doorMaterial);
            this.Cupboard.Controls.Add(this.cupMaterial);
            this.Cupboard.Controls.Add(this.cupType);
            this.Cupboard.Location = new System.Drawing.Point(761, 55);
            this.Cupboard.Name = "Cupboard";
            this.Cupboard.Size = new System.Drawing.Size(287, 286);
            this.Cupboard.TabIndex = 9;
            this.Cupboard.TabStop = false;
            this.Cupboard.Text = "Cupboard";
            // 
            // cupType
            // 
            this.cupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cupType.FormattingEnabled = true;
            this.cupType.Location = new System.Drawing.Point(163, 35);
            this.cupType.Name = "cupType";
            this.cupType.Size = new System.Drawing.Size(108, 21);
            this.cupType.TabIndex = 2;
            // 
            // cupMaterial
            // 
            this.cupMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cupMaterial.FormattingEnabled = true;
            this.cupMaterial.Location = new System.Drawing.Point(163, 62);
            this.cupMaterial.Name = "cupMaterial";
            this.cupMaterial.Size = new System.Drawing.Size(108, 21);
            this.cupMaterial.TabIndex = 7;
            // 
            // doorMaterial
            // 
            this.doorMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorMaterial.FormattingEnabled = true;
            this.doorMaterial.Location = new System.Drawing.Point(163, 139);
            this.doorMaterial.Name = "doorMaterial";
            this.doorMaterial.Size = new System.Drawing.Size(108, 21);
            this.doorMaterial.TabIndex = 8;
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
            // cupHeight
            // 
            this.cupHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cupHeight.Location = new System.Drawing.Point(163, 90);
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
            // cupWidth
            // 
            this.cupWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cupWidth.Location = new System.Drawing.Point(163, 113);
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
            // shelfNum
            // 
            this.shelfNum.Location = new System.Drawing.Point(163, 166);
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
            // legNumber
            // 
            this.legNumber.Location = new System.Drawing.Point(146, 88);
            this.legNumber.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.legNumber.Name = "legNumber";
            this.legNumber.Size = new System.Drawing.Size(113, 20);
            this.legNumber.TabIndex = 13;
            this.legNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // OrderCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Cupboard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.Chair);
            this.Controls.Add(this.comboBox1);
            this.Name = "OrderCon";
            this.Text = "OrderCon";
            this.Chair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chairHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Table.ResumeLayout(false);
            this.Cupboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cupHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeight)).EndInit();
            this.ResumeLayout(false);

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
    }
}