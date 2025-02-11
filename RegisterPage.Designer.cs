namespace PlakDükkanıYöneticiModülü
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            label1 = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtPasswordAgain = new TextBox();
            lblPassword = new Label();
            lblPasswordAgain = new Label();
            btnRegister = new Button();
            lblErrorMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(314, 51);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 0;
            label1.Text = "Register Page";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.Location = new Point(200, 99);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(104, 21);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "UserName:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(310, 93);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(199, 27);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(310, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(199, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(310, 185);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.PasswordChar = '*';
            txtPasswordAgain.Size = new Size(199, 27);
            txtPasswordAgain.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPassword.Location = new Point(200, 144);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(99, 21);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // lblPasswordAgain
            // 
            lblPasswordAgain.AutoSize = true;
            lblPasswordAgain.BackColor = Color.Transparent;
            lblPasswordAgain.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPasswordAgain.Location = new Point(156, 191);
            lblPasswordAgain.Name = "lblPasswordAgain";
            lblPasswordAgain.Size = new Size(153, 21);
            lblPasswordAgain.TabIndex = 6;
            lblPasswordAgain.Text = "Password Again:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRegister.Location = new Point(310, 233);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(199, 42);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.BackColor = Color.Transparent;
            lblErrorMessage.Location = new Point(314, 303);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(50, 20);
            lblErrorMessage.TabIndex = 8;
            lblErrorMessage.Text = "label2";
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnRegister);
            Controls.Add(lblPasswordAgain);
            Controls.Add(lblPassword);
            Controls.Add(txtPasswordAgain);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(label1);
            Name = "RegisterPage";
            Text = "RegisterPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUserName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtPasswordAgain;
        private Label lblPassword;
        private Label lblPasswordAgain;
        private Button btnRegister;
        private Label lblErrorMessage;
    }
}