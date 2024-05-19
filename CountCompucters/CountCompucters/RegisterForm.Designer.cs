namespace CountCompucters
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            TextAuth = new Label();
            panelLoginAndPass = new Panel();
            panelLoginAndPassField = new Panel();
            RegisterLable = new Label();
            buttonRegister = new Button();
            textLogin = new TextBox();
            textPass = new TextBox();
            pictureBoxLogin = new PictureBox();
            pictureBoxPass = new PictureBox();
            panelTextAuth = new Panel();
            panelLoginAndPass.SuspendLayout();
            panelLoginAndPassField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPass).BeginInit();
            panelTextAuth.SuspendLayout();
            SuspendLayout();
            // 
            // TextAuth
            // 
            TextAuth.Dock = DockStyle.Fill;
            TextAuth.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextAuth.Location = new Point(0, 0);
            TextAuth.Name = "TextAuth";
            TextAuth.Size = new Size(508, 100);
            TextAuth.TabIndex = 0;
            TextAuth.Text = "Регистрация";
            TextAuth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLoginAndPass
            // 
            panelLoginAndPass.Controls.Add(panelLoginAndPassField);
            panelLoginAndPass.Dock = DockStyle.Fill;
            panelLoginAndPass.Location = new Point(0, 100);
            panelLoginAndPass.Name = "panelLoginAndPass";
            panelLoginAndPass.Size = new Size(508, 400);
            panelLoginAndPass.TabIndex = 4;
            // 
            // panelLoginAndPassField
            // 
            panelLoginAndPassField.AutoSize = true;
            panelLoginAndPassField.Controls.Add(RegisterLable);
            panelLoginAndPassField.Controls.Add(buttonRegister);
            panelLoginAndPassField.Controls.Add(textLogin);
            panelLoginAndPassField.Controls.Add(textPass);
            panelLoginAndPassField.Controls.Add(pictureBoxLogin);
            panelLoginAndPassField.Controls.Add(pictureBoxPass);
            panelLoginAndPassField.Location = new Point(47, 35);
            panelLoginAndPassField.Name = "panelLoginAndPassField";
            panelLoginAndPassField.Size = new Size(373, 308);
            panelLoginAndPassField.TabIndex = 4;
            // 
            // RegisterLable
            // 
            RegisterLable.AutoSize = true;
            RegisterLable.Cursor = Cursors.Hand;
            RegisterLable.Font = new Font("Segoe UI", 12F);
            RegisterLable.Location = new Point(165, 251);
            RegisterLable.Name = "RegisterLable";
            RegisterLable.Size = new Size(53, 21);
            RegisterLable.TabIndex = 6;
            RegisterLable.Text = "Войти";
            RegisterLable.Click += RegisterLable_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderColor = Color.Silver;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonRegister.Location = new Point(90, 197);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(216, 41);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Зарегистрироваться ";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textLogin
            // 
            textLogin.BackColor = SystemColors.ScrollBar;
            textLogin.BorderStyle = BorderStyle.FixedSingle;
            textLogin.Cursor = Cursors.Hand;
            textLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textLogin.Location = new Point(56, 9);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(287, 33);
            textLogin.TabIndex = 1;
            textLogin.TextAlign = HorizontalAlignment.Center;
            textLogin.TextChanged += textLogin_TextChanged;
            textLogin.Enter += textLogin_Enter;
            textLogin.Leave += textLogin_Leave;
            // 
            // textPass
            // 
            textPass.BackColor = SystemColors.ScrollBar;
            textPass.BorderStyle = BorderStyle.FixedSingle;
            textPass.Cursor = Cursors.Hand;
            textPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textPass.Location = new Point(56, 79);
            textPass.Name = "textPass";
            textPass.Size = new Size(287, 33);
            textPass.TabIndex = 3;
            textPass.TextAlign = HorizontalAlignment.Center;
            textPass.UseSystemPasswordChar = true;
            textPass.Enter += textPass_Enter;
            textPass.Leave += textPass_Leave;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = (Image)resources.GetObject("pictureBoxLogin.Image");
            pictureBoxLogin.Location = new Point(1, 1);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(50, 50);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 0;
            pictureBoxLogin.TabStop = false;
            // 
            // pictureBoxPass
            // 
            pictureBoxPass.Image = (Image)resources.GetObject("pictureBoxPass.Image");
            pictureBoxPass.Location = new Point(1, 71);
            pictureBoxPass.Name = "pictureBoxPass";
            pictureBoxPass.Size = new Size(50, 50);
            pictureBoxPass.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPass.TabIndex = 2;
            pictureBoxPass.TabStop = false;
            // 
            // panelTextAuth
            // 
            panelTextAuth.Controls.Add(TextAuth);
            panelTextAuth.Dock = DockStyle.Top;
            panelTextAuth.Location = new Point(0, 0);
            panelTextAuth.Name = "panelTextAuth";
            panelTextAuth.Size = new Size(508, 100);
            panelTextAuth.TabIndex = 3;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 500);
            Controls.Add(panelLoginAndPass);
            Controls.Add(panelTextAuth);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            FormClosed += RegisterForm_FormClosed;
            panelLoginAndPass.ResumeLayout(false);
            panelLoginAndPass.PerformLayout();
            panelLoginAndPassField.ResumeLayout(false);
            panelLoginAndPassField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPass).EndInit();
            panelTextAuth.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label TextAuth;
        private Panel panelLoginAndPass;
        private Panel panelLoginAndPassField;
        private Button buttonRegister;
        private TextBox textLogin;
        private TextBox textPass;
        private PictureBox pictureBoxLogin;
        private PictureBox pictureBoxPass;
        private Panel panelTextAuth;
        private Label RegisterLable;
    }
}