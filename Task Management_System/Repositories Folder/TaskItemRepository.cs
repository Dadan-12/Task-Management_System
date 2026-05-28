using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Task_Management_System.Data;

namespace Task_Management_System.Repositories_Folder
{
    internal class TaskItemRepository
    {
        // ==========================================
        // APPOINTMENTS / CALENDAR METHODS
        // ==========================================

        /// <summary>
        /// Retrieves all task appointments from the database using explicit structural mapping paths.
        /// </summary>
        public async Task<IEnumerable<Task_Management_System.Models.DbAppointment>> GetAllAppointmentsAsync()
        {
            using (IDbConnection db = DatabaseContext.CreateConnection())
            {
                // 🎯 CHANGED: Maps target return array elements cleanly to DbAppointment
                return await db.QueryAsync<Task_Management_System.Models.DbAppointment>("SELECT * FROM Appointments;");
            }
        }

        /// <summary>
        /// Saves or Updates a task appointment.
        /// </summary>
        public async Task<bool> SaveAppointmentAsync(Task_Management_System.Models.DbAppointment item)
        {
            using (IDbConnection db = DatabaseContext.CreateConnection())
            {
                string sql = @"
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

                int affectedRows = await db.ExecuteAsync(sql, item);
                return affectedRows > 0;
            }
        }

        /// <summary>
        /// Deletes a specific task appointment by its Unique Identifier string.
        /// </summary>
        public async Task<bool> DeleteAppointmentAsync(string uniqueId)
        {
            using (IDbConnection db = DatabaseContext.CreateConnection())
            {
                int affectedRows = await db.ExecuteAsync("DELETE FROM Appointments WHERE UniqueId = @UniqueId;", new { UniqueId = uniqueId });
                return affectedRows > 0;
            }
        }

        // ==========================================
        // DASHBOARD ANNOUNCEMENTS METHODS
        // ==========================================

        /// <summary>
        /// Fetches announcement alerts sorted by priority for the dashboard widgets.
        /// </summary>
        public async Task<IEnumerable<Task_Management_System.Models.DashboardAnnouncement>> GetActiveAnnouncementsAsync()
        {
            using (IDbConnection db = DatabaseContext.CreateConnection())
            {
                return await db.QueryAsync<Task_Management_System.Models.DashboardAnnouncement>(
                    "SELECT * FROM DashboardAnnouncements ORDER BY Priority DESC, DatePosted DESC;");
            }
        }

        // ==========================================
        // STUDENT PROFILE MANAGEMENT METHODS
        // ==========================================

        /// <summary>
        /// Pulls profile data matching a specific Student Id login.
        /// </summary>
        public async Task<Task_Management_System.Models.DbStudentProfile> GetProfileByIdAsync(string studentId)
        {
            using (IDbConnection db = DatabaseContext.CreateConnection())
            {
                return await db.QueryFirstOrDefaultAsync<Task_Management_System.Models.DbStudentProfile>(
                    "SELECT * FROM StudentProfile WHERE StudentId = @StudentId;", new { StudentId = studentId });
            }
        }

        /// <summary>
        /// Updates profile credentials or information changes.
        /// </summary>
        public async Task<bool> UpdateProfileAsync(Task_Management_System.Models.DbStudentProfile profile)
        {
            using (IDbConnection db = DatabaseContext.CreateConnection())
            {
                string sql = @"
                    UPDATE StudentProfile 
                    SET FullName = @FullName, 
                        Email = @Email, 
                        Course = @Course, 
                        Phone = @Phone, 
                        PasswordHash = @PasswordHash,
                        ProfileImageBlob = @ProfileImageBlob
                    WHERE StudentId = @StudentId;";

                int affectedRows = await db.ExecuteAsync(sql, profile);
                return affectedRows > 0;
            }
        }
    }
}