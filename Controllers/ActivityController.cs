using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

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

        public List<ActivityItem> LoadData()
        {
            var userId = state.CurrentUserId;
            var role = state.CurrentUserRole;
            var isTeacher = role == Constants.TEACHER;
            var isManager = role == Constants.MANAGER;

            if (!isTeacher) return new List<ActivityItem>();

            var activities = context.Activities
                .Include(i => i.ActivityType)
                .Include(i => i.Semester)
                .Where(i => i.CreatorId == userId)
                .ToList()
                .Select(i => new ActivityItem
                {
                    Name = i.Name,
                    Description = i.Description,
                    StartTime = FormatDate(i.StartTime),
                    EndTime = FormatDate(i.EndTime),
                    SignUpStartTime = FormatDate(i.SignUpStartTime),
                    SignUpEndTime = FormatDate(i.SignUpEndTime),
                    NumberOfStudents = i.NumberOfStudents,
                    ActivityType = i.ActivityType.Name,
                    Semester = i.Semester.Name,
                    AttendanceCode = i.AttendanceCode,
                    IsApproved = i.IsApproved
                })
                .ToList();

            return activities;
        }

        private string FormatDate(DateTime date)
        {
            return date.ToString("MM/dd/yyyy HH:mm");
        }
    }
}
