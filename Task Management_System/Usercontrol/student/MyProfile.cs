using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_Management_System.Usercontrol.student
{
    public partial class MyProfile : DevExpress.XtraEditors.XtraUserControl
    {
        public MyProfile()
        {
            InitializeComponent();

            // Attach DevExpress control actions
            btnUploadImage.Click += btnUploadImage_Click;
            btnChangePassword.Click += btnChangePassword_Click;
        }

        // ====================== PROFILE PICTURE (PURE DEVEXPRESS) ======================
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            // Uses the skinnable DevExpress component instantiated inside the designer file
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureEdit1.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
                    XtraMessageBox.Show(this, "Profile picture updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(this, $"Error loading chosen image file:\n{ex.Message}",
                        "File Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ====================== CHANGE PASSWORD ======================
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                XtraMessageBox.Show(this, "Please enter your current password.",
                    "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.Text.Length < 6)
            {
                XtraMessageBox.Show(this, "New password must be at least 6 characters long.",
                    "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                XtraMessageBox.Show(this, "New password and confirm password do not match!",
                    "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            // Success confirmation (Integrate your database execution task here)
            XtraMessageBox.Show(this, "Password changed successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear look-and-feel field states cleanly
            txtCurrentPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        // ====================== LOAD STUDENT DATA ======================
        public void LoadStudentData(string fullName, string studentId, string email,
            string course, string phone, Image profileImage = null)
        {
            lblName.Text = fullName;
            lblStudentId.Text = "🆔 Student ID: " + studentId;
            lblEmail.Text = "✉️ Email: " + email;
            lblCourse.Text = "🎓 Course: " + course;
            lblPhone.Text = "📱 Phone: " + phone;

            if (profileImage != null)
            {
                pictureEdit1.Image = profileImage;
            }
        }
    }
}