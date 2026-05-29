using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol.student
{
    public partial class Profile : XtraUserControl
    {
        // 📍 CONTEXT DATA: Default tracking runtime state fields
        public string CurrentStudentId { get; set; } = "STU-2026-0001";

        public Profile()
        {
            InitializeComponent();

            btnUploadImage.Click += BtnUploadImage_Click;
            btnChangePassword.Click += BtnChangePassword_Click;

            InitializePasswordFields(txtCurrentPassword);
            InitializePasswordFields(txtNewPassword);
            InitializePasswordFields(txtConfirmPassword);
        }

        // 📍 PASSWORD OBFUSCATION INTEGRATION: Injects vector action glyphs directly into editor text boxes
        private void InitializePasswordFields(ButtonEdit passwordEdit)
        {
            passwordEdit.Properties.Buttons.Clear();
            passwordEdit.Properties.UseSystemPasswordChar = true;

            var toggleButton = new EditorButton(ButtonPredefines.Glyph)
            {
                ImageOptions = { SvgImage = DevExpress.Images.ImageResourceCache.Default.GetSvgImage("actions/eye.svg") },
                ToolTip = "Show Password",
                IsLeft = false
            };

            passwordEdit.Properties.Buttons.Add(toggleButton);
            passwordEdit.Properties.TextEditStyle = TextEditStyles.Standard;

            passwordEdit.ButtonClick += (s, e) =>
            {
                if (s is ButtonEdit edit)
                {
                    edit.Properties.UseSystemPasswordChar = !edit.Properties.UseSystemPasswordChar;

                    if (edit.Properties.UseSystemPasswordChar)
                    {
                        e.Button.ImageOptions.SvgImage = DevExpress.Images.ImageResourceCache.Default.GetSvgImage("actions/eye.svg");
                        e.Button.ToolTip = "Show Password";
                    }
                    else
                    {
                        e.Button.ImageOptions.SvgImage = DevExpress.Images.ImageResourceCache.Default.GetSvgImage("actions/hide.svg");
                        e.Button.ToolTip = "Hide Password";
                    }
                }
            };
        }

        // 📍 LIFECYCLE INITIALIZER: Synchronizes active user credentials via global state contexts
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.CurrentStudentId = Task_Management_System.Data.SessionContext.ActiveStudentId;
            await RefreshProfileDetailsAsync();
        }

        // 📍 DIRECT HYDRATION DATA BRIDGE: Decouples dynamic object data structures onto interface controls
        public void InitializeProfileData(dynamic profilePayload)
        {
            if (profilePayload == null) return;

            try
            {
                string fName = profilePayload.FirstName?.ToString() ?? "";
                string lName = profilePayload.LastName?.ToString() ?? "";
                string fullName = string.IsNullOrWhiteSpace(fName + lName) ? "Unassigned Profile Name" : $"{fName} {lName}".Trim();

                string studentId = profilePayload.Student_Id?.ToString() ?? CurrentStudentId;
                string section = profilePayload.Section?.ToString() ?? "N/A";
                byte[] profileImageBytes = profilePayload.picture as byte[];

                this.CurrentStudentId = studentId;
                string generatedEmail = studentId.ToLower() + "@school.edu.ph";

                UpdateUIElements(fullName, studentId, generatedEmail, section, profileImageBytes);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to direct-hydrate profile context mapping: {ex.Message}");
            }
        }

        // 📍 DATA FETCH ENGINE: Pulls master record entities from underlying admin storage spaces
        public async Task RefreshProfileDetailsAsync()
        {
            if (string.IsNullOrWhiteSpace(CurrentStudentId))
            {
                XtraMessageBox.Show("Operational Error: Session Context Token has expired or is invalid.",
                    "Context Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var db = DatabaseContext.CreateConnection();

                const string queryText = @" 
                    SELECT Student_Id, FirstName, LastName, Section, picture 
                    FROM Admin 
                    WHERE Student_Id = @StudentId 
                    LIMIT 1;";

                var row = await db.QueryFirstOrDefaultAsync<dynamic>(queryText, new { StudentId = CurrentStudentId });

                if (row != null)
                {
                    InitializeProfileData(row);
                }
                else
                {
                    XtraMessageBox.Show("Unable to map context metadata. Profile identity record was not found.",
                        "Identity Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UpdateUIElements("Unknown Identity", CurrentStudentId, "N/A", "N/A", null);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Data core synchronization anomaly: {ex.Message}",
                    "System Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 UI ELEMENT BINDING PIPELINE: Updates visual string fields and image canvases smoothly
        private void UpdateUIElements(string name, string studentId, string email, string course, byte[] profileImage)
        {
            lblName.Text = name;
            lblStudentId.Text = "🆔 Student ID: " + studentId;
            lblEmail.Text = "✉️ Email: " + email;
            lblCourse.Text = "🎓 Section: " + course;

            ClearCurrentImage();

            if (profileImage != null && profileImage.Length > 0)
            {
                try
                {
                    using var ms = new MemoryStream(profileImage);
                    pictureEdit1.Image = new Bitmap(ms);
                }
                catch
                {
                    AssignFallbackAvatar();
                }
            }
            else
            {
                AssignFallbackAvatar();
            }
        }

        // 📍 MEDIA UPDATE WORKSPACE: Parses stream selections to overwrite media canvas nodes inside storage layers
        private async void BtnUploadImage_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() != DialogResult.OK) return;

            string sourceFilePath = xtraOpenFileDialog1.FileName;

            try
            {
                byte[] imageRawBytes;

                using (var fs = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, useAsync: true))
                using (var sourceImage = Image.FromStream(fs))
                using (var targetMemoryStream = new MemoryStream())
                {
                    sourceImage.Save(targetMemoryStream, ImageFormat.Png);
                    imageRawBytes = targetMemoryStream.ToArray();
                }

                using var db = DatabaseContext.CreateConnection();
                const string updateCommand = "UPDATE Admin SET picture = @ProfileImage WHERE Student_Id = @StudentId;";
                int rowsUpdated = await db.ExecuteAsync(updateCommand, new { ProfileImage = imageRawBytes, StudentId = CurrentStudentId });

                if (rowsUpdated > 0)
                {
                    XtraMessageBox.Show("Profile canvas media node updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshProfileDetailsAsync();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"File system IO parsing error: {ex.Message}", "Processing Failure",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 SECURE VAULT ENGINE: Validates length and values before committing credential updates
        private async void BtnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                XtraMessageBox.Show("Security credential fields cannot contain null or whitespace sequences.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 6)
            {
                XtraMessageBox.Show("Complexity criteria violation: Password payload length must be greater than or equal to 6 characters.",
                    "Security Constraint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                XtraMessageBox.Show("Security mismatch: The new credential string fails validation against the confirmation sequence.",
                    "Mismatch Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = DatabaseContext.CreateConnection();
                if (db.State != ConnectionState.Open) db.Open();

                using var transaction = db.BeginTransaction();
                try
                {
                    const string verifyText = "SELECT Password FROM Admin WHERE Student_Id = @StudentId LIMIT 1;";
                    string savedPassword = await db.QueryFirstOrDefaultAsync<string>(verifyText, new { StudentId = CurrentStudentId }, transaction);

                    if (savedPassword == null || savedPassword != oldPassword)
                    {
                        transaction.Rollback();
                        XtraMessageBox.Show("Authentication identity validation mismatch: Incorrect current password.",
                            "Authorization Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    const string updateText = "UPDATE Admin SET Password = @NewPassword WHERE Student_Id = @StudentId;";
                    int statusToken = await db.ExecuteAsync(updateText, new { NewPassword = newPassword, StudentId = CurrentStudentId }, transaction);

                    if (statusToken > 0)
                    {
                        transaction.Commit();
                        XtraMessageBox.Show("Account authorization credential key rolled over successfully.",
                            "Security Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCurrentPassword.Text = string.Empty;
                        txtNewPassword.Text = string.Empty;
                        txtConfirmPassword.Text = string.Empty;
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Security vault query exception: {ex.Message}",
                    "System Vault Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 CANVAS RESET TOOL: Disposes image handles in memory to release unmanaged resources safely
        private void ClearCurrentImage()
        {
            if (pictureEdit1.Image != null)
            {
                var targetDisposalLink = pictureEdit1.Image;
                pictureEdit1.Image = null;
                targetDisposalLink.Dispose();
            }
        }

        // 📍 ASSET FALLBACK AGENT: Assigns placeholder avatars if profile media nodes are unpopulated
        private void AssignFallbackAvatar()
        {
            var placeholderAvatar = Properties.Resources.ResourceManager.GetObject("default_avatar") as Image;
            if (placeholderAvatar != null)
            {
                pictureEdit1.Image = new Bitmap(placeholderAvatar);
            }
            else
            {
                pictureEdit1.Image = null;
            }
        }
    }
}