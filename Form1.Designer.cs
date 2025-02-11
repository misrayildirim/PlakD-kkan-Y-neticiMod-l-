namespace PlakDükkanıYöneticiModülü
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            linklblRegister = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(221, 32);
            label1.Name = "label1";
            label1.Size = new Size(384, 46);
            label1.TabIndex = 0;
            label1.Text = "Yönetici Giris Sayfası";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightGray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.Location = new Point(308, 283);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(233, 40);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(308, 134);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(136, 24);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Kullanıcı Adı";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPassword.Location = new Point(308, 201);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 24);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(308, 171);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(308, 238);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(233, 27);
            txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(372, 326);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 6;
            label2.Text = "----------------";
            // 
            // linklblRegister
            // 
            linklblRegister.AutoSize = true;
            linklblRegister.BackColor = Color.Transparent;
            linklblRegister.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            linklblRegister.LinkColor = Color.Gray;
            linklblRegister.Location = new Point(367, 346);
            linklblRegister.Name = "linklblRegister";
            linklblRegister.Size = new Size(110, 21);
            linklblRegister.TabIndex = 7;
            linklblRegister.TabStop = true;
            linklblRegister.Text = "Register Now";
            linklblRegister.LinkClicked += linklblRegister_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(834, 502);
            Controls.Add(linklblRegister);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private LinkLabel linklblRegister;
    }
}
