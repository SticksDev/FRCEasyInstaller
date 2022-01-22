namespace FRCEasyInstaller
{
    partial class FRCEasyInstaller
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.versionSelectBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.InstallToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(648, 124);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thank you for dowloading FRCEasyInstaller.\r\n\r\nPlease choose what you\'d like to in" +
    "stall.\r\nNote: Installing both at the same time is not possible.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created By Team 6877 - Version 1.0.1 | Game Version: 2022";
            // 
            // versionSelectBox
            // 
            this.versionSelectBox.AllowDrop = true;
            this.versionSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionSelectBox.FormattingEnabled = true;
            this.versionSelectBox.Items.AddRange(new object[] {
            "Game Tools (2022)",
            "wpilib (2022)"});
            this.versionSelectBox.Location = new System.Drawing.Point(272, 259);
            this.versionSelectBox.Name = "versionSelectBox";
            this.versionSelectBox.Size = new System.Drawing.Size(203, 21);
            this.versionSelectBox.TabIndex = 3;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(272, 319);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(203, 56);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Install Tools!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // InstallToolTip
            // 
            this.InstallToolTip.AutoPopDelay = 500;
            this.InstallToolTip.InitialDelay = 500;
            this.InstallToolTip.ReshowDelay = 100;
            this.InstallToolTip.ToolTipTitle = "test123";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FRCEasyInstaller.Properties.Resources.ProgLogo;
            this.pictureBox1.Location = new System.Drawing.Point(149, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FRCEasyInstaller.Properties.Resources.ProgLogo;
            this.pictureBox2.Location = new System.Drawing.Point(548, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // FRCEasyInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.versionSelectBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRCEasyInstaller";
            this.Text = "FIRST/FRC - Easy Installer";
            this.Load += new System.EventHandler(this.FRCEasyInstaller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox versionSelectBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ToolTip InstallToolTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

