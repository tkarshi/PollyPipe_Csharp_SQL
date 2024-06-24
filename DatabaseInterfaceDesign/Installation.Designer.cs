namespace DatabaseInterfaceDesign
{
    partial class InstallationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallationForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.installTyComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerIDComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.periodofstaffasignTextBox = new System.Windows.Forms.TextBox();
            this.installAddressTextBox = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.installationNameTextBox = new System.Windows.Forms.TextBox();
            this.installationIDTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InstIDLabel = new System.Windows.Forms.Label();
            this.InstGridview = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InstMenuBtn = new System.Windows.Forms.Button();
            this.InstMainMenuBtn = new System.Windows.Forms.Button();
            this.AddInstStaffRequireBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstGridview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.installTyComboBox);
            this.groupBox1.Controls.Add(this.CustomerIDComboBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.periodofstaffasignTextBox);
            this.groupBox1.Controls.Add(this.installAddressTextBox);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.installationNameTextBox);
            this.groupBox1.Controls.Add(this.installationIDTextBox);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.InstIDLabel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation";
            // 
            // installTyComboBox
            // 
            this.installTyComboBox.FormattingEnabled = true;
            this.installTyComboBox.Location = new System.Drawing.Point(295, 383);
            this.installTyComboBox.Name = "installTyComboBox";
            this.installTyComboBox.Size = new System.Drawing.Size(267, 34);
            this.installTyComboBox.TabIndex = 2;
            // 
            // CustomerIDComboBox
            // 
            this.CustomerIDComboBox.ForeColor = System.Drawing.Color.Black;
            this.CustomerIDComboBox.FormattingEnabled = true;
            this.CustomerIDComboBox.Location = new System.Drawing.Point(293, 327);
            this.CustomerIDComboBox.Name = "CustomerIDComboBox";
            this.CustomerIDComboBox.Size = new System.Drawing.Size(267, 34);
            this.CustomerIDComboBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(618, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear Text Box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(668, 242);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(119, 71);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // periodofstaffasignTextBox
            // 
            this.periodofstaffasignTextBox.ForeColor = System.Drawing.Color.Black;
            this.periodofstaffasignTextBox.Location = new System.Drawing.Point(293, 264);
            this.periodofstaffasignTextBox.Name = "periodofstaffasignTextBox";
            this.periodofstaffasignTextBox.Size = new System.Drawing.Size(269, 34);
            this.periodofstaffasignTextBox.TabIndex = 1;
            // 
            // installAddressTextBox
            // 
            this.installAddressTextBox.ForeColor = System.Drawing.Color.Black;
            this.installAddressTextBox.Location = new System.Drawing.Point(293, 200);
            this.installAddressTextBox.Name = "installAddressTextBox";
            this.installAddressTextBox.Size = new System.Drawing.Size(269, 34);
            this.installAddressTextBox.TabIndex = 1;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(668, 155);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(119, 71);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // installationNameTextBox
            // 
            this.installationNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.installationNameTextBox.Location = new System.Drawing.Point(293, 134);
            this.installationNameTextBox.Name = "installationNameTextBox";
            this.installationNameTextBox.Size = new System.Drawing.Size(269, 34);
            this.installationNameTextBox.TabIndex = 1;
            // 
            // installationIDTextBox
            // 
            this.installationIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.installationIDTextBox.Location = new System.Drawing.Point(293, 73);
            this.installationIDTextBox.Name = "installationIDTextBox";
            this.installationIDTextBox.Size = new System.Drawing.Size(269, 34);
            this.installationIDTextBox.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(668, 61);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(119, 71);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Period of Staff assign:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 26);
            this.label7.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Installation_Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer_ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Installation Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Installation Name:";
            // 
            // InstIDLabel
            // 
            this.InstIDLabel.AutoSize = true;
            this.InstIDLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstIDLabel.Location = new System.Drawing.Point(40, 73);
            this.InstIDLabel.Name = "InstIDLabel";
            this.InstIDLabel.Size = new System.Drawing.Size(151, 26);
            this.InstIDLabel.TabIndex = 1;
            this.InstIDLabel.Text = "Installation ID:";
            // 
            // InstGridview
            // 
            this.InstGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InstGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InstGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstGridview.Location = new System.Drawing.Point(41, 505);
            this.InstGridview.Name = "InstGridview";
            this.InstGridview.RowHeadersWidth = 51;
            this.InstGridview.RowTemplate.Height = 24;
            this.InstGridview.Size = new System.Drawing.Size(870, 226);
            this.InstGridview.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.SearchTextBox);
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(940, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.SearchTextBox.Location = new System.Drawing.Point(73, 95);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(269, 34);
            this.SearchTextBox.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(148, 155);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(119, 71);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Installation ID";
            // 
            // InstMenuBtn
            // 
            this.InstMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InstMenuBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstMenuBtn.Location = new System.Drawing.Point(1137, 605);
            this.InstMenuBtn.Name = "InstMenuBtn";
            this.InstMenuBtn.Size = new System.Drawing.Size(246, 83);
            this.InstMenuBtn.TabIndex = 1;
            this.InstMenuBtn.Text = "Installation Menu";
            this.InstMenuBtn.UseVisualStyleBackColor = true;
            this.InstMenuBtn.Click += new System.EventHandler(this.InstMenuBtn_Click);
            // 
            // InstMainMenuBtn
            // 
            this.InstMainMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InstMainMenuBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstMainMenuBtn.Location = new System.Drawing.Point(917, 609);
            this.InstMainMenuBtn.Name = "InstMainMenuBtn";
            this.InstMainMenuBtn.Size = new System.Drawing.Size(205, 74);
            this.InstMainMenuBtn.TabIndex = 1;
            this.InstMainMenuBtn.Text = "Main Menu";
            this.InstMainMenuBtn.UseVisualStyleBackColor = true;
            this.InstMainMenuBtn.Click += new System.EventHandler(this.InstMainMenuBtn_Click);
            // 
            // AddInstStaffRequireBtn
            // 
            this.AddInstStaffRequireBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInstStaffRequireBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddInstStaffRequireBtn.Location = new System.Drawing.Point(1013, 361);
            this.AddInstStaffRequireBtn.Name = "AddInstStaffRequireBtn";
            this.AddInstStaffRequireBtn.Size = new System.Drawing.Size(269, 103);
            this.AddInstStaffRequireBtn.TabIndex = 4;
            this.AddInstStaffRequireBtn.Text = "ADD Installation Staff Requirement";
            this.AddInstStaffRequireBtn.UseVisualStyleBackColor = true;
            this.AddInstStaffRequireBtn.Click += new System.EventHandler(this.InstStaffRequireBtn_Click);
            // 
            // InstallationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1395, 743);
            this.Controls.Add(this.AddInstStaffRequireBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InstMainMenuBtn);
            this.Controls.Add(this.InstMenuBtn);
            this.Controls.Add(this.InstGridview);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallationForm";
            this.Text = "Installation";
            this.Load += new System.EventHandler(this.InstallationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstGridview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InstIDLabel;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox periodofstaffasignTextBox;
        private System.Windows.Forms.TextBox installAddressTextBox;
        private System.Windows.Forms.TextBox installationNameTextBox;
        private System.Windows.Forms.DataGridView InstGridview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InstMenuBtn;
        private System.Windows.Forms.Button InstMainMenuBtn;
        private System.Windows.Forms.ComboBox CustomerIDComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox installTyComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddInstStaffRequireBtn;
        internal System.Windows.Forms.TextBox installationIDTextBox;
    }
}