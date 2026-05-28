using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Drawing.Imaging; // Added for correct ImageFormat processing
using System.IO;
using System.Windows.Forms;
using System.Data;
using Dapper;
using Task_Management_System.Data;
using Task_Management_System.Models;

namespace Task_Management_System.Usercontrol.student
{
    public partial class MyProfile : DevExpress.XtraEditors.XtraUserControl
    {
        // Active context profile token tracking key
        private string currentStudentId = "STU-2026-0001";

        public MyProfile()
        {
            InitializeComponent();

            // Wire up performance click event handlers
            btnUploadImage.Click += btnUploadImage_Click;
            btnChangePassword.Click += btnChangePassword_Click;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Automatically populate records when the control initializes on the workspace
            RefreshProfileDetails();
        }

        /// <summary>
        /// Reads student properties and profile images from SQLite via DatabaseContext
        /// </summary>
        public void RefreshProfileDetails()
        {
            try
            {
                using (IDbConnection db = DatabaseContext.CreateConnection())
                {
                    string queryText = "SELECT StudentId, FullName, Email, Course, Phone, ProfileImageBlob FROM StudentProfile WHERE StudentId = @StudentId;";

                    var student = db.QueryFirstOrDefault<DbStudentProfile>(queryText, new { StudentId = currentStudentId });

                    if (student != null)
                    {
                        // Safely apply text properties mapping directly to returned schema records
                        lblName.Text = student.FullName ?? "Not Available";
                        lblStudentId.Text = "🆔 Student ID: " + (student.StudentId ?? currentStudentId);
                        lblEmail.Text = "✉️ Email: " + (student.Email ?? string.Empty);
                        lblCourse.Text = "🎓 Course: " + (student.Course ?? string.Empty);
                        lblPhone.Text = "📱 Phone: " + (student.Phone ?? string.Empty);

                        // Safe UI image clearing to avoid leaking Win32 handles
                        ClearCurrentImage();

                        // Extract bytes securely from your global model property
                        byte[] imgBytes = student.ProfileImageBlob;

                        if (imgBytes != null && imgBytes.Length > 0)
                        {
                            // Load image as a completely independent object clone to prevent stream disposal layout crashes
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                using (Image tempImg = Image.FromStream(ms))
                                {
                                    pictureEdit1.Image = new Bitmap(tempImg);
                                }
                            }
                        }
                        else
                        {
                            // Assign a local resource fallback avatar if no image exists in the database
                            AssignFallbackAvatar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Failed to pull remote profile data matrix:\n{ex.Message}",
                    "Database Engine Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== PROFILE PICTURE PROCESSING (BLOB SAVE & INSTANT UPDATE) ======================
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            // Set file filter rules so users only upload standard image definitions
            xtraOpenFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] imageRawBytes;

                    // 1. Read via file system byte arrays to avoid locking disk assets
                    byte[] fileBytes = File.ReadAllBytes(xtraOpenFileDialog1.FileName);

                    using (MemoryStream inMs = new MemoryStream(fileBytes))
                    {
                        using (Image loadedImage = Image.FromStream(inMs))
                        {
                            // 2. Clear old image control allocations to prevent memory leaks
                            ClearCurrentImage();

                            // 3. Put it straight into the pictureEdit control layout for instantaneous previewing
                            pictureEdit1.Image = new Bitmap(loadedImage);

                            // 4. Transform image accurately using standard PNG fallback if RawFormat guidance breaks
                            using (MemoryStream outMs = new MemoryStream())
                            {
                                ImageFormat format = loadedImage.RawFormat;
                                if (format.Guid == ImageFormat.MemoryBmp.Guid)
                                {
                                    format = ImageFormat.Png; // Standard secure runtime optimization fallback
                                }
                                loadedImage.Save(outMs, format);
                                imageRawBytes = outMs.ToArray();
                            }
                        }
                    }

                    // 5. Commit changes to your backend database architecture context instantly
                    using (IDbConnection db = DatabaseContext.CreateConnection())
                    {
                        string updateQuery = "UPDATE StudentProfile SET ProfileImageBlob = @ImgData WHERE StudentId = @StudentId;";
                        db.Execute(updateQuery, new { ImgData = imageRawBytes, StudentId = currentStudentId });
                    }

                    XtraMessageBox.Show(this, "Profile picture saved and updated successfully into your workspace layout!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(this, $"Error processing chosen image configuration asset:\n{ex.Message}",
                        "File Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ====================== AUTHENTICATION PASSWORDS SUB-ROUTINE ======================
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPwd = txtCurrentPassword.Text;
            string newPwd = txtNewPassword.Text;
            string confirmPwd = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(currentPwd))
            {
                XtraMessageBox.Show(this, "Please enter your current profile verification key.",
                    "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newPwd) || newPwd.Length < 6)
            {
                XtraMessageBox.Show(this, "Your new secure password length must consist of at least 6 characters.",
                    "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPwd != confirmPwd)
            {
                XtraMessageBox.Show(this, "New password values do not match target confirm parameters!",
                    "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                using (IDbConnection db = DatabaseContext.CreateConnection())
                {
                    string verificationQuery = "SELECT PasswordHash FROM StudentProfile WHERE StudentId = @StudentId;";
                    string savedPassword = db.QueryFirstOrDefault<string>(verificationQuery, new { StudentId = currentStudentId });

                    if (savedPassword != currentPwd)
                    {
                        XtraMessageBox.Show(this, "The existing account password provided is invalid.",
                            "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtCurrentPassword.Focus();
                        return;
                    }

                    string updatePasswordQuery = "UPDATE StudentProfile SET PasswordHash = @NewPwd WHERE StudentId = @StudentId;";
                    db.Execute(updatePasswordQuery, new { NewPwd = newPwd, StudentId = currentStudentId });
                }

                XtraMessageBox.Show(this, "Security parameters committed successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCurrentPassword.Text = string.Empty;
                txtNewPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Security update interrupted:\n{ex.Message}",
                    "Database Update Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== RE-SEED PROFILE PARAMETERS ======================
        public void LoadStudentData(string fullName, string studentId, string email,
            string course, string phone, Image profileImage = null)
        {
            this.currentStudentId = studentId;
            lblName.Text = fullName;
            lblStudentId.Text = "🆔 Student ID: " + studentId;
            lblEmail.Text = "✉️ Email: " + email;
            lblCourse.Text = "🎓 Course: " + course;
            lblPhone.Text = "📱 Phone: " + phone;

            ClearCurrentImage();

            if (profileImage != null)
            {
                pictureEdit1.Image = new Bitmap(profileImage);
            }
            else
            {
                AssignFallbackAvatar();
            }
        }

        // ====================== HELPER MEMORY AND LAYOUT CLEANUP METRICS ======================
        private void ClearCurrentImage()
        {
            if (pictureEdit1.Image != null)
            {
                var oldImage = pictureEdit1.Image;
                pictureEdit1.Image = null;
                oldImage.Dispose(); // Releases GDI+ bitmap memory links directly
            }
        }

        private void AssignFallbackAvatar()
        {
            // Checks if a default resource avatar placeholder image asset exists in properties
            // (Replace 'default_avatar' with whatever you named your resource file item)
            var defaultAvatar = Properties.Resources.ResourceManager.GetObject("default_avatar") as Image;
            if (defaultAvatar != null)
            {
                pictureEdit1.Image = new Bitmap(defaultAvatar);
            }
            else
            {
                pictureEdit1.Image = null;
            }
        }
    }
}