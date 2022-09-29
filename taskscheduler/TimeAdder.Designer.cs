
namespace taskscheduler1 {
    partial class TimeAdder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonAddTime = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.hNumeric = new System.Windows.Forms.NumericUpDown();
            this.mNumeric = new System.Windows.Forms.NumericUpDown();
            this.mLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTime
            // 
            this.buttonAddTime.Location = new System.Drawing.Point(15, 64);
            this.buttonAddTime.Name = "buttonAddTime";
            this.buttonAddTime.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTime.TabIndex = 0;
            this.buttonAddTime.Text = "Add time";
            this.buttonAddTime.UseVisualStyleBackColor = true;
            this.buttonAddTime.Click += new System.EventHandler(this.buttonAddTime_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(57, 13);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "New time :";
            // 
            // hNumeric
            // 
            this.hNumeric.Location = new System.Drawing.Point(15, 38);
            this.hNumeric.Name = "hNumeric";
            this.hNumeric.Size = new System.Drawing.Size(40, 20);
            this.hNumeric.TabIndex = 2;
            // 
            // mNumeric
            // 
            this.mNumeric.Location = new System.Drawing.Point(78, 38);
            this.mNumeric.Name = "mNumeric";
            this.mNumeric.Size = new System.Drawing.Size(40, 20);
            this.mNumeric.TabIndex = 3;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(124, 45);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(15, 13);
            this.mLabel.TabIndex = 4;
            this.mLabel.Text = "m";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(59, 45);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(13, 13);
            this.hLabel.TabIndex = 5;
            this.hLabel.Text = "h";
            // 
            // TimeAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 96);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.mNumeric);
            this.Controls.Add(this.hNumeric);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonAddTime);
            this.Name = "TimeAdder";
            this.Text = "Time Adder";
            ((System.ComponentModel.ISupportInitialize)(this.hNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.NumericUpDown hNumeric;
        private System.Windows.Forms.NumericUpDown mNumeric;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label hLabel;
    }
}