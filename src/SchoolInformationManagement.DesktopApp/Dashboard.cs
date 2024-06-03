using MaterialSkin;
using MaterialSkin.Controls;
using SchoolInformationManagement.Business.Abstract;
using SchoolInformationManagement.Core.Entities.Dto;
using SchoolInformationManagement.Entities.Concrete;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Net;
using System.Windows.Forms;

namespace SchoolInformationManagement.DesktopApp
{
    public partial class Dashboard : MaterialForm
    {
        private readonly IPrincipalService _principalService;
        private readonly ISchoolEntryExitService _schoolEntryExitService;
        private readonly MaterialSkin.MaterialSkinManager _materialSkinManager;
        private readonly IClassService _classService;
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;
        private readonly IClassAssignmentService _classAssignmentService;
        private readonly IParentService _parentService;


        private readonly string _email;

        private bool isFirstLoad = true;
        public Dashboard(IPrincipalService principalService, string email, ISchoolEntryExitService schoolEntryExitService, IClassService classService, ITeacherService teacherService, IStudentService studentService, IClassAssignmentService classAssignmentService, IParentService parentService)
        {
            InitializeComponent();
            _email = email;
            _principalService = principalService;
            _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            _materialSkinManager.EnforceBackcolorOnAllComponents = true;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, TextShade.WHITE);
            _schoolEntryExitService = schoolEntryExitService;
            _classService = classService;
            _teacherService = teacherService;
            _studentService = studentService;
            _classAssignmentService = classAssignmentService;
            _parentService = parentService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var schoolEntryExit = _schoolEntryExitService.GetSchoolEntryExit();

            lblUserName.Text = _email;

            var bindingList = new BindingList<SchoolEntryExitDto>(schoolEntryExit);
            var source = new BindingSource(bindingList, null);
            GetClassList();
            GetTeacherList();
            GetStudentList();
            GetClassAssignment();
            GetComboBoxClassAssignment();
            GetComboBoxStudent();
            GetComboBoxTeacher();
            GetComboBoxClass();
            GetComboBoxParent();
            dataGridView1.DataSource = source;
            dataGridStudent.Columns["Photo"].Width = 100;
        }

        private void GetClassAssignment()
        {
            var classAssignment = _classAssignmentService.GetClassAssignments();
            dataGridClassAssignment.DataSource = classAssignment;
        }

        private void GetClassList()
        {
            var getClass = _classService.GetList();
            datagrdClass.DataSource = getClass;
        }

        private void GetTeacherList()
        {
            var getTeacher = _teacherService.GetList();
            dtGrdTeacher.DataSource = getTeacher;
        }

        private void GetStudentList()
        {
            var getStudent = _studentService.GetList();
            dataGridStudent.DataSource = getStudent;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (txtBoxClassName.Text == "" || txtBoxClassName.Text == null)
            {
                MaterialMessageBox.Show("Boş ekleme işlemi yapamazsınız");
            }
            else
            {
                var addClass = new Class
                {
                    Name = txtBoxClassName.Text,
                };
                var clas = _classService.Add(addClass);
                if (clas != false)
                {
                    MaterialMessageBox.Show("Sınıf başarılı bir şekilde eklendi");
                    txtBoxClassName.Text = "";
                    lblClassId.Text = "";
                    GetClassList();
                }
                else
                {
                    MaterialMessageBox.Show("Yapılan ekleme işlemi hatalı");
                }
            }
        }

        private void mtbuttonTeacher_Click(object sender, EventArgs e)
        {
            if (teacherTxtBox.Text == "" || teacherTxtBox.Text == null || mtTextBoxLastName.Text == "" || mtTextBoxLastName.Text == null || mtTextBoxTeacherBranch.Text == "" || mtTextBoxTeacherBranch.Text == null)
            {
                MaterialMessageBox.Show("Boş ekleme işlemi yapamazsınız");
            }
            else
            {
                var addTeacher = new Teacher
                {
                    FirstName = teacherTxtBox.Text,
                    LastName = mtTextBoxLastName.Text,
                    Branch = mtTextBoxTeacherBranch.Text
                };
                var clas = _teacherService.Add(addTeacher);
                if (clas != false)
                {
                    MaterialMessageBox.Show("Öğretmen başarılı bir şekilde eklendi");
                    teacherTxtBox.Text = "";
                    mtTextBoxLastName.Text = "";
                    mtTextBoxTeacherBranch.Text = "";
                    lblTeacherId.Text = "";
                    GetTeacherList();
                }
                else
                {
                    MaterialMessageBox.Show("Yapılan ekleme işlemi hatalı");
                }
            }
        }

        private void dtGrdTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int teacherId = (int)dtGrdTeacher.CurrentRow.Cells[0].Value;
            if (teacherId != null)
            {
                var teacher = _teacherService.GetById(teacherId);
                lblTeacherId.Text = teacherId.ToString();
                teacherTxtBox.Text = teacher.FirstName;
                mtTextBoxLastName.Text = teacher.LastName;
            }
        }

        private void mtStudentButton_Click(object sender, EventArgs e)
        {
            if (mtTextBoxStudentName.Text == "" || mtTextBoxStudentName.Text == null || mtTextBoxStudentLastName.Text == "" || mtTextBoxStudentLastName.Text == null || mtTextBoxPhoneStudent.Text == "" || mtTextBoxPhoneStudent.Text == null ||
              mtTextBoxGender.Text == "" || mtTextBoxGender.Text == null ||
              mtTextBoxAddressStudent.Text == "" || mtTextBoxAddressStudent.Text == null ||
              dateTimePickerStudent.Text == "" || dateTimePickerStudent.Text == null)
            {
                MaterialMessageBox.Show("Boş ekleme işlemi yapamazsınız");
            }
            else
            {
                var parentId = (int)mtCmbxParent.SelectedIndex;
                DateTime birthDateLocal = dateTimePickerStudent.Value;
                DateTime birthDateUtc = birthDateLocal.ToUniversalTime();

                var addStudent = new Student
                {
                    FirstName = mtTextBoxStudentName.Text,
                    LastName = mtTextBoxStudentLastName.Text,
                    Gender = mtTextBoxGender.Text,
                    Address = mtTextBoxAddressStudent.Text,
                    Phone = mtTextBoxPhoneStudent.Text,
                    BloodGroup = mtTextBoxGender.Text,
                    BirthDate = birthDateUtc,
                    ParentId = parentId,
                    Photo = ResizeImage(txtBoxFilePath.Text)
                };
                var stdnt = _studentService.Add(addStudent);
                if (stdnt != false)
                {
                    MaterialMessageBox.Show("Öğrenci başarılı bir şekilde eklendi");
                    mtTextBoxStudentName.Text = "";
                    mtTextBoxStudentLastName.Text = "";
                    mtTextBoxGender.Text = "";
                    mtTextBoxAddressStudent.Text = "";
                    mtTextBoxPhoneStudent.Text = "";
                    dateTimePickerStudent.Value = dateTimePickerStudent.Value.ToLocalTime();
                    GetStudentList();
                }
                else
                {
                    MaterialMessageBox.Show("Yapılan ekleme işlemi hatalı");
                }
            }
        }
        private byte[] GetFileBytes(string filePath)
        {
            // Dosya yoksa veya hatalı yolu verilmişse null döndür
            if (!File.Exists(filePath))
                return null;

            // Dosya içeriğini oku ve byte dizisine dönüştür
            byte[] fileBytes = File.ReadAllBytes(filePath);

            return fileBytes;
        }

        private byte[] ResizeImage(string filePath)
        {
            // Dosya yoksa veya hatalı yolu verilmişse null döndür
            if (!File.Exists(filePath))
                return null;

            // Orjinal resmi yükleyin
            using (Image originalImage = Image.FromFile(filePath))
            {
                // Resmi hedef boyuta yeniden boyutlandır
                using (Image resizedImage = originalImage.GetThumbnailImage(100,100, null, IntPtr.Zero))
                {
                    // Yeniden boyutlandırılmış resmi byte dizisine dönüştür
                    using (MemoryStream ms = new MemoryStream())
                    {
                        resizedImage.Save(ms, ImageFormat.Jpeg); // Dönüştürme formatına göre ayarlayın
                        return ms.ToArray();
                    }
                }
            }
        }


        private void GetComboBoxStudent()
        {
            var students = _studentService.GetList();

            // ComboBox'ı temizle
            cmbBoxClassAssignment.Items.Clear();
            cmbBoxClassAssignment.Items.Add("Seçiniz");


            // Tüm öğrencilerin adlarını ComboBox'a ekle
            foreach (var student in students)
            {
                cmbBoxClassAssignment.Items.Add($"{student.FirstName + ' ' + student.LastName}");
            }
            cmbBoxClassAssignment.SelectedIndex = 0; 
        }
        private void GetComboBoxClassAssignment()
        {
            var classes = _classService.GetList();

            // ComboBox'ı temizle
            mtCmBoxClassAss.Items.Clear();
            mtCmBoxClassAss.Items.Add("Seçiniz");


            // Tüm öğrencilerin adlarını ComboBox'a ekle
            foreach (var clas in classes)
            {
                mtCmBoxClassAss.Items.Add(clas.Name);
            }
            mtCmBoxClassAss.SelectedIndex = 0;
        }

        private void GetComboBoxClass()
        {
            var students = _studentService.GetList();

            // ComboBox'ı temizle
            cmbBoxClassAssignment.Items.Clear();
            cmbBoxClassAssignment.Items.Add("Seçiniz");


            // Tüm öğrencilerin adlarını ComboBox'a ekle
            foreach (var student in students)
            {
                cmbBoxClassAssignment.Items.Add($"{student.FirstName + ' ' + student.LastName}");
            }
            cmbBoxClassAssignment.SelectedIndex = 0;
        }

        private void GetComboBoxTeacher()
        {
            var teachers = _teacherService.GetList();

            // ComboBox'ı temizle
            cmbxTeacher.Items.Clear();
            cmbxTeacher.Items.Add("Seçiniz");


            // Tüm öğrencilerin adlarını ComboBox'a ekle
            foreach (var teacher in teachers)
            {
                cmbxTeacher.Items.Add($"{teacher.FirstName + ' ' + teacher.LastName}");
            }
            cmbxTeacher.SelectedIndex = 0;
        }

        private void GetComboBoxParent()
        {
            var parents = _parentService.GetList();

            // ComboBox'ı temizle
            mtCmbxParent.Items.Clear();
            mtCmbxParent.Items.Add("Seçiniz");


            // Tüm öğrencilerin adlarını ComboBox'a ekle
            foreach (var parent in parents)
            {
                mtCmbxParent.Items.Add($"{parent.FirstName + ' ' + parent.LastName}");
            }
            mtCmbxParent.SelectedIndex = 0;
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void materialComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void classAssignmentAdd_Click(object sender, EventArgs e)
        {

            int classId = Convert.ToInt32(mtCmBoxClassAss.SelectedIndex);
            int studentId = Convert.ToInt32(cmbBoxClassAssignment.SelectedIndex);
            int teacherId = Convert.ToInt32(cmbxTeacher.SelectedIndex);

            var classAssignment = new ClassAssignment
            {
                ClassId = classId,
                StudentId = studentId,
                TeacherId = teacherId
            };
            var stdnt = _classAssignmentService.Add(classAssignment);
            if (stdnt != false)
            {
                MaterialMessageBox.Show("Öğrenci başarılı bir şekilde eklendi");
                GetClassAssignment();
            }
            else
            {
                MaterialMessageBox.Show("Yapılan ekleme işlemi hatalı");
            }
        }

        private void dataGridClassAssignment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridClassAssignment.Rows[e.RowIndex];
                int classAssignmentId;
                if (selectedRow.Cells[0].Value != null && int.TryParse(selectedRow.Cells[0].Value.ToString(), out classAssignmentId))
                {
                    var getByIdclassAssignment = _classAssignmentService.GetById(classAssignmentId);
                    if (getByIdclassAssignment != null)
                    {
                        lblClassAssId.Text = getByIdclassAssignment.Id.ToString();
                        mtCmBoxClassAss.Text = getByIdclassAssignment.ClassName;
                        cmbxTeacher.Text = getByIdclassAssignment.TeacherName;
                        cmbBoxClassAssignment.Text = getByIdclassAssignment.TeacherName;
                    }
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {


        }

        private void fileLoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtBoxFilePath.Text = openFileDialog1.FileName;
                }
            }
        }

        public Image ResizeImage(Image originalImage, int targetWidth, int targetHeight)
        {
            // Resmi hedef boyuta yeniden boyutlandır
            Bitmap resizedImage = new Bitmap(targetWidth, targetHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originalImage, 0, 0, targetWidth, targetHeight);
            }
            return resizedImage;
        }

        private void materialComboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}
