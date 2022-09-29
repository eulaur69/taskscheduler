
namespace taskscheduler1 {
    partial class DateAdder {
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
            this.addDateButton = new System.Windows.Forms.Button();
            this.yLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.mNumeric = new System.Windows.Forms.NumericUpDown();
            this.yNumeric = new System.Windows.Forms.NumericUpDown();
            this.dNumeric = new System.Windows.Forms.NumericUpDown();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // addDateButton
            // 
            this.addDateButton.Location = new System.Drawing.Point(15, 55);
            this.addDateButton.Name = "addDateButton";
            this.addDateButton.Size = new System.Drawing.Size(75, 23);
            this.addDateButton.TabIndex = 15;
            this.addDateButton.Text = "Add date";
            this.addDateButton.UseVisualStyleBackColor = true;
            this.addDateButton.Click += new System.EventHandler(this.addDateButton_Click);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(191, 31);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(38, 13);
            this.yLabel.TabIndex = 14;
            this.yLabel.Text = "Year : ";
            this.yLabel.Click += new System.EventHandler(this.yLabel_Click);
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(94, 31);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(46, 13);
            this.mLabel.TabIndex = 13;
            this.mLabel.Text = "Month : ";
            this.mLabel.Click += new System.EventHandler(this.mLabel_Click);
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(12, 31);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(32, 13);
            this.dLabel.TabIndex = 12;
            this.dLabel.Text = "Day :";
            this.dLabel.Click += new System.EventHandler(this.dLabel_Click);
            // 
            // mNumeric
            // 
            this.mNumeric.Location = new System.Drawing.Point(146, 29);
            this.mNumeric.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumeric.Name = "mNumeric";
            this.mNumeric.Size = new System.Drawing.Size(39, 20);
            this.mNumeric.TabIndex = 11;
            this.mNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumeric.ValueChanged += new System.EventHandler(this.mNumeric_ValueChanged);
            // 
            // yNumeric
            // 
            this.yNumeric.Location = new System.Drawing.Point(232, 29);
            this.yNumeric.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.yNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yNumeric.Name = "yNumeric";
            this.yNumeric.Size = new System.Drawing.Size(59, 20);
            this.yNumeric.TabIndex = 10;
            this.yNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yNumeric.ValueChanged += new System.EventHandler(this.yNumeric_ValueChanged);
            // 
            // dNumeric
            // 
            this.dNumeric.Location = new System.Drawing.Point(49, 29);
            this.dNumeric.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dNumeric.Name = "dNumeric";
            this.dNumeric.Size = new System.Drawing.Size(39, 20);
            this.dNumeric.TabIndex = 9;
            this.dNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dNumeric.ValueChanged += new System.EventHandler(this.dNumeric_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 13);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Date : ";
            // 
            // DateAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 86);
            this.Controls.Add(this.addDateButton);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.mNumeric);
            this.Controls.Add(this.yNumeric);
            this.Controls.Add(this.dNumeric);
            this.Controls.Add(this.dateLabel);
            this.Name = "DateAdder";
            this.Text = "Add new date";
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDateButton;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.NumericUpDown mNumeric;
        private System.Windows.Forms.NumericUpDown yNumeric;
        private System.Windows.Forms.NumericUpDown dNumeric;
        private System.Windows.Forms.Label dateLabel;
    }
}