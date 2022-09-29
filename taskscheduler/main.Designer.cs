
namespace taskscheduler1 {
    partial class main {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tasksDataGridView = new System.Windows.Forms.DataGridView();
            this.task = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTimestampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTimestampsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.revertButton = new System.Windows.Forms.Button();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksDataGridView
            // 
            this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.task,
            this.time,
            this.note,
            this.done,
            this.delete});
            this.tasksDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tasksDataGridView.Location = new System.Drawing.Point(15, 61);
            this.tasksDataGridView.Name = "tasksDataGridView";
            this.tasksDataGridView.Size = new System.Drawing.Size(543, 194);
            this.tasksDataGridView.TabIndex = 3;
            this.tasksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tasksDataGridView_CellContentClick);
            this.tasksDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tasksDataGridView_CellValueChanged);
            this.tasksDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tasksDataGridView_DataError);
            this.tasksDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.tasksDataGridView_RowsAdded);
            // 
            // task
            // 
            this.task.HeaderText = "Task";
            this.task.Name = "task";
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // note
            // 
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // done
            // 
            this.done.HeaderText = "Done";
            this.done.Name = "done";
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Text = "Delete";
            this.delete.ToolTipText = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(12, 261);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(96, 23);
            this.saveChangesButton.TabIndex = 4;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTaskToolStripMenuItem1,
            this.addNewTimestampToolStripMenuItem,
            this.addNewDateToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewTaskToolStripMenuItem1
            // 
            this.addNewTaskToolStripMenuItem1.Name = "addNewTaskToolStripMenuItem1";
            this.addNewTaskToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.addNewTaskToolStripMenuItem1.Text = "Add new task";
            this.addNewTaskToolStripMenuItem1.Click += new System.EventHandler(this.addNewTaskToolStripMenuItem1_Click);
            // 
            // addNewTimestampToolStripMenuItem
            // 
            this.addNewTimestampToolStripMenuItem.Name = "addNewTimestampToolStripMenuItem";
            this.addNewTimestampToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addNewTimestampToolStripMenuItem.Text = "Add new timestamp";
            this.addNewTimestampToolStripMenuItem.Click += new System.EventHandler(this.addNewTimestampToolStripMenuItem_Click);
            // 
            // addNewDateToolStripMenuItem
            // 
            this.addNewDateToolStripMenuItem.Name = "addNewDateToolStripMenuItem";
            this.addNewDateToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addNewDateToolStripMenuItem.Text = "Add new date";
            this.addNewDateToolStripMenuItem.Click += new System.EventHandler(this.addNewDateToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTasksToolStripMenuItem,
            this.editTimestampsToolStripMenuItem,
            this.editDatesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.optionsToolStripMenuItem.Text = "Edit";
            // 
            // editTasksToolStripMenuItem
            // 
            this.editTasksToolStripMenuItem.Name = "editTasksToolStripMenuItem";
            this.editTasksToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.editTasksToolStripMenuItem.Text = "Edit tasks";
            this.editTasksToolStripMenuItem.Click += new System.EventHandler(this.editTasksToolStripMenuItem_Click);
            // 
            // editTimestampsToolStripMenuItem
            // 
            this.editTimestampsToolStripMenuItem.Name = "editTimestampsToolStripMenuItem";
            this.editTimestampsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.editTimestampsToolStripMenuItem.Text = "Edit timestamps";
            this.editTimestampsToolStripMenuItem.Click += new System.EventHandler(this.editTimestampsToolStripMenuItem_Click);
            // 
            // editDatesToolStripMenuItem
            // 
            this.editDatesToolStripMenuItem.Name = "editDatesToolStripMenuItem";
            this.editDatesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.editDatesToolStripMenuItem.Text = "Edit dates";
            this.editDatesToolStripMenuItem.Click += new System.EventHandler(this.editDatesToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon.BalloonTipText = "Task Scheduler";
            this.notifyIcon.BalloonTipTitle = "Task Scheduler";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Task Scheduler";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 37);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date :";
            // 
            // revertButton
            // 
            this.revertButton.Location = new System.Drawing.Point(132, 261);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(96, 23);
            this.revertButton.TabIndex = 7;
            this.revertButton.Text = "Revert changes";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(54, 34);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(121, 21);
            this.dateComboBox.TabIndex = 2;
            this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.dayComboBox_SelectedIndexChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 291);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.tasksDataGridView);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "main";
            this.Text = "Task Scheduler";
            this.Resize += new System.EventHandler(this.main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tasksDataGridView;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn task;
        private System.Windows.Forms.DataGridViewComboBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewCheckBoxColumn done;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTimestampsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDatesToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTimestampToolStripMenuItem;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.ComboBox dateComboBox;
    }
}

