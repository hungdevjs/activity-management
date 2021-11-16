
namespace ActivityManagement.Views
{
    partial class ActivityList
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.CreateActivityBtn = new System.Windows.Forms.Button();
            this.ActivityListView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignUpStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignUpEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityListView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateActivityBtn
            // 
            this.CreateActivityBtn.Location = new System.Drawing.Point(93, 12);
            this.CreateActivityBtn.Name = "CreateActivityBtn";
            this.CreateActivityBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateActivityBtn.TabIndex = 8;
            this.CreateActivityBtn.Text = "Create activity";
            this.CreateActivityBtn.UseVisualStyleBackColor = true;
            // 
            // ActivityListView
            // 
            this.ActivityListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Description,
            this.StartTime,
            this.EndTime,
            this.SignUpStartTime,
            this.SignUpEndTime,
            this.NumberOfStudents,
            this.ActivityType,
            this.Semester,
            this.AttendanceCode,
            this.IsApproved});
            this.ActivityListView.Location = new System.Drawing.Point(12, 41);
            this.ActivityListView.Name = "ActivityListView";
            this.ActivityListView.RowTemplate.Height = 25;
            this.ActivityListView.Size = new System.Drawing.Size(760, 408);
            this.ActivityListView.TabIndex = 9;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start time";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End time";
            this.EndTime.Name = "EndTime";
            // 
            // SignUpStartTime
            // 
            this.SignUpStartTime.HeaderText = "Sign up start time";
            this.SignUpStartTime.Name = "SignUpStartTime";
            // 
            // SignUpEndTime
            // 
            this.SignUpEndTime.HeaderText = "Sign up end time";
            this.SignUpEndTime.Name = "SignUpEndTime";
            // 
            // NumberOfStudents
            // 
            this.NumberOfStudents.HeaderText = "Number of students";
            this.NumberOfStudents.Name = "NumberOfStudents";
            // 
            // ActivityType
            // 
            this.ActivityType.HeaderText = "Activity type";
            this.ActivityType.Name = "ActivityType";
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            // 
            // AttendanceCode
            // 
            this.AttendanceCode.HeaderText = "Attendance code";
            this.AttendanceCode.Name = "AttendanceCode";
            // 
            // IsApproved
            // 
            this.IsApproved.HeaderText = "Is approved";
            this.IsApproved.Name = "IsApproved";
            // 
            // ActivityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ActivityListView);
            this.Controls.Add(this.CreateActivityBtn);
            this.Controls.Add(this.BackBtn);
            //this.Name = "ActivityList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityList";
            ((System.ComponentModel.ISupportInitialize)(this.ActivityListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button CreateActivityBtn;
        private System.Windows.Forms.DataGridView ActivityListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignUpStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignUpEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsApproved;
    }
}