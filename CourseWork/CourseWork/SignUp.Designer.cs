namespace CourseWork
{
    partial class SignUp
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
            this.ClientName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(146, 23);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(150, 20);
            this.ClientName.TabIndex = 0;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(143, 58);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(152, 20);
            this.Surname.TabIndex = 1;
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(144, 90);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(151, 20);
            this.Patronymic.TabIndex = 2;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(146, 129);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(148, 20);
            this.Mail.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(148, 167);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(147, 20);
            this.Address.TabIndex = 4;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(146, 200);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(149, 20);
            this.Phone.TabIndex = 5;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(97, 242);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(129, 20);
            this.Login.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(95, 277);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(130, 20);
            this.Password.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(16, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.ClientName);
            this.Name = "SignIn";
            this.Text = "SingUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox ClientName;
        public System.Windows.Forms.TextBox Surname;
        public System.Windows.Forms.TextBox Patronymic;
        public System.Windows.Forms.TextBox Mail;
        public System.Windows.Forms.TextBox Address;
        public System.Windows.Forms.TextBox Phone;
        public System.Windows.Forms.TextBox Login;
        public System.Windows.Forms.TextBox Password;
    }
}