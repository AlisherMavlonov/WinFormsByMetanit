namespace WinFormsByMetanit
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginBox1 = new TextBox();
            passwordBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginButton1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            listBox1 = new ListBox();
            clientRepositoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // loginBox1
            // 
            loginBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBox1.Location = new Point(175, 131);
            loginBox1.MaxLength = 20;
            loginBox1.Multiline = true;
            loginBox1.Name = "loginBox1";
            loginBox1.PlaceholderText = "Введите логин";
            loginBox1.Size = new Size(220, 52);
            loginBox1.TabIndex = 0;
            // 
            // passwordBox2
            // 
            passwordBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordBox2.Location = new Point(175, 199);
            passwordBox2.MaxLength = 10;
            passwordBox2.Multiline = true;
            passwordBox2.Name = "passwordBox2";
            passwordBox2.PasswordChar = '*';
            passwordBox2.PlaceholderText = "Введите пороль";
            passwordBox2.Size = new Size(220, 52);
            passwordBox2.TabIndex = 1;
            passwordBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(68, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(101, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(225, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // loginButton1
            // 
            loginButton1.BackColor = SystemColors.InactiveCaptionText;
            loginButton1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton1.ForeColor = SystemColors.ButtonHighlight;
            loginButton1.Location = new Point(112, 287);
            loginButton1.Name = "loginButton1";
            loginButton1.Size = new Size(197, 76);
            loginButton1.TabIndex = 5;
            loginButton1.Text = "Вход";
            loginButton1.UseVisualStyleBackColor = false;
            loginButton1.Click += loginButton1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BeepOnError = true;
            maskedTextBox1.Location = new Point(177, 253);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(218, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(-1, 278);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(116, 64);
            listBox1.TabIndex = 7;
            // 
            // clientRepositoryBindingSource
            // 
            clientRepositoryBindingSource.DataSource = typeof(Dal.Repositories.ClientRepository);
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 394);
            Controls.Add(listBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(loginButton1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(passwordBox2);
            Controls.Add(loginBox1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientRepositoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginBox1;
        private TextBox passwordBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button loginButton1;
        private MaskedTextBox maskedTextBox1;
        private ListBox listBox1;
        private BindingSource clientRepositoryBindingSource;
    }
}