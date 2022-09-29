
namespace taskscheduler1 {
    partial class DateEditor {
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
            this.editDateButton = new System.Windows.Forms.Button();
            this.yLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.mNumeric = new System.Windows.Forms.NumericUpDown();
            this.yNumeric = new System.Windows.Forms.NumericUpDown();
            this.dNumeric = new System.Windows.Forms.NumericUpDown();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.deleteDateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // editDateButton
            // 
            this.editDateButton.Location = new System.Drawing.Point(12, 69);
            this.editDateButton.Name = "editDateButton";
            this.editDateButton.Size = new System.Drawing.Size(75, 23);
            this.editDateButton.TabIndex = 22;
            this.editDateButton.Text = "Edit date";
            this.editDateButton.UseVisualStyleBackColor = true;
            this.editDateButton.Click += new System.EventHandler(this.editDateButton_Click);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(191, 45);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(38, 13);
            this.yLabel.TabIndex = 21;
            this.yLabel.Text = "Year : ";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(94, 45);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(46, 13);
            this.mLabel.TabIndex = 20;
            this.mLabel.Text = "Month : ";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(12, 45);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(32, 13);
            this.dLabel.TabIndex = 19;
            this.dLabel.Text = "Day :";
            // 
            // mNumeric
            // 
            this.mNumeric.Location = new System.Drawing.Point(146, 43);
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
            this.mNumeric.TabIndex = 18;
            this.mNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yNumeric
            // 
            this.yNumeric.Location = new System.Drawing.Point(232, 43);
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
            this.yNumeric.TabIndex = 17;
            this.yNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // dNumeric
            // 
            this.dNumeric.Location = new System.Drawing.Point(49, 43);
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
            this.dNumeric.TabIndex = 16;
            this.dNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(15, 12);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(121, 21);
            this.dateComboBox.TabIndex = 23;
            this.dateComboBox.SelectedValueChanged += new System.EventHandler(this.dayComboBox_SelectedValueChanged);
            // 
            // deleteDateButton
            // 
            this.deleteDateButton.Location = new System.Drawing.Point(111, 69);
            this.deleteDateButton.Name = "deleteDateButton";
            this.deleteDateButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDateButton.TabIndex = 24;
            this.deleteDateButton.Text = "Delete date";
            this.deleteDateButton.UseVisualStyleBackColor = true;
            this.deleteDateButton.Click += new System.EventHandler(this.deleteDateButton_Click);
            // 
            // DateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 104);
            this.Controls.Add(this.deleteDateButton);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.editDateButton);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.mNumeric);
            this.Controls.Add(this.yNumeric);
            this.Controls.Add(this.dNumeric);
            this.Name = "DateEditor";
            this.Text = "Date Editor";
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editDateButton;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.NumericUpDown mNumeric;
        private System.Windows.Forms.NumericUpDown yNumeric;
        private System.Windows.Forms.NumericUpDown dNumeric;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.Button deleteDateButton;
    }
}