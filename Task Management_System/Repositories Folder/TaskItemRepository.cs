using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Task_Management_System.Data;

// 📍 TYPE ALIASES: Eliminates inline namespace noise for cleaner method signatures
using DbAppointment = Task_Management_System.Models.DbAppointment;
using DashboardAnnouncement = Task_Management_System.Models.DashboardAnnouncement;
using DbStudentProfile = Task_Management_System.Models.DbStudentProfile;

namespace Task_Management_System.Repositories_Folder
{
    internal class TaskItemRepository
    {
        // 📍 APPOINTMENTS / CALENDAR METHODS

        /// <summary>
        /// Retrieves all task appointments from the database using explicit structural mapping paths.
        /// </summary>
        public async Task<IEnumerable<DbAppointment>> GetAllAppointmentsAsync()
        {
            using var db = DatabaseContext.CreateConnection();
            return await db.QueryAsync<DbAppointment>("SELECT * FROM Appointments;");
        }

        /// <summary>
        /// Saves or Updates a task appointment using an atomic SQLite Upsert execution path.
        /// </summary>
        public async Task<bool> SaveAppointmentAsync(DbAppointment item)
        {
            using var db = DatabaseContext.CreateConnection();
            const string sql = @"
                INSERT INTO Appointments (UniqueId, Subject, Description, StartTime, EndTime, LabelKey, StatusKey, AllDay, Location, ReminderInfo)
                VALUES (@UniqueId, @Subject, @Description, @StartTime, @EndTime, @LabelKey, @StatusKey, @AllDay, @Location, @ReminderInfo)
                ON CONFLICT(UniqueId) DO UPDATE SET
                    Subject = @Subject,
                    Description = @Description,
                    StartTime = @StartTime,
                    EndTime = @EndTime,
                    LabelKey = @LabelKey,
                    StatusKey = @StatusKey,
                    AllDay = @AllDay,
                    Location = @Location,
                    ReminderInfo = @ReminderInfo;";

            return await db.ExecuteAsync(sql, item) > 0;
        }

        /// <summary>
        /// Deletes a specific task appointment by its Unique Identifier string.
        /// </summary>
        public async Task<bool> DeleteAppointmentAsync(string uniqueId)
        {
            using var db = DatabaseContext.CreateConnection();
            return await db.ExecuteAsync("DELETE FROM Appointments WHERE UniqueId = @UniqueId;", new { UniqueId = uniqueId }) > 0;
        }

        // 📍 DASHBOARD ANNOUNCEMENTS METHODS

        /// <summary>
        /// Fetches announcement alerts sorted by priority for the dashboard widgets.
        /// </summary>
        public async Task<IEnumerable<DashboardAnnouncement>> GetActiveAnnouncementsAsync()
        {
            using var db = DatabaseContext.CreateConnection();
            return await db.QueryAsync<DashboardAnnouncement>(
                "SELECT * FROM DashboardAnnouncements ORDER BY Priority DESC, DatePosted DESC;");
        }

        // 📍 STUDENT PROFILE MANAGEMENT METHODS

        /// <summary>
        /// Pulls profile data matching a specific Student Id login.
        /// </summary>
        public async Task<DbStudentProfile> GetProfileByIdAsync(string studentId)
        {
            using var db = DatabaseContext.CreateConnection();
            return await db.QueryFirstOrDefaultAsync<DbStudentProfile>(
                "SELECT * FROM StudentProfile WHERE StudentId = @StudentId;", new { StudentId = studentId });
        }

        /// <summary>
        /// Updates profile credentials or information changes.
        /// </summary>
        public async Task<bool> UpdateProfileAsync(DbStudentProfile profile)
        {
            using var db = DatabaseContext.CreateConnection();
            const string sql = @"
                UPDATE StudentProfile 
                SET FullName = @FullName, 
                    Email = @Email, 
                    Course = @Course, 
                    Phone = @Phone, 
                    PasswordHash = @PasswordHash,
                    ProfileImageBlob = @ProfileImageBlob
                WHERE StudentId = @StudentId;";

            return await db.ExecuteAsync(sql, profile) > 0;
        }
    }
}