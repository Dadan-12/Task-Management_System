using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using Task_Management_System.Usercontrol.student;

namespace Task_Management_System.Dashboard
{
    public partial class StudentDashboard : DevExpress.XtraEditors.XtraForm
    {
        // View Component Fields for UI Component Caching Strategy
        private StudentDashboardOverview _overviewControl;
        private MySchedule _scheduleControl;
        private TaskScheduler _taskSchedulerControl;
        private MyProfile _profileControl;

        public StudentDashboard()
        {
            InitializeComponent();
            RegisterNavigationPipelineEvents();

            // FIX: Ensure the master layout panel handles over-sized controls gracefully by showing scrollbars
            if (mainContentContainer != null)
            {
                mainContentContainer.AutoScroll = true;
            }

            // Set the first dashboard component active by default on launch
            NavigationPipelineRoute(accordionControlElementDashboard);
        }

        private void RegisterNavigationPipelineEvents()
        {
            // Connect Hamburger Action Clicks directly to the workspace router
            accordionControl1.ElementClick += (sender, args) =>
            {
                if (args.Element != null)
                {
                    NavigationPipelineRoute(args.Element);
                }
            };
        }

        /// <summary>
        /// Orchestrates rendering targets and structural swaps into the central view canvas.
        /// </summary>
        private async void NavigationPipelineRoute(AccordionControlElement targetingElement)
        {
            // 🚪 INTERCEPT LOGOUT SELECTION IMMEDIATELY
            if (targetingElement == accordionControlElementLogout)
            {
                ExecuteUserLogoutPipeline();
                return;
            }

            XtraUserControl targetedViewControl = null;

            if (targetingElement == accordionControlElementDashboard)
            {
                if (_overviewControl == null) _overviewControl = new StudentDashboardOverview();
                targetedViewControl = _overviewControl;
            }
            else if (targetingElement == accordionControlElementSchedule)
            {
                if (_scheduleControl == null) _scheduleControl = new MySchedule();
                targetedViewControl = _scheduleControl;

                // 🔄 SYNC REFRESH: Force MySchedule to fetch assignments added or altered inside TaskScheduler
                await _scheduleControl.InitializeAndLoadCalendarDataAsync();
            }
            else if (targetingElement == accordionControlElementTasks)
            {
                if (_taskSchedulerControl == null) _taskSchedulerControl = new TaskScheduler();
                targetedViewControl = _taskSchedulerControl;

                // 🔄 SYNC REFRESH: Force TaskScheduler to fetch details added or altered inside MySchedule
                await _taskSchedulerControl.LoadSchedulerDataAsync();
            }
            else if (targetingElement == accordionControlElementProfile)
            {
                if (_profileControl == null) _profileControl = new MyProfile();
                targetedViewControl = _profileControl;
            }

            if (targetedViewControl != null)
            {
                RenderControlToCanvasContainer(targetedViewControl);
            }
        }

        /// <summary>
        /// Prompts a user confirmation dialog and securely redirects visibility context back out to the app login display.
        /// </summary>
        private void ExecuteUserLogoutPipeline()
        {
            var dialogResult = XtraMessageBox.Show(
                this,
                "Are you sure you want to log out of your session?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                // Restore visibility to your existing background instance of LoginDashboard
                Form loginFormTarget = Application.OpenForms["LoginDashboard"] ?? Application.OpenForms["LoginDashboardcs"];

                if (loginFormTarget != null)
                {
                    loginFormTarget.Show();
                }
                else
                {
                    // Fallback instantiation safety mechanism if form instance was dropped from the memory stack
                    var fallbackLogin = new LoginDashboard();
                    fallbackLogin.Show();
                }

                // Shut down and close the current dashboard instance context state out of memory 
                this.Close();
            }
        }

        /// <summary>
        /// Safely updates controls inside the main panel, preventing visual flickering and solving size overflow constraints.
        /// </summary>
        private void RenderControlToCanvasContainer(XtraUserControl control)
        {
            if (mainContentContainer == null) return;

            // Suspend paint cycles to suppress UI flickering effects during component shifts
            mainContentContainer.SuspendLayout();

            // Clear prior control items without breaking parent references
            mainContentContainer.Controls.Clear();

            // FIX 1: Explicitly tell the user control to match the container's parent size constraints
            control.Size = mainContentContainer.ClientSize;
            control.Dock = DockStyle.Fill;

            // FIX 2: Force DevExpress components inside the control to evaluate scale calculations immediately
            control.Scale(new System.Drawing.SizeF(1F, 1F));

            mainContentContainer.Controls.Add(control);

            // Force clean graphics refresh pipeline
            mainContentContainer.ResumeLayout(true);

            // FIX 3: Reset scroll origins to top-left so the view doesn't render off-kilter
            mainContentContainer.ScrollControlIntoView(control);
        }
    }
}