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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerWindow));
            this.logoRot = new System.Windows.Forms.PictureBox();
            this.spinControlCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskProgress = new System.Windows.Forms.ProgressBar();
            this.taskState = new System.Windows.Forms.Label();
            this.stopOp_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoRot)).BeginInit();
            this.SuspendLayout();
            // 
            // logoRot
            // 
            this.logoRot.Image = ((System.Drawing.Image)(resources.GetObject("logoRot.Image")));
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
            this.spinControlCheckBox.Location = new System.Drawing.Point(658, 421);
            this.spinControlCheckBox.Name = "spinControlCheckBox";
            this.spinControlCheckBox.Size = new System.Drawing.Size(121, 17);
            this.spinControlCheckBox.TabIndex = 1;
            this.spinControlCheckBox.Text = "Stop the SPEEEN :(";
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
            this.stopOp_bttn.Location = new System.Drawing.Point(322, 397);
            this.stopOp_bttn.Name = "stopOp_bttn";
            this.stopOp_bttn.Size = new System.Drawing.Size(159, 41);
            this.stopOp_bttn.TabIndex = 6;
            this.stopOp_bttn.Text = "Cancel Install";
            this.stopOp_bttn.UseVisualStyleBackColor = true;
            this.stopOp_bttn.Click += new System.EventHandler(this.stopOp_bttn_Click);
            // 
            // InstallerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopOp_bttn);
            this.Controls.Add(this.taskState);
            this.Controls.Add(this.taskProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinControlCheckBox);
            this.Controls.Add(this.logoRot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working - Please Wait.";
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
    }
}