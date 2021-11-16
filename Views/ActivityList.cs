using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ActivityManagement.Controllers;

namespace ActivityManagement.Views
{
    public partial class ActivityList : Form
    {
        private ActivityController controller;

        public ActivityList()
        {
            controller = new ActivityController();
            InitializeComponent();
            LoadData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            Hide();
        }

        private void LoadData()
        {
            var data = controller.LoadData();
            var items = new List<ListViewItem>();
            foreach (var item in data)
            {
                string[] row =
                {
                    item.Name,
                    item.Description,
                    item.StartTime,
                    item.EndTime,
                    item.SignUpStartTime,
                    item.SignUpEndTime,
                    item.NumberOfStudents.ToString(),
                    item.ActivityType,
                    item.Semester,
                    item.AttendanceCode,
                    item.IsApproved.ToString()
                };
                ActivityListView.Rows.Add(row);
            }
            Console.WriteLine(items);
        }
    }
}
