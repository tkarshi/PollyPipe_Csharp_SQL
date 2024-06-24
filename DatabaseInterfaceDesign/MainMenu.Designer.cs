namespace DatabaseInterfaceDesign
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.MainMenuGrBox = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InstMenuBtn = new System.Windows.Forms.Button();
            this.EqMenuBtn = new System.Windows.Forms.Button();
            this.StaffMenuBtn = new System.Windows.Forms.Button();
            this.CustomerMenuBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.MainMenuGrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuGrBox
            // 
            this.MainMenuGrBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainMenuGrBox.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuGrBox.Controls.Add(this.pictureBox4);
            this.MainMenuGrBox.Controls.Add(this.pictureBox3);
            this.MainMenuGrBox.Controls.Add(this.pictureBox2);
            this.MainMenuGrBox.Controls.Add(this.pictureBox1);
            this.MainMenuGrBox.Controls.Add(this.InstMenuBtn);
            this.MainMenuGrBox.Controls.Add(this.EqMenuBtn);
            this.MainMenuGrBox.Controls.Add(this.StaffMenuBtn);
            this.MainMenuGrBox.Controls.Add(this.CustomerMenuBtn);
            this.MainMenuGrBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuGrBox.Location = new System.Drawing.Point(157, 37);
            this.MainMenuGrBox.Name = "MainMenuGrBox";
            this.MainMenuGrBox.Size = new System.Drawing.Size(1159, 490);
            this.MainMenuGrBox.TabIndex = 0;
            this.MainMenuGrBox.TabStop = false;
            this.MainMenuGrBox.Text = "Main Menu";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(871, 192);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(262, 229);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(567, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 229);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(263, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // InstMenuBtn
            // 
            this.InstMenuBtn.Location = new System.Drawing.Point(318, 89);
            this.InstMenuBtn.Name = "InstMenuBtn";
            this.InstMenuBtn.Size = new System.Drawing.Size(175, 80);
            this.InstMenuBtn.TabIndex = 0;
            this.InstMenuBtn.Text = "Installation ";
            this.InstMenuBtn.UseVisualStyleBackColor = true;
            this.InstMenuBtn.Click += new System.EventHandler(this.InstMenuBtn_Click);
            // 
            // EqMenuBtn
            // 
            this.EqMenuBtn.Location = new System.Drawing.Point(625, 89);
            this.EqMenuBtn.Name = "EqMenuBtn";
            this.EqMenuBtn.Size = new System.Drawing.Size(160, 80);
            this.EqMenuBtn.TabIndex = 0;
            this.EqMenuBtn.Text = "Equipment ";
            this.EqMenuBtn.UseVisualStyleBackColor = true;
            this.EqMenuBtn.Click += new System.EventHandler(this.EqMenuBtn_Click);
            // 
            // StaffMenuBtn
            // 
            this.StaffMenuBtn.Location = new System.Drawing.Point(927, 89);
            this.StaffMenuBtn.Name = "StaffMenuBtn";
            this.StaffMenuBtn.Size = new System.Drawing.Size(158, 80);
            this.StaffMenuBtn.TabIndex = 0;
            this.StaffMenuBtn.Text = "Staff ";
            this.StaffMenuBtn.UseVisualStyleBackColor = true;
            this.StaffMenuBtn.Click += new System.EventHandler(this.StaffMenuBtn_Click);
            // 
            // CustomerMenuBtn
            // 
            this.CustomerMenuBtn.Location = new System.Drawing.Point(71, 89);
            this.CustomerMenuBtn.Name = "CustomerMenuBtn";
            this.CustomerMenuBtn.Size = new System.Drawing.Size(148, 83);
            this.CustomerMenuBtn.TabIndex = 0;
            this.CustomerMenuBtn.Text = "Customer ";
            this.CustomerMenuBtn.UseVisualStyleBackColor = true;
            this.CustomerMenuBtn.Click += new System.EventHandler(this.CustomerMenuBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreviousBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousBtn.Location = new System.Drawing.Point(12, 575);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(208, 82);
            this.PreviousBtn.TabIndex = 1;
            this.PreviousBtn.Text = "PREVIOUS";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1413, 682);
            this.Controls.Add(this.PreviousBtn);
            this.Controls.Add(this.MainMenuGrBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.MainMenuGrBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainMenuGrBox;
        private System.Windows.Forms.Button InstMenuBtn;
        private System.Windows.Forms.Button EqMenuBtn;
        private System.Windows.Forms.Button StaffMenuBtn;
        private System.Windows.Forms.Button CustomerMenuBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}