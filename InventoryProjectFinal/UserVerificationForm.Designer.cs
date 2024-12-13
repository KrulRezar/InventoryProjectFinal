namespace InventoryProjectFinal
{
    partial class UserVerificationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cbAffiliation = new ComboBox();
            btnLogin = new Button();
            panel1 = new Panel();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(320, 123);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(320, 185);
            label2.Name = "label2";
            label2.Size = new Size(104, 27);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(320, 59);
            label3.Name = "label3";
            label3.Size = new Size(111, 27);
            label3.TabIndex = 2;
            label3.Text = "Affiliation";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top;
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Times New Roman", 8F);
            txtUsername.Location = new Point(320, 151);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 26);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.BackColor = SystemColors.ControlLightLight;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Times New Roman", 8F);
            txtPassword.Location = new Point(320, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 26);
            txtPassword.TabIndex = 4;
            // 
            // cbAffiliation
            // 
            cbAffiliation.Anchor = AnchorStyles.Top;
            cbAffiliation.BackColor = SystemColors.ControlLightLight;
            cbAffiliation.Cursor = Cursors.Hand;
            cbAffiliation.FlatStyle = FlatStyle.Popup;
            cbAffiliation.Font = new Font("Times New Roman", 8F);
            cbAffiliation.FormattingEnabled = true;
            cbAffiliation.Location = new Point(320, 87);
            cbAffiliation.Name = "cbAffiliation";
            cbAffiliation.Size = new Size(150, 27);
            cbAffiliation.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.AutoSize = true;
            btnLogin.BackColor = SystemColors.ControlLightLight;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(342, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 37);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 47);
            panel1.TabIndex = 7;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = SystemColors.GradientActiveCaption;
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.FlatStyle = FlatStyle.Popup;
            lblWelcome.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(800, 47);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Warehouse System\r\n";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserVerificationForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 403);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(cbAffiliation);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "UserVerificationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KingKong ";
           
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cbAffiliation;
        private Button btnLogin;
        private Panel panel1;
        private Label lblWelcome;
    }
}