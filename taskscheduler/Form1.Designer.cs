
namespace taskscheduler1 {
    partial class TimeEditor {
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
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.hNumeric = new System.Windows.Forms.NumericUpDown();
            this.mNumeric = new System.Windows.Forms.NumericUpDown();
            this.mLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(14, 65);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(99, 65);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(52, 12);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(121, 21);
            this.timeComboBox.TabIndex = 2;
            this.timeComboBox.SelectedValueChanged += new System.EventHandler(this.timeComboBox_SelectedValueChanged);
            // 
            // hNumeric
            // 
            this.hNumeric.Location = new System.Drawing.Point(14, 39);
            this.hNumeric.Name = "hNumeric";
            this.hNumeric.Size = new System.Drawing.Size(33, 20);
            this.hNumeric.TabIndex = 3;
            // 
            // mNumeric
            // 
            this.mNumeric.Location = new System.Drawing.Point(77, 39);
            this.mNumeric.Name = "mNumeric";
            this.mNumeric.Size = new System.Drawing.Size(33, 20);
            this.mNumeric.TabIndex = 4;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(116, 46);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(15, 13);
            this.mLabel.TabIndex = 5;
            this.mLabel.Text = "m";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(53, 46);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(13, 13);
            this.hLabel.TabIndex = 6;
            this.hLabel.Text = "h";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(10, 15);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(36, 13);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Time :";
            // 
            // TimeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 95);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.mNumeric);
            this.Controls.Add(this.hNumeric);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Name = "TimeEditor";
            this.Text = "Timestamp Editor";
            ((System.ComponentModel.ISupportInitialize)(this.hNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.NumericUpDown hNumeric;
        private System.Windows.Forms.NumericUpDown mNumeric;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}