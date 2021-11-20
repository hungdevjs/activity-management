
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
            this.UpdateBtn = new System.Windows.Forms.Button();
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
            this.ActivityListView.Location = new System.Drawing.Point(12, 41);
            this.ActivityListView.Name = "ActivityListView";
            this.ActivityListView.RowTemplate.Height = 25;
            this.ActivityListView.Size = new System.Drawing.Size(760, 408);
            this.ActivityListView.TabIndex = 9;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(697, 12);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ActivityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ActivityListView);
            this.Controls.Add(this.CreateActivityBtn);
            this.Controls.Add(this.BackBtn);
            this.Name = "ActivityList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityList";
            ((System.ComponentModel.ISupportInitialize)(this.ActivityListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button CreateActivityBtn;
        private System.Windows.Forms.DataGridView ActivityListView;
        private System.Windows.Forms.Button UpdateBtn;
    }
}