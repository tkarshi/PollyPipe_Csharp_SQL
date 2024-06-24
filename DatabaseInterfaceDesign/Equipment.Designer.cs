namespace DatabaseInterfaceDesign
{
    partial class EquipmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EqTyIDComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EqNameTextBox = new System.Windows.Forms.TextBox();
            this.EqIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EqIDSearchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.EqMenuBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.ADDEqReqBtn = new System.Windows.Forms.Button();
            this.EqGridView = new System.Windows.Forms.DataGridView();
            this.InstallationGridview = new System.Windows.Forms.DataGridView();
            this.viewInstBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EqGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallationGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipment ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.EqGridView);
            this.groupBox1.Controls.Add(this.EqTyIDComboBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.EqNameTextBox);
            this.groupBox1.Controls.Add(this.EqIDTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 583);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment Details";
            // 
            // EqTyIDComboBox
            // 
            this.EqTyIDComboBox.FormattingEnabled = true;
            this.EqTyIDComboBox.Location = new System.Drawing.Point(257, 160);
            this.EqTyIDComboBox.Name = "EqTyIDComboBox";
            this.EqTyIDComboBox.Size = new System.Drawing.Size(214, 33);
            this.EqTyIDComboBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(257, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear Text Box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(503, 187);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(127, 58);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(503, 110);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(127, 58);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(503, 37);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(127, 58);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EqNameTextBox
            // 
            this.EqNameTextBox.Location = new System.Drawing.Point(257, 107);
            this.EqNameTextBox.Name = "EqNameTextBox";
            this.EqNameTextBox.Size = new System.Drawing.Size(214, 34);
            this.EqNameTextBox.TabIndex = 3;
            // 
            // EqIDTextBox
            // 
            this.EqIDTextBox.Location = new System.Drawing.Point(257, 59);
            this.EqIDTextBox.Name = "EqIDTextBox";
            this.EqIDTextBox.Size = new System.Drawing.Size(214, 34);
            this.EqIDTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Equipment Type ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Equipment Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.EqIDSearchBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SearchTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(754, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 194);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // EqIDSearchBtn
            // 
            this.EqIDSearchBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqIDSearchBtn.Location = new System.Drawing.Point(319, 99);
            this.EqIDSearchBtn.Name = "EqIDSearchBtn";
            this.EqIDSearchBtn.Size = new System.Drawing.Size(127, 58);
            this.EqIDSearchBtn.TabIndex = 0;
            this.EqIDSearchBtn.Text = "Search";
            this.EqIDSearchBtn.UseVisualStyleBackColor = true;
            this.EqIDSearchBtn.Click += new System.EventHandler(this.EqIDSearchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Type Equipment ID";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(81, 85);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(214, 34);
            this.SearchTextBox.TabIndex = 3;
            // 
            // EqMenuBtn
            // 
            this.EqMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EqMenuBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqMenuBtn.Location = new System.Drawing.Point(835, 583);
            this.EqMenuBtn.Name = "EqMenuBtn";
            this.EqMenuBtn.Size = new System.Drawing.Size(199, 75);
            this.EqMenuBtn.TabIndex = 0;
            this.EqMenuBtn.Text = "Equipment Menu";
            this.EqMenuBtn.UseVisualStyleBackColor = true;
            this.EqMenuBtn.Click += new System.EventHandler(this.EqMenuBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBtn.Location = new System.Drawing.Point(1276, 583);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(169, 75);
            this.MainMenuBtn.TabIndex = 0;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // ADDEqReqBtn
            // 
            this.ADDEqReqBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDEqReqBtn.Location = new System.Drawing.Point(1261, 91);
            this.ADDEqReqBtn.Name = "ADDEqReqBtn";
            this.ADDEqReqBtn.Size = new System.Drawing.Size(248, 83);
            this.ADDEqReqBtn.TabIndex = 5;
            this.ADDEqReqBtn.Text = "ADD Equipment Requirement";
            this.ADDEqReqBtn.UseVisualStyleBackColor = true;
            this.ADDEqReqBtn.Click += new System.EventHandler(this.ADDEqReqBtn_Click);
            // 
            // EqGridView
            // 
            this.EqGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EqGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EqGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EqGridView.Location = new System.Drawing.Point(34, 320);
            this.EqGridView.Name = "EqGridView";
            this.EqGridView.RowHeadersWidth = 51;
            this.EqGridView.RowTemplate.Height = 24;
            this.EqGridView.Size = new System.Drawing.Size(608, 193);
            this.EqGridView.TabIndex = 5;
            // 
            // InstallationGridview
            // 
            this.InstallationGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InstallationGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InstallationGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstallationGridview.Location = new System.Drawing.Point(729, 340);
            this.InstallationGridview.Name = "InstallationGridview";
            this.InstallationGridview.RowHeadersWidth = 51;
            this.InstallationGridview.RowTemplate.Height = 24;
            this.InstallationGridview.Size = new System.Drawing.Size(826, 228);
            this.InstallationGridview.TabIndex = 6;
            // 
            // viewInstBtn
            // 
            this.viewInstBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInstBtn.Location = new System.Drawing.Point(729, 259);
            this.viewInstBtn.Name = "viewInstBtn";
            this.viewInstBtn.Size = new System.Drawing.Size(247, 58);
            this.viewInstBtn.TabIndex = 0;
            this.viewInstBtn.Text = "View Installation";
            this.viewInstBtn.UseVisualStyleBackColor = true;
            this.viewInstBtn.Click += new System.EventHandler(this.viewInstBtn_Click);
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1584, 670);
            this.Controls.Add(this.InstallationGridview);
            this.Controls.Add(this.ADDEqReqBtn);
            this.Controls.Add(this.viewInstBtn);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.EqMenuBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EquipmentForm";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.EquipmentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EqGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallationGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox EqNameTextBox;
        private System.Windows.Forms.TextBox EqIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EqIDSearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button EqMenuBtn;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.ComboBox EqTyIDComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ADDEqReqBtn;
        private System.Windows.Forms.DataGridView EqGridView;
        private System.Windows.Forms.DataGridView InstallationGridview;
        private System.Windows.Forms.Button viewInstBtn;
    }
}