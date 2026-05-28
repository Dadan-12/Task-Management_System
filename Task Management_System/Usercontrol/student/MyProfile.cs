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

            // Attach necessary events
            btnUploadImage.Click += btnUploadImage_Click;
            btnChangePassword.Click += btnChangePassword_Click;
        }

        // ====================== PROFILE PICTURE ======================
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Title = "Choose Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureEdit1.Image = Image.FromFile(openFileDialog.FileName);
                        XtraMessageBox.Show("Profile picture updated successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Error loading image:\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ====================== CHANGE PASSWORD ======================
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                XtraMessageBox.Show("Please enter your current password.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.Text.Length < 6)
            {
                XtraMessageBox.Show("New password must be at least 6 characters long.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                XtraMessageBox.Show("New password and confirm password do not match!",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            // Success message (Replace with real database logic later)
            XtraMessageBox.Show("Password changed successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear fields
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        // ====================== LOAD STUDENT DATA ======================
        public void LoadStudentData(string fullName, string studentId, string email,
            string course, string phone, Image profileImage = null)
        {
            lblName.Text = fullName;
            lblStudentId.Text = "Student ID: " + studentId;
            lblEmail.Text = "Email: " + email;
            lblCourse.Text = "Course: " + course;
            lblPhone.Text = "Phone: " + phone;

            if (profileImage != null)
            {
                pictureEdit1.Image = profileImage;
            }
        }
    }
}