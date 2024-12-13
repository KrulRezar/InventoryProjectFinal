
namespace InventoryProjectFinal
{
    partial class MainForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            dgInventory = new DataGridView();
            txtProdName = new TextBox();
            cbProdCategory = new ComboBox();
            nudProdQuantity = new NumericUpDown();
            txtProdPrice = new TextBox();
            cbStatus = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            lbluserName = new Label();
            lbluserRole = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            btnExit = new Button();
            btnHome = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProdQuantity).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label3.Location = new Point(26, 10);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label4.Location = new Point(236, 10);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 4;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label5.Location = new Point(101, 10);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 5;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label6.Location = new Point(327, 10);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(636, 9);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 35);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(636, 50);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 35);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(560, 2);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnSave.Location = new Point(636, 230);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 35);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLoad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoad.BackColor = Color.White;
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnLoad.Location = new Point(637, 271);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(114, 35);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgInventory
            // 
            dgInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgInventory.BackgroundColor = SystemColors.Menu;
            dgInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInventory.Location = new Point(6, 6);
            dgInventory.Margin = new Padding(3, 2, 3, 2);
            dgInventory.Name = "dgInventory";
            dgInventory.ReadOnly = true;
            dgInventory.RowHeadersWidth = 62;
            dgInventory.Size = new Size(624, 309);
            dgInventory.TabIndex = 13;
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(26, 36);
            txtProdName.Margin = new Padding(3, 2, 3, 2);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(69, 31);
            txtProdName.TabIndex = 14;
            // 
            // cbProdCategory
            // 
            cbProdCategory.FormattingEnabled = true;
            cbProdCategory.Location = new Point(101, 36);
            cbProdCategory.Margin = new Padding(3, 2, 3, 2);
            cbProdCategory.Name = "cbProdCategory";
            cbProdCategory.Size = new Size(129, 33);
            cbProdCategory.TabIndex = 15;
            // 
            // nudProdQuantity
            // 
            nudProdQuantity.Location = new Point(236, 40);
            nudProdQuantity.Margin = new Padding(3, 2, 3, 2);
            nudProdQuantity.Name = "nudProdQuantity";
            nudProdQuantity.Size = new Size(80, 31);
            nudProdQuantity.TabIndex = 16;
            // 
            // txtProdPrice
            // 
            txtProdPrice.Location = new Point(322, 38);
            txtProdPrice.Margin = new Padding(3, 2, 3, 2);
            txtProdPrice.Name = "txtProdPrice";
            txtProdPrice.Size = new Size(107, 31);
            txtProdPrice.TabIndex = 17;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(435, 39);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(119, 33);
            cbStatus.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label1.Location = new Point(435, 10);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 19;
            label1.Text = "Status";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(560, 42);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 31);
            txtSearch.TabIndex = 20;
            // 
            // lbluserName
            // 
            lbluserName.AutoSize = true;
            lbluserName.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lbluserName.Location = new Point(3, 50);
            lbluserName.MaximumSize = new Size(150, 0);
            lbluserName.Name = "lbluserName";
            lbluserName.Size = new Size(104, 23);
            lbluserName.TabIndex = 1;
            lbluserName.Text = "User Name";
            // 
            // lbluserRole
            // 
            lbluserRole.AutoSize = true;
            lbluserRole.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lbluserRole.Location = new Point(3, 8);
            lbluserRole.MaximumSize = new Size(150, 0);
            lbluserRole.Name = "lbluserRole";
            lbluserRole.Size = new Size(94, 23);
            lbluserRole.TabIndex = 0;
            lbluserRole.Text = "User Role";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 52);
            panel1.TabIndex = 21;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(946, 36);
            label2.TabIndex = 1;
            label2.Text = "WAREHOUSE INVENTORY SYSTEM";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(lbluserRole);
            panel2.Controls.Add(lbluserName);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 52);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 410);
            panel2.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label8.Location = new Point(77, 305);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 5;
            label8.Text = "Exit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label7.Location = new Point(65, 265);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 4;
            label7.Text = "to Login";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.BackgroundImage = Properties.Resources.pawprint;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.Location = new Point(12, 300);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(47, 34);
            btnExit.TabIndex = 3;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ActiveCaption;
            btnHome.BackgroundImage = Properties.Resources.pawprint;
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9F);
            btnHome.Location = new Point(12, 260);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(47, 34);
            btnHome.TabIndex = 2;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(158, 52);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(788, 410);
            panel3.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 92);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(776, 318);
            panel5.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnUpdate);
            panel6.Controls.Add(dgInventory);
            panel6.Controls.Add(btnAdd);
            panel6.Controls.Add(btnSave);
            panel6.Controls.Add(btnLoad);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(776, 318);
            panel6.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(nudProdQuantity);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtProdPrice);
            panel4.Controls.Add(txtProdName);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cbStatus);
            panel4.Controls.Add(cbProdCategory);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(788, 92);
            panel4.TabIndex = 21;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 462);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "INVENTORY SYSTEM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProdQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnSave;
        private Button btnLoad;
        private DataGridView dgInventory;
        private TextBox txtProdName;
        private ComboBox cbProdCategory;
        private NumericUpDown nudProdQuantity;
        private TextBox txtProdPrice;
        private ComboBox cbStatus;
        private Label label1;
        private TextBox txtSearch;
        private Label lbluserName;
        private Label lbluserRole;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Button btnExit;
        private Button btnHome;
        private Label label8;
        private Label label7;
    }
}
