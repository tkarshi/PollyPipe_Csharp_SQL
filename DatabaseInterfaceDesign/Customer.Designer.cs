namespace DatabaseInterfaceDesign
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ConNumLabel = new System.Windows.Forms.Label();
            this.CusIDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ConNumTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.TypeCusIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.CusDetGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearTextBoxBtn = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.CusGridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CusDetGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(8, 90);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(138, 26);
            this.CustomerIDLabel.TabIndex = 0;
            this.CustomerIDLabel.Text = "Customer ID:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(17, 158);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 26);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // ConNumLabel
            // 
            this.ConNumLabel.AutoSize = true;
            this.ConNumLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConNumLabel.Location = new System.Drawing.Point(8, 217);
            this.ConNumLabel.Name = "ConNumLabel";
            this.ConNumLabel.Size = new System.Drawing.Size(171, 26);
            this.ConNumLabel.TabIndex = 0;
            this.ConNumLabel.Text = "Contact Number:";
            // 
            // CusIDTextBox
            // 
            this.CusIDTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CusIDTextBox.Location = new System.Drawing.Point(199, 82);
            this.CusIDTextBox.Name = "CusIDTextBox";
            this.CusIDTextBox.Size = new System.Drawing.Size(241, 34);
            this.CusIDTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NameTextBox.Location = new System.Drawing.Point(199, 150);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(241, 34);
            this.NameTextBox.TabIndex = 1;
            // 
            // ConNumTextBox
            // 
            this.ConNumTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ConNumTextBox.Location = new System.Drawing.Point(199, 209);
            this.ConNumTextBox.Name = "ConNumTextBox";
            this.ConNumTextBox.Size = new System.Drawing.Size(241, 34);
            this.ConNumTextBox.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(495, 46);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(115, 70);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(495, 128);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(115, 70);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(495, 217);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(120, 70);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // TypeCusIDLabel
            // 
            this.TypeCusIDLabel.AutoSize = true;
            this.TypeCusIDLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCusIDLabel.Location = new System.Drawing.Point(88, 58);
            this.TypeCusIDLabel.Name = "TypeCusIDLabel";
            this.TypeCusIDLabel.Size = new System.Drawing.Size(183, 26);
            this.TypeCusIDLabel.TabIndex = 0;
            this.TypeCusIDLabel.Text = "Type Customer ID";
            // 
            // CustomerIDSearchTextBox
            // 
            this.CustomerIDSearchTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CustomerIDSearchTextBox.Location = new System.Drawing.Point(84, 104);
            this.CustomerIDSearchTextBox.Name = "CustomerIDSearchTextBox";
            this.CustomerIDSearchTextBox.Size = new System.Drawing.Size(187, 34);
            this.CustomerIDSearchTextBox.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(297, 95);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(118, 45);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MainMenuBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBtn.Location = new System.Drawing.Point(12, 524);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(207, 95);
            this.MainMenuBtn.TabIndex = 2;
            this.MainMenuBtn.Text = "Main Menu ";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // CusDetGroupBox
            // 
            this.CusDetGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CusDetGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.CusDetGroupBox.Controls.Add(this.ClearTextBoxBtn);
            this.CusDetGroupBox.Controls.Add(this.DeleteBtn);
            this.CusDetGroupBox.Controls.Add(this.UpdateBtn);
            this.CusDetGroupBox.Controls.Add(this.SaveBtn);
            this.CusDetGroupBox.Controls.Add(this.ConNumTextBox);
            this.CusDetGroupBox.Controls.Add(this.NameTextBox);
            this.CusDetGroupBox.Controls.Add(this.CusIDTextBox);
            this.CusDetGroupBox.Controls.Add(this.ConNumLabel);
            this.CusDetGroupBox.Controls.Add(this.NameLabel);
            this.CusDetGroupBox.Controls.Add(this.CustomerIDLabel);
            this.CusDetGroupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusDetGroupBox.Location = new System.Drawing.Point(254, 31);
            this.CusDetGroupBox.Name = "CusDetGroupBox";
            this.CusDetGroupBox.Size = new System.Drawing.Size(679, 396);
            this.CusDetGroupBox.TabIndex = 5;
            this.CusDetGroupBox.TabStop = false;
            this.CusDetGroupBox.Text = "Customer Details";
            // 
            // ClearTextBoxBtn
            // 
            this.ClearTextBoxBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearTextBoxBtn.Location = new System.Drawing.Point(456, 303);
            this.ClearTextBoxBtn.Name = "ClearTextBoxBtn";
            this.ClearTextBoxBtn.Size = new System.Drawing.Size(202, 68);
            this.ClearTextBoxBtn.TabIndex = 2;
            this.ClearTextBoxBtn.Text = "Clear Text Box";
            this.ClearTextBoxBtn.UseVisualStyleBackColor = true;
            this.ClearTextBoxBtn.Click += new System.EventHandler(this.ClearTextBoxBtn_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchGroupBox.Controls.Add(this.TypeCusIDLabel);
            this.SearchGroupBox.Controls.Add(this.CustomerIDSearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchBtn);
            this.SearchGroupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(959, 47);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(421, 202);
            this.SearchGroupBox.TabIndex = 4;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Box";
            // 
            // CusGridview
            // 
            this.CusGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CusGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CusGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CusGridview.Location = new System.Drawing.Point(311, 469);
            this.CusGridview.Name = "CusGridview";
            this.CusGridview.RowHeadersWidth = 51;
            this.CusGridview.RowTemplate.Height = 24;
            this.CusGridview.Size = new System.Drawing.Size(558, 166);
            this.CusGridview.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(39, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1404, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CusGridview);
            this.Controls.Add(this.CusDetGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.MainMenuBtn);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.CusDetGroupBox.ResumeLayout(false);
            this.CusDetGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ConNumLabel;
        private System.Windows.Forms.TextBox CusIDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ConNumTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label TypeCusIDLabel;
        private System.Windows.Forms.TextBox CustomerIDSearchTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.GroupBox CusDetGroupBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Button ClearTextBoxBtn;
        private System.Windows.Forms.DataGridView CusGridview;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}