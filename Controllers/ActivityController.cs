using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


using ActivityManagement.Data;
using ActivityManagement.Helpers;
using ActivityManagement.Models;

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
        public int userId { get; set; }
        public bool isTeacher { get; set; }
        public bool isManager { get; set; }

        public ActivityController()
        {
            context = new ApplicationDbContext();
            state = GlobalState.GetInstance();
            userId = state.CurrentUserId;
            var role = state.CurrentUserRole;
            isTeacher = role == Constants.TEACHER;
            isManager = role == Constants.MANAGER;
        }

        public (BindingSource, SqlDataAdapter, DataTable) LoadData()
        {
            var semester = GetCurrentSemester();

            if (semester == default) return (null, null, null);

            var connectionString = Constants.ConnectionString;
            var sqlConnection = new SqlConnection(connectionString);
            var selectQueryString = "";

            if (isTeacher)
            {
                selectQueryString = $"SELECT * FROM Activities where SemesterId = {semester.Id} and CreatorId = {userId}";
            }

            if (isManager)
            {
                selectQueryString = $"SELECT * FROM Activities where SemesterId = {semester.Id}";
            }

            sqlConnection.Open();

            var sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            var sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            return (bindingSource, sqlDataAdapter, dataTable);
        }

        private Semester GetCurrentSemester()
        {
            var now = DateTime.Now;
            var semester = context.Semesters
                .Include(i => i.Year)
                .FirstOrDefault(i => i.StartTime <= now && now <= i.EndTime);
            return semester;
        }
    }
}
