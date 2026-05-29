using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using System.Threading.Tasks;

using StudentControls = Task_Management_System.Usercontrol.student;

namespace Task_Management_System.Dashboard
{
    public partial class StudentDashboard : XtraForm
    {
        // 📍 FIELD STACK: Cached backing subview references to preserve cross-session states
        private StudentControls.StudentDashboardOverview _overviewControl;
        private StudentControls.MySchedule _scheduleControl;
        private StudentControls.MyClassSchedule _classScheduleControl;
        private StudentControls.TaskScheduler _taskSchedulerControl;
        private StudentControls.Profile _profileControl;

        private readonly dynamic _loggedStudentProfile;

        public StudentDashboard(dynamic studentProfile)
        {
            InitializeComponent();

            _loggedStudentProfile = studentProfile;

            RegisterNavigationPipelineEvents();

            if (mainContentContainer != null)
            {
                mainContentContainer.AutoScroll = true;
            }

            NavigationPipelineRoute(accordionControlElementDashboard);
        }

        private void RegisterNavigationPipelineEvents()
        {
            accordionControl1.ElementClick += (sender, args) =>
            {
                if (args.Element != null)
                {
                    NavigationPipelineRoute(args.Element);
                }
            };
        }

        private void accordionControlElementClassSchedule_Click(object sender, EventArgs e) => 
            NavigationPipelineRoute(accordionControlElementClassSchedule);

        // 📍 ROUTER PIPELINE: Switches active workspaces on the panel canvas container dynamically
        private async void NavigationPipelineRoute(AccordionControlElement targetingElement)
        {
            if (targetingElement == accordionControlElementLogout)
            {
                ExecuteUserLogoutPipeline();
                return;
            }

            XtraUserControl targetedViewControl = null;

            if (targetingElement == accordionControlElementDashboard)
            {
                targetedViewControl = _overviewControl ??= new StudentControls.StudentDashboardOverview();
            }
            else if (targetingElement == accordionControlElementSchedule)
            {
                targetedViewControl = _scheduleControl ??= new StudentControls.MySchedule();
                await _scheduleControl.InitializeAndLoadCalendarDataAsync();
            }
            else if (targetingElement == accordionControlElementClassSchedule)
            {
                targetedViewControl = _classScheduleControl ??= new StudentControls.MyClassSchedule();

                if (_classScheduleControl.HasMethod("LoadClassSchedulesAsync"))
                {
                    dynamic dynamicControl = _classScheduleControl;
                    await dynamicControl.LoadClassSchedulesAsync(_loggedStudentProfile);
                }
            }
            else if (targetingElement == accordionControlElementTasks)
            {
                targetedViewControl = _taskSchedulerControl ??= new StudentControls.TaskScheduler();
                await _taskSchedulerControl.LoadSchedulerDataAsync();
            }
            else if (targetingElement == accordionControlElementProfile)
            {
                targetedViewControl = _profileControl ??= new StudentControls.Profile();

                if (_loggedStudentProfile != null && _profileControl.HasMethod("InitializeProfileData"))
                {
                    ((dynamic)_profileControl).InitializeProfileData(_loggedStudentProfile);
                }
            }

            if (targetedViewControl != null)
            {
                RenderControlToCanvasContainer(targetedViewControl);
            }
        }

        private void ExecuteUserLogoutPipeline()
        {
            var dialogResult = XtraMessageBox.Show(
                this,
                "Are you sure you want to log out of your session?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult != DialogResult.Yes) return;

            Form loginFormTarget = Application.OpenForms["LoginDashboard"];

            if (loginFormTarget != null)
            {
                loginFormTarget.Show();
            }
            else
            {
                new global::Task_Management_System.Dashboard.LoginDashboard().Show();
            }

            this.Close();
        }

        // 📍 CANVAS CONTROLLER: Completely resets the UI container workspace elements and handles layouts
        private void RenderControlToCanvasContainer(XtraUserControl control)
        {
            if (mainContentContainer == null) return;

            mainContentContainer.SuspendLayout();
            mainContentContainer.Controls.Clear();

            control.Size = mainContentContainer.ClientSize;
            control.Dock = DockStyle.Fill;
            control.Scale(new System.Drawing.SizeF(1F, 1F));

            mainContentContainer.Controls.Add(control);
            mainContentContainer.ResumeLayout(true);
            mainContentContainer.ScrollControlIntoView(control);
        }
    }

    public static class ReflectionExtensions
    {
        public static bool HasMethod(this object objectToCheck, string methodName) => 
            objectToCheck?.GetType().GetMethod(methodName) != null;
    }
}