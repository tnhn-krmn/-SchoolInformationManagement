namespace SchoolInformationManagement.DesktopApp
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ımageList1 = new ImageList(components);
            lblUserName = new Label();
            tabPage4 = new TabPage();
            txtBoxBloodGroup = new MaterialSkin.Controls.MaterialTextBox();
            mtCmbxParent = new MaterialSkin.Controls.MaterialComboBox();
            txtBoxFilePath = new MaterialSkin.Controls.MaterialTextBox2();
            fileLoadButton = new MaterialSkin.Controls.MaterialButton();
            pictureBox4 = new PictureBox();
            mtTextBoxAddressStudent = new MaterialSkin.Controls.MaterialTextBox();
            mtTextBoxPhoneStudent = new MaterialSkin.Controls.MaterialTextBox();
            mtTextBoxGender = new MaterialSkin.Controls.MaterialTextBox();
            mtTextBoxStudentLastName = new MaterialSkin.Controls.MaterialTextBox();
            mtStudentButton = new MaterialSkin.Controls.MaterialButton();
            dateTimePickerStudent = new DateTimePicker();
            dataGridStudent = new DataGridView();
            lblStudentId = new MaterialSkin.Controls.MaterialLabel();
            mtTextBoxStudentName = new MaterialSkin.Controls.MaterialTextBox();
            tabPage3 = new TabPage();
            mtTextBoxTeacherBranch = new MaterialSkin.Controls.MaterialTextBox();
            pictureBox3 = new PictureBox();
            mtTextBoxLastName = new MaterialSkin.Controls.MaterialTextBox();
            mtbuttonTeacher = new MaterialSkin.Controls.MaterialButton();
            dtGrdTeacher = new DataGridView();
            lblTeacherId = new MaterialSkin.Controls.MaterialLabel();
            teacherTxtBox = new MaterialSkin.Controls.MaterialTextBox();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            datagrdClass = new DataGridView();
            lblClassId = new MaterialSkin.Controls.MaterialLabel();
            txtBoxClassName = new MaterialSkin.Controls.MaterialTextBox();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage5 = new TabPage();
            lblClassAssId = new Label();
            pictureBox5 = new PictureBox();
            mtCmBoxClassAss = new MaterialSkin.Controls.MaterialComboBox();
            classAssignmentAdd = new MaterialSkin.Controls.MaterialButton();
            cmbxTeacher = new MaterialSkin.Controls.MaterialComboBox();
            cmbBoxClassAssignment = new MaterialSkin.Controls.MaterialComboBox();
            dataGridClassAssignment = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrdTeacher).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagrdClass).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialTabControl1.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridClassAssignment).BeginInit();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "student_icon.png");
            ımageList1.Images.SetKeyName(1, "class_icon.png");
            ımageList1.Images.SetKeyName(2, "teacher_icon.png");
            ımageList1.Images.SetKeyName(3, "home_icon.png");
            ımageList1.Images.SetKeyName(4, "folder.png");
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(727, 32);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(89, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name :";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(txtBoxBloodGroup);
            tabPage4.Controls.Add(mtCmbxParent);
            tabPage4.Controls.Add(txtBoxFilePath);
            tabPage4.Controls.Add(fileLoadButton);
            tabPage4.Controls.Add(pictureBox4);
            tabPage4.Controls.Add(mtTextBoxAddressStudent);
            tabPage4.Controls.Add(mtTextBoxPhoneStudent);
            tabPage4.Controls.Add(mtTextBoxGender);
            tabPage4.Controls.Add(mtTextBoxStudentLastName);
            tabPage4.Controls.Add(mtStudentButton);
            tabPage4.Controls.Add(dateTimePickerStudent);
            tabPage4.Controls.Add(dataGridStudent);
            tabPage4.Controls.Add(lblStudentId);
            tabPage4.Controls.Add(mtTextBoxStudentName);
            tabPage4.ImageKey = "student_icon.png";
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1503, 992);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Student";
            // 
            // txtBoxBloodGroup
            // 
            txtBoxBloodGroup.AnimateReadOnly = false;
            txtBoxBloodGroup.BorderStyle = BorderStyle.None;
            txtBoxBloodGroup.Depth = 0;
            txtBoxBloodGroup.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxBloodGroup.Hint = "Student Blood  Group";
            txtBoxBloodGroup.LeadingIcon = null;
            txtBoxBloodGroup.Location = new Point(305, 190);
            txtBoxBloodGroup.MaxLength = 50;
            txtBoxBloodGroup.MouseState = MaterialSkin.MouseState.OUT;
            txtBoxBloodGroup.Multiline = false;
            txtBoxBloodGroup.Name = "txtBoxBloodGroup";
            txtBoxBloodGroup.Size = new Size(228, 50);
            txtBoxBloodGroup.TabIndex = 25;
            txtBoxBloodGroup.Text = "";
            txtBoxBloodGroup.TrailingIcon = null;
            // 
            // mtCmbxParent
            // 
            mtCmbxParent.AutoResize = false;
            mtCmbxParent.BackColor = Color.FromArgb(255, 255, 255);
            mtCmbxParent.Depth = 0;
            mtCmbxParent.DrawMode = DrawMode.OwnerDrawVariable;
            mtCmbxParent.DropDownHeight = 174;
            mtCmbxParent.DropDownStyle = ComboBoxStyle.DropDownList;
            mtCmbxParent.DropDownWidth = 121;
            mtCmbxParent.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mtCmbxParent.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mtCmbxParent.FormattingEnabled = true;
            mtCmbxParent.Hint = "Parent";
            mtCmbxParent.IntegralHeight = false;
            mtCmbxParent.ItemHeight = 43;
            mtCmbxParent.Location = new Point(55, 189);
            mtCmbxParent.MaxDropDownItems = 4;
            mtCmbxParent.MouseState = MaterialSkin.MouseState.OUT;
            mtCmbxParent.Name = "mtCmbxParent";
            mtCmbxParent.Size = new Size(228, 49);
            mtCmbxParent.StartIndex = 0;
            mtCmbxParent.TabIndex = 24;
            mtCmbxParent.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged_2;
            // 
            // txtBoxFilePath
            // 
            txtBoxFilePath.AnimateReadOnly = false;
            txtBoxFilePath.BackgroundImageLayout = ImageLayout.None;
            txtBoxFilePath.CharacterCasing = CharacterCasing.Normal;
            txtBoxFilePath.Depth = 0;
            txtBoxFilePath.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxFilePath.HideSelection = true;
            txtBoxFilePath.Hint = "File Path";
            txtBoxFilePath.LeadingIcon = null;
            txtBoxFilePath.Location = new Point(559, 190);
            txtBoxFilePath.MaxLength = 32767;
            txtBoxFilePath.MouseState = MaterialSkin.MouseState.OUT;
            txtBoxFilePath.Name = "txtBoxFilePath";
            txtBoxFilePath.PasswordChar = '\0';
            txtBoxFilePath.PrefixSuffixText = null;
            txtBoxFilePath.ReadOnly = false;
            txtBoxFilePath.RightToLeft = RightToLeft.No;
            txtBoxFilePath.SelectedText = "";
            txtBoxFilePath.SelectionLength = 0;
            txtBoxFilePath.SelectionStart = 0;
            txtBoxFilePath.ShortcutsEnabled = true;
            txtBoxFilePath.Size = new Size(228, 48);
            txtBoxFilePath.TabIndex = 23;
            txtBoxFilePath.TabStop = false;
            txtBoxFilePath.TextAlign = HorizontalAlignment.Left;
            txtBoxFilePath.TrailingIcon = null;
            txtBoxFilePath.UseSystemPasswordChar = false;
            // 
            // fileLoadButton
            // 
            fileLoadButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fileLoadButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            fileLoadButton.Depth = 0;
            fileLoadButton.HighEmphasis = true;
            fileLoadButton.Icon = null;
            fileLoadButton.Location = new Point(688, 257);
            fileLoadButton.Margin = new Padding(4, 6, 4, 6);
            fileLoadButton.MouseState = MaterialSkin.MouseState.HOVER;
            fileLoadButton.Name = "fileLoadButton";
            fileLoadButton.NoAccentTextColor = Color.Empty;
            fileLoadButton.Size = new Size(99, 36);
            fileLoadButton.TabIndex = 22;
            fileLoadButton.Text = "File   Load";
            fileLoadButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            fileLoadButton.UseAccentColor = false;
            fileLoadButton.UseVisualStyleBackColor = true;
            fileLoadButton.Click += fileLoadButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(830, 19);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(264, 275);
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // mtTextBoxAddressStudent
            // 
            mtTextBoxAddressStudent.AnimateReadOnly = false;
            mtTextBoxAddressStudent.BorderStyle = BorderStyle.None;
            mtTextBoxAddressStudent.Depth = 0;
            mtTextBoxAddressStudent.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtTextBoxAddressStudent.Hint = "Student Address Enter";
            mtTextBoxAddressStudent.LeadingIcon = null;
            mtTextBoxAddressStudent.Location = new Point(559, 113);
            mtTextBoxAddressStudent.MaxLength = 50;
            mtTextBoxAddressStudent.MouseState = MaterialSkin.MouseState.OUT;
            mtTextBoxAddressStudent.Multiline = false;
            mtTextBoxAddressStudent.Name = "mtTextBoxAddressStudent";
            mtTextBoxAddressStudent.Size = new Size(228, 50);
            mtTextBoxAddressStudent.TabIndex = 20;
            mtTextBoxAddressStudent.Text = "";
            mtTextBoxAddressStudent.TrailingIcon = null;
            // 
            // mtTextBoxPhoneStudent
            // 
            mtTextBoxPhoneStudent.AnimateReadOnly = false;
            mtTextBoxPhoneStudent.BorderStyle = BorderStyle.None;
            mtTextBoxPhoneStudent.Depth = 0;
            mtTextBoxPhoneStudent.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtTextBoxPhoneStudent.Hint = "Student Student Enter";
            mtTextBoxPhoneStudent.LeadingIcon = null;
            mtTextBoxPhoneStudent.Location = new Point(305, 113);
            mtTextBoxPhoneStudent.MaxLength = 50;
            mtTextBoxPhoneStudent.MouseState = MaterialSkin.MouseState.OUT;
            mtTextBoxPhoneStudent.Multiline = false;
            mtTextBoxPhoneStudent.Name = "mtTextBoxPhoneStudent";
            mtTextBoxPhoneStudent.Size = new Size(228, 50);
            mtTextBoxPhoneStudent.TabIndex = 19;
            mtTextBoxPhoneStudent.Text = "";
            mtTextBoxPhoneStudent.TrailingIcon = null;
            // 
            // mtTextBoxGender
            // 
            mtTextBoxGender.AnimateReadOnly = false;
            mtTextBoxGender.BorderStyle = BorderStyle.None;
            mtTextBoxGender.Depth = 0;
            mtTextBoxGender.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtTextBoxGender.Hint = "Student Gender Enter";
            mtTextBoxGender.LeadingIcon = null;
            mtTextBoxGender.Location = new Point(305, 41);
            mtTextBoxGender.MaxLength = 50;
            mtTextBoxGender.MouseState = MaterialSkin.MouseState.OUT;
            mtTextBoxGender.Multiline = false;
            mtTextBoxGender.Name = "mtTextBoxGender";
            mtTextBoxGender.Size = new Size(228, 50);
            mtTextBoxGender.TabIndex = 16;
            mtTextBoxGender.Text = "";
            mtTextBoxGender.TrailingIcon = null;
            // 
            // mtTextBoxStudentLastName
            // 
            mtTextBoxStudentLastName.AnimateReadOnly = false;
            mtTextBoxStudentLastName.BorderStyle = BorderStyle.None;
            mtTextBoxStudentLastName.Depth = 0;
            mtTextBoxStudentLastName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtTextBoxStudentLastName.Hint = "Student Lastname Enter";
            mtTextBoxStudentLastName.LeadingIcon = null;
            mtTextBoxStudentLastName.Location = new Point(55, 113);
            mtTextBoxStudentLastName.MaxLength = 50;
            mtTextBoxStudentLastName.MouseState = MaterialSkin.MouseState.OUT;
            mtTextBoxStudentLastName.Multiline = false;
            mtTextBoxStudentLastName.Name = "mtTextBoxStudentLastName";
            mtTextBoxStudentLastName.Size = new Size(228, 50);
            mtTextBoxStudentLastName.TabIndex = 15;
            mtTextBoxStudentLastName.Text = "";
            mtTextBoxStudentLastName.TrailingIcon = null;
            // 
            // mtStudentButton
            // 
            mtStudentButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mtStudentButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mtStudentButton.Depth = 0;
            mtStudentButton.HighEmphasis = true;
            mtStudentButton.Icon = null;
            mtStudentButton.Location = new Point(604, 257);
            mtStudentButton.Margin = new Padding(4, 6, 4, 6);
            mtStudentButton.MouseState = MaterialSkin.MouseState.HOVER;
            mtStudentButton.Name = "mtStudentButton";
            mtStudentButton.NoAccentTextColor = Color.Empty;
            mtStudentButton.Size = new Size(64, 36);
            mtStudentButton.TabIndex = 14;
            mtStudentButton.Text = "Add";
            mtStudentButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mtStudentButton.UseAccentColor = false;
            mtStudentButton.UseVisualStyleBackColor = true;
            mtStudentButton.Click += mtStudentButton_Click;
            // 
            // dateTimePickerStudent
            // 
            dateTimePickerStudent.Location = new Point(559, 41);
            dateTimePickerStudent.Name = "dateTimePickerStudent";
            dateTimePickerStudent.Size = new Size(250, 27);
            dateTimePickerStudent.TabIndex = 18;
            // 
            // dataGridStudent
            // 
            dataGridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudent.Location = new Point(0, 318);
            dataGridStudent.Name = "dataGridStudent";
            dataGridStudent.RowHeadersWidth = 51;
            dataGridStudent.RowTemplate.Height = 90;
            dataGridStudent.Size = new Size(1079, 222);
            dataGridStudent.TabIndex = 13;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Depth = 0;
            lblStudentId.Enabled = false;
            lblStudentId.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStudentId.Location = new Point(55, 19);
            lblStudentId.MouseState = MaterialSkin.MouseState.HOVER;
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(14, 19);
            lblStudentId.TabIndex = 12;
            lblStudentId.Text = "Id";
            lblStudentId.Visible = false;
            // 
            // mtTextBoxStudentName
            // 
            mtTextBoxStudentName.AnimateReadOnly = false;
            mtTextBoxStudentName.BorderStyle = BorderStyle.None;
            mtTextBoxStudentName.Depth = 0;
            mtTextBoxStudentName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtTextBoxStudentName.Hint = "Student Name Enter";
            mtTextBoxStudentName.LeadingIcon = null;
            mtTextBoxStudentName.Location = new Point(55, 41);
            mtTextBoxStudentName.MaxLength = 50;
            mtTextBoxStudentName.MouseState = MaterialSkin.MouseState.OUT;
            mtTextBoxStudentName.Multiline = false;
            mtTextBoxStudentName.Name = "mtTextBoxStudentName";
            mtTextBoxStudentName.Size = new Size(228, 50);
            mtTextBoxStudentName.TabIndex = 11;
            mtTextBoxStudentName.Text = "";
            mtTextBoxStudentName.TrailingIcon = null;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(mtTextBoxTeacherBranch);
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Controls.Add(mtTextBoxLastName);
            tabPage3.Controls.Add(mtbuttonTeacher);
            tabPage3.Controls.Add(dtGrdTeacher);
            tabPage3.Controls.Add(lblTeacherId);
            tabPage3.Controls.Add(teacherTxtBox);
            tabPage3.ImageKey = "teacher_icon.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1503, 992);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Teacher";
            // 
            // mtTextBoxTeacherBranch
            // 
            mtTextBoxTeacherBranch.AnimateReadOnly = false;
            mtTextBoxTeacherBranch.BorderStyle = BorderStyle.None;
            mtTextBoxTeacherBranch.Depth = 0;
            mtTextBoxTeacherBranch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtTextBoxTeacherBranch.Hint = "Teacher Branch Enter";
            mtTextBoxTeacherBranch.LeadingIcon = null;
            mtTextBoxTeacherBranch.Location = new Point(426, 181);
            mtTextBoxTeacherBranch.MaxLength = 50;
            mtTextBoxTeacherBranch.MouseState = MaterialSkin.MouseState.OUT;
            mtTextBoxTeacherBranch.Multiline = false;
            mtTextBoxTeacherBranch.Name = "mtTextBoxTeacherBranch";
            mtTextBoxTeacherBranch.Size = new Size(228, 50);
            mtTextBoxTeacherBranch.TabIndex = 12;
            mtTextBoxTeacherBranch.Text = "";
            mtTextBoxTeacherBranch.TrailingIcon = null;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(45, 37);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(264, 275);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // mtTextBoxLastName
            // 
            mtTextBoxLastName.AnimateReadOnly = false;
            mtTextBoxLastName.BorderStyle = BorderStyle.None;
            mtTextBoxLastName.Depth = 0;
            mtTextBoxLastName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtTextBoxLastName.Hint = "Teacher Lastname Enter";
            mtTextBoxLastName.LeadingIcon = null;
            mtTextBoxLastName.Location = new Point(426, 109);
            mtTextBoxLastName.MaxLength = 50;
            mtTextBoxLastName.MouseState = MaterialSkin.MouseState.OUT;
            mtTextBoxLastName.Multiline = false;
            mtTextBoxLastName.Name = "mtTextBoxLastName";
            mtTextBoxLastName.Size = new Size(228, 50);
            mtTextBoxLastName.TabIndex = 10;
            mtTextBoxLastName.Text = "";
            mtTextBoxLastName.TrailingIcon = null;
            // 
            // mtbuttonTeacher
            // 
            mtbuttonTeacher.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mtbuttonTeacher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mtbuttonTeacher.Depth = 0;
            mtbuttonTeacher.HighEmphasis = true;
            mtbuttonTeacher.Icon = null;
            mtbuttonTeacher.Location = new Point(426, 251);
            mtbuttonTeacher.Margin = new Padding(4, 6, 4, 6);
            mtbuttonTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            mtbuttonTeacher.Name = "mtbuttonTeacher";
            mtbuttonTeacher.NoAccentTextColor = Color.Empty;
            mtbuttonTeacher.Size = new Size(64, 36);
            mtbuttonTeacher.TabIndex = 9;
            mtbuttonTeacher.Text = "Add";
            mtbuttonTeacher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mtbuttonTeacher.UseAccentColor = false;
            mtbuttonTeacher.UseVisualStyleBackColor = true;
            mtbuttonTeacher.Click += mtbuttonTeacher_Click;
            // 
            // dtGrdTeacher
            // 
            dtGrdTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdTeacher.Location = new Point(426, 324);
            dtGrdTeacher.Name = "dtGrdTeacher";
            dtGrdTeacher.RowHeadersWidth = 51;
            dtGrdTeacher.Size = new Size(641, 222);
            dtGrdTeacher.TabIndex = 8;
            dtGrdTeacher.CellContentClick += dtGrdTeacher_CellContentClick;
            // 
            // lblTeacherId
            // 
            lblTeacherId.AutoSize = true;
            lblTeacherId.Depth = 0;
            lblTeacherId.Enabled = false;
            lblTeacherId.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTeacherId.Location = new Point(426, 15);
            lblTeacherId.MouseState = MaterialSkin.MouseState.HOVER;
            lblTeacherId.Name = "lblTeacherId";
            lblTeacherId.Size = new Size(14, 19);
            lblTeacherId.TabIndex = 7;
            lblTeacherId.Text = "Id";
            lblTeacherId.Visible = false;
            // 
            // teacherTxtBox
            // 
            teacherTxtBox.AnimateReadOnly = false;
            teacherTxtBox.BorderStyle = BorderStyle.None;
            teacherTxtBox.Depth = 0;
            teacherTxtBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            teacherTxtBox.Hint = "Teacher Name Enter";
            teacherTxtBox.LeadingIcon = null;
            teacherTxtBox.Location = new Point(426, 37);
            teacherTxtBox.MaxLength = 50;
            teacherTxtBox.MouseState = MaterialSkin.MouseState.OUT;
            teacherTxtBox.Multiline = false;
            teacherTxtBox.Name = "teacherTxtBox";
            teacherTxtBox.Size = new Size(228, 50);
            teacherTxtBox.TabIndex = 6;
            teacherTxtBox.Text = "";
            teacherTxtBox.TrailingIcon = null;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(materialButton1);
            tabPage2.Controls.Add(datagrdClass);
            tabPage2.Controls.Add(lblClassId);
            tabPage2.Controls.Add(txtBoxClassName);
            tabPage2.ImageKey = "class_icon.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1503, 992);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Class";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(61, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 275);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(492, 112);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "ADD";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // datagrdClass
            // 
            datagrdClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrdClass.Location = new Point(492, 321);
            datagrdClass.Name = "datagrdClass";
            datagrdClass.RowHeadersWidth = 51;
            datagrdClass.Size = new Size(369, 222);
            datagrdClass.TabIndex = 4;
            // 
            // lblClassId
            // 
            lblClassId.AutoSize = true;
            lblClassId.Depth = 0;
            lblClassId.Enabled = false;
            lblClassId.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblClassId.Location = new Point(492, 12);
            lblClassId.MouseState = MaterialSkin.MouseState.HOVER;
            lblClassId.Name = "lblClassId";
            lblClassId.Size = new Size(14, 19);
            lblClassId.TabIndex = 3;
            lblClassId.Text = "Id";
            lblClassId.Visible = false;
            // 
            // txtBoxClassName
            // 
            txtBoxClassName.AnimateReadOnly = false;
            txtBoxClassName.BorderStyle = BorderStyle.None;
            txtBoxClassName.Depth = 0;
            txtBoxClassName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxClassName.Hint = "Class Name Enter";
            txtBoxClassName.LeadingIcon = null;
            txtBoxClassName.Location = new Point(492, 34);
            txtBoxClassName.MaxLength = 50;
            txtBoxClassName.MouseState = MaterialSkin.MouseState.OUT;
            txtBoxClassName.Multiline = false;
            txtBoxClassName.Name = "txtBoxClassName";
            txtBoxClassName.Size = new Size(228, 50);
            txtBoxClassName.TabIndex = 2;
            txtBoxClassName.Text = "";
            txtBoxClassName.TrailingIcon = null;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.ImageKey = "home_icon.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1521, 992);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(790, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 275);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(743, 462);
            dataGridView1.TabIndex = 0;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = ımageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1529, 1035);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(lblClassAssId);
            tabPage5.Controls.Add(pictureBox5);
            tabPage5.Controls.Add(mtCmBoxClassAss);
            tabPage5.Controls.Add(classAssignmentAdd);
            tabPage5.Controls.Add(cmbxTeacher);
            tabPage5.Controls.Add(cmbBoxClassAssignment);
            tabPage5.Controls.Add(dataGridClassAssignment);
            tabPage5.ImageKey = "folder.png";
            tabPage5.Location = new Point(4, 39);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1521, 992);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Class Assignment";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblClassAssId
            // 
            lblClassAssId.AutoSize = true;
            lblClassAssId.Location = new Point(104, 72);
            lblClassAssId.Name = "lblClassAssId";
            lblClassAssId.Size = new Size(50, 20);
            lblClassAssId.TabIndex = 6;
            lblClassAssId.Text = "label1";
            lblClassAssId.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(846, 147);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(264, 275);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // mtCmBoxClassAss
            // 
            mtCmBoxClassAss.AutoResize = false;
            mtCmBoxClassAss.BackColor = Color.FromArgb(255, 255, 255);
            mtCmBoxClassAss.Depth = 0;
            mtCmBoxClassAss.DrawMode = DrawMode.OwnerDrawVariable;
            mtCmBoxClassAss.DropDownHeight = 174;
            mtCmBoxClassAss.DropDownStyle = ComboBoxStyle.DropDownList;
            mtCmBoxClassAss.DropDownWidth = 121;
            mtCmBoxClassAss.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mtCmBoxClassAss.ForeColor = Color.White;
            mtCmBoxClassAss.FormattingEnabled = true;
            mtCmBoxClassAss.IntegralHeight = false;
            mtCmBoxClassAss.ItemHeight = 43;
            mtCmBoxClassAss.Location = new Point(611, 51);
            mtCmBoxClassAss.MaxDropDownItems = 4;
            mtCmBoxClassAss.MouseState = MaterialSkin.MouseState.OUT;
            mtCmBoxClassAss.Name = "mtCmBoxClassAss";
            mtCmBoxClassAss.Size = new Size(180, 49);
            mtCmBoxClassAss.StartIndex = 0;
            mtCmBoxClassAss.TabIndex = 4;
            mtCmBoxClassAss.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged_1;
            // 
            // classAssignmentAdd
            // 
            classAssignmentAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            classAssignmentAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            classAssignmentAdd.Depth = 0;
            classAssignmentAdd.HighEmphasis = true;
            classAssignmentAdd.Icon = null;
            classAssignmentAdd.Location = new Point(192, 137);
            classAssignmentAdd.Margin = new Padding(4, 6, 4, 6);
            classAssignmentAdd.MouseState = MaterialSkin.MouseState.HOVER;
            classAssignmentAdd.Name = "classAssignmentAdd";
            classAssignmentAdd.NoAccentTextColor = Color.Empty;
            classAssignmentAdd.Size = new Size(64, 36);
            classAssignmentAdd.TabIndex = 3;
            classAssignmentAdd.Text = "ADD";
            classAssignmentAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            classAssignmentAdd.UseAccentColor = false;
            classAssignmentAdd.UseVisualStyleBackColor = true;
            classAssignmentAdd.Click += classAssignmentAdd_Click;
            // 
            // cmbxTeacher
            // 
            cmbxTeacher.AutoResize = false;
            cmbxTeacher.BackColor = Color.FromArgb(255, 255, 255);
            cmbxTeacher.Depth = 0;
            cmbxTeacher.DrawMode = DrawMode.OwnerDrawVariable;
            cmbxTeacher.DropDownHeight = 174;
            cmbxTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxTeacher.DropDownWidth = 121;
            cmbxTeacher.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbxTeacher.ForeColor = Color.White;
            cmbxTeacher.FormattingEnabled = true;
            cmbxTeacher.IntegralHeight = false;
            cmbxTeacher.ItemHeight = 43;
            cmbxTeacher.Location = new Point(400, 51);
            cmbxTeacher.MaxDropDownItems = 4;
            cmbxTeacher.MouseState = MaterialSkin.MouseState.OUT;
            cmbxTeacher.Name = "cmbxTeacher";
            cmbxTeacher.Size = new Size(180, 49);
            cmbxTeacher.StartIndex = 0;
            cmbxTeacher.TabIndex = 2;
            cmbxTeacher.SelectedIndexChanged += cmbxTeacher_SelectedIndexChanged;
            // 
            // cmbBoxClassAssignment
            // 
            cmbBoxClassAssignment.AutoResize = false;
            cmbBoxClassAssignment.BackColor = Color.FromArgb(255, 255, 255);
            cmbBoxClassAssignment.Depth = 0;
            cmbBoxClassAssignment.DrawMode = DrawMode.OwnerDrawVariable;
            cmbBoxClassAssignment.DropDownHeight = 174;
            cmbBoxClassAssignment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxClassAssignment.DropDownWidth = 121;
            cmbBoxClassAssignment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbBoxClassAssignment.ForeColor = Color.White;
            cmbBoxClassAssignment.FormattingEnabled = true;
            cmbBoxClassAssignment.IntegralHeight = false;
            cmbBoxClassAssignment.ItemHeight = 43;
            cmbBoxClassAssignment.Location = new Point(192, 51);
            cmbBoxClassAssignment.MaxDropDownItems = 4;
            cmbBoxClassAssignment.MouseState = MaterialSkin.MouseState.OUT;
            cmbBoxClassAssignment.Name = "cmbBoxClassAssignment";
            cmbBoxClassAssignment.Size = new Size(180, 49);
            cmbBoxClassAssignment.StartIndex = 0;
            cmbBoxClassAssignment.TabIndex = 1;
            cmbBoxClassAssignment.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // dataGridClassAssignment
            // 
            dataGridClassAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClassAssignment.Location = new Point(180, 449);
            dataGridClassAssignment.Name = "dataGridClassAssignment";
            dataGridClassAssignment.RowHeadersWidth = 51;
            dataGridClassAssignment.Size = new Size(505, 188);
            dataGridClassAssignment.TabIndex = 0;
            dataGridClassAssignment.CellContentClick += dataGridClassAssignment_CellContentClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1535, 1102);
            Controls.Add(lblUserName);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerAutoShow = true;
            DrawerBackgroundWithAccent = true;
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "School Information Management";
            Load += Form1_Load;
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrdTeacher).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagrdClass).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialTabControl1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridClassAssignment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList ımageList1;
        private Label lblUserName;
        private TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTextBox mtTextBoxAddressStudent;
        private MaterialSkin.Controls.MaterialTextBox mtTextBoxPhoneStudent;
        private MaterialSkin.Controls.MaterialTextBox mtTextBoxGender;
        private MaterialSkin.Controls.MaterialTextBox mtTextBoxStudentLastName;
        private MaterialSkin.Controls.MaterialButton mtStudentButton;
        private DateTimePicker dateTimePickerStudent;
        private DataGridView dataGridStudent;
        private MaterialSkin.Controls.MaterialLabel lblStudentId;
        private MaterialSkin.Controls.MaterialTextBox mtTextBoxStudentName;
        private TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTextBox mtTextBoxLastName;
        private MaterialSkin.Controls.MaterialButton mtbuttonTeacher;
        private DataGridView dtGrdTeacher;
        private MaterialSkin.Controls.MaterialLabel lblTeacherId;
        private MaterialSkin.Controls.MaterialTextBox teacherTxtBox;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DataGridView datagrdClass;
        private MaterialSkin.Controls.MaterialLabel lblClassId;
        private MaterialSkin.Controls.MaterialTextBox txtBoxClassName;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage5;
        private DataGridView dataGridClassAssignment;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxClassAssignment;
        private MaterialSkin.Controls.MaterialButton classAssignmentAdd;
        private MaterialSkin.Controls.MaterialComboBox cmbxTeacher;
        private MaterialSkin.Controls.MaterialComboBox mtCmBoxClassAss;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Label lblClassAssId;
        private OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialButton fileLoadButton;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxFilePath;
        private MaterialSkin.Controls.MaterialComboBox mtCmbxParent;
        private MaterialSkin.Controls.MaterialTextBox txtBoxBloodGroup;
        private MaterialSkin.Controls.MaterialTextBox mtTextBoxTeacherBranch;
    }
}
