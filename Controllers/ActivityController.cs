using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


using ActivityManagement.Data;
using ActivityManagement.Helpers;

namespace ActivityManagement.Controllers
{
    public class ActivityItem
    {
        public string Name { get; set;  }
        public string Description { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string SignUpStartTime { get; set; }
        public string SignUpEndTime { get; set; }
        public int NumberOfStudents { get; set; }
        public string  ActivityType { get; set; }
        public string Semester { get; set; }
        public string AttendanceCode { get; set; }
        public bool IsApproved { get; set; }
    }
    class ActivityController
    {
        private ApplicationDbContext context { get; set; }
        private GlobalState state { get; set; }

        public ActivityController()
        {
            context = new ApplicationDbContext();
            state = GlobalState.GetInstance();
        }

        public (BindingSource, SqlDataAdapter, DataTable) LoadData()
        {
            var userId = state.CurrentUserId;
            var role = state.CurrentUserRole;
            var isTeacher = role == Constants.TEACHER;
            var isManager = role == Constants.MANAGER;

            if (!isTeacher) return (null, null, null);

            var connectionString = Constants.ConnectionString;
            var sqlConnection = new SqlConnection(connectionString);
            var selectQueryString = $"SELECT * FROM Activities where CreatorId = {userId}";

            sqlConnection.Open();

            var sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            var sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            return (bindingSource, sqlDataAdapter, dataTable);
        }
    }
}
