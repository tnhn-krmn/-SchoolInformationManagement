

using MaterialSkin.Controls;
using SchoolInformationManagement.Business.Abstract;

namespace SchoolInformationManagement.DesktopApp
{
    public partial class Login : MaterialForm
    {
        private readonly IPrincipalService _principalService;
        private readonly ISchoolEntryExitService _schoolEntryExitService;
        private readonly IClassService _classService;
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;
        private readonly IParentService _parentService;
        private readonly IClassAssignmentService _classAssignmentService;
        public Login(IPrincipalService principalService, ISchoolEntryExitService schoolEntryExitService, IClassService classService, ITeacherService teacherService, IStudentService studentService, IClassAssignmentService classAssignmentService, IParentService parentService)
        {
            InitializeComponent();
            _principalService = principalService;
            _schoolEntryExitService = schoolEntryExitService;
            _classService = classService;
            _teacherService = teacherService;
            _studentService = studentService;
            _classAssignmentService = classAssignmentService;
            _parentService = parentService;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var IsPrincipal = _principalService.getPrincipal(txtBoxUserName.Text, txtBoxPassword.Text);

            if (IsPrincipal == null)
            {
                MaterialMessageBox.Show("E-posta veya parolanız hatalı.");
            }
            else
            {
                var dashboard = new Dashboard(_principalService,IsPrincipal.Email, _schoolEntryExitService,_classService, _teacherService,_studentService, _classAssignmentService, _parentService);
                dashboard.Show();
                this.Hide();
            }
        }
    }
}
