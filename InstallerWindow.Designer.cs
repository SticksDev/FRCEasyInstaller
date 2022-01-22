namespace FRCEasyInstaller
{
    partial class InstallerWindow
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
            this.logoRot = new System.Windows.Forms.PictureBox();
            this.spinControlCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskProgress = new System.Windows.Forms.ProgressBar();
            this.taskState = new System.Windows.Forms.Label();
            this.stopOp_bttn = new System.Windows.Forms.Button();
            this.DLoadState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoRot)).BeginInit();
            this.SuspendLayout();
            // 
            // logoRot
            // 
            this.logoRot.Image = global::FRCEasyInstaller.Properties.Resources.ProgLogo;
            this.logoRot.Location = new System.Drawing.Point(322, 126);
            this.logoRot.Name = "logoRot";
            this.logoRot.Size = new System.Drawing.Size(141, 130);
            this.logoRot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoRot.TabIndex = 0;
            this.logoRot.TabStop = false;
            // 
            // spinControlCheckBox
            // 
            this.spinControlCheckBox.AutoSize = true;
            this.spinControlCheckBox.Location = new System.Drawing.Point(527, 434);
            this.spinControlCheckBox.Name = "spinControlCheckBox";
            this.spinControlCheckBox.Size = new System.Drawing.Size(261, 17);
            this.spinControlCheckBox.TabIndex = 1;
            this.spinControlCheckBox.Text = "A checkbox that does nothing (DON\'T CLICK!!11)";
            this.spinControlCheckBox.UseVisualStyleBackColor = true;
            this.spinControlCheckBox.CheckedChanged += new System.EventHandler(this.spinControlCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Installing...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "This may take awhile depending on your internet connection.";
            // 
            // taskProgress
            // 
            this.taskProgress.Location = new System.Drawing.Point(146, 345);
            this.taskProgress.Name = "taskProgress";
            this.taskProgress.Size = new System.Drawing.Size(518, 41);
            this.taskProgress.TabIndex = 4;
            // 
            // taskState
            // 
            this.taskState.AutoSize = true;
            this.taskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskState.Location = new System.Drawing.Point(143, 325);
            this.taskState.Name = "taskState";
            this.taskState.Size = new System.Drawing.Size(102, 17);
            this.taskState.TabIndex = 5;
            this.taskState.Text = "Task: Waiting..";
            // 
            // stopOp_bttn
            // 
            this.stopOp_bttn.Location = new System.Drawing.Point(304, 410);
            this.stopOp_bttn.Name = "stopOp_bttn";
            this.stopOp_bttn.Size = new System.Drawing.Size(159, 28);
            this.stopOp_bttn.TabIndex = 6;
            this.stopOp_bttn.Text = "Cancel Install";
            this.stopOp_bttn.UseVisualStyleBackColor = true;
            this.stopOp_bttn.Click += new System.EventHandler(this.stopOp_bttn_Click);
            // 
            // DLoadState
            // 
            this.DLoadState.AutoSize = true;
            this.DLoadState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLoadState.Location = new System.Drawing.Point(143, 389);
            this.DLoadState.Name = "DLoadState";
            this.DLoadState.Size = new System.Drawing.Size(110, 13);
            this.DLoadState.TabIndex = 7;
            this.DLoadState.Text = "Waiting for download.";
            // 
            // InstallerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DLoadState);
            this.Controls.Add(this.stopOp_bttn);
            this.Controls.Add(this.taskState);
            this.Controls.Add(this.taskProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinControlCheckBox);
            this.Controls.Add(this.logoRot);
            this.Name = "InstallerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working - Please Wait.";
            this.Load += new System.EventHandler(this.InstallerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoRot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoRot;
        private System.Windows.Forms.CheckBox spinControlCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar taskProgress;
        private System.Windows.Forms.Label taskState;
        private System.Windows.Forms.Button stopOp_bttn;
        private System.Windows.Forms.Label DLoadState;
    }
}