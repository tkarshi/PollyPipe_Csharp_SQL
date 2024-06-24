namespace DatabaseInterfaceDesign
{
    partial class InstMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstMenuForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InstManDetBtn = new System.Windows.Forms.Button();
            this.InstallationBtn = new System.Windows.Forms.Button();
            this.InstDetMainMenuBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.InstManDetBtn);
            this.groupBox1.Controls.Add(this.InstallationBtn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(232, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation Menu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(688, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 245);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(137, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(295, 245);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // InstManDetBtn
            // 
            this.InstManDetBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstManDetBtn.Location = new System.Drawing.Point(168, 50);
            this.InstManDetBtn.Name = "InstManDetBtn";
            this.InstManDetBtn.Size = new System.Drawing.Size(235, 116);
            this.InstManDetBtn.TabIndex = 0;
            this.InstManDetBtn.Text = "Installation Management Details";
            this.InstManDetBtn.UseVisualStyleBackColor = true;
            this.InstManDetBtn.Click += new System.EventHandler(this.InstManDetBtn_Click);
            // 
            // InstallationBtn
            // 
            this.InstallationBtn.BackColor = System.Drawing.Color.White;
            this.InstallationBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallationBtn.Location = new System.Drawing.Point(734, 50);
            this.InstallationBtn.Name = "InstallationBtn";
            this.InstallationBtn.Size = new System.Drawing.Size(195, 116);
            this.InstallationBtn.TabIndex = 0;
            this.InstallationBtn.Text = "Installation";
            this.InstallationBtn.UseVisualStyleBackColor = false;
            this.InstallationBtn.Click += new System.EventHandler(this.InstallationBtn_Click);
            // 
            // InstDetMainMenuBtn
            // 
            this.InstDetMainMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InstDetMainMenuBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstDetMainMenuBtn.Location = new System.Drawing.Point(12, 569);
            this.InstDetMainMenuBtn.Name = "InstDetMainMenuBtn";
            this.InstDetMainMenuBtn.Size = new System.Drawing.Size(199, 100);
            this.InstDetMainMenuBtn.TabIndex = 2;
            this.InstDetMainMenuBtn.Text = "Main Menu";
            this.InstDetMainMenuBtn.UseVisualStyleBackColor = true;
            this.InstDetMainMenuBtn.Click += new System.EventHandler(this.InstDetMainMenuBtn_Click);
            // 
            // InstMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1422, 690);
            this.Controls.Add(this.InstDetMainMenuBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstMenuForm";
            this.Text = "Installation Menu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InstManDetBtn;
        private System.Windows.Forms.Button InstallationBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button InstDetMainMenuBtn;
    }
}