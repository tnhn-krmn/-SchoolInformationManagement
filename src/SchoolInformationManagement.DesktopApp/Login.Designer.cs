namespace SchoolInformationManagement.DesktopApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtBoxUserName = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txtBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            label2 = new Label();
            ımageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.AnimateReadOnly = false;
            txtBoxUserName.BackgroundImageLayout = ImageLayout.None;
            txtBoxUserName.CharacterCasing = CharacterCasing.Normal;
            txtBoxUserName.Depth = 0;
            txtBoxUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxUserName.HideSelection = true;
            txtBoxUserName.LeadingIcon = null;
            txtBoxUserName.Location = new Point(190, 408);
            txtBoxUserName.MaxLength = 32767;
            txtBoxUserName.MouseState = MaterialSkin.MouseState.OUT;
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.PasswordChar = '\0';
            txtBoxUserName.PrefixSuffixText = null;
            txtBoxUserName.ReadOnly = false;
            txtBoxUserName.RightToLeft = RightToLeft.No;
            txtBoxUserName.SelectedText = "";
            txtBoxUserName.SelectionLength = 0;
            txtBoxUserName.SelectionStart = 0;
            txtBoxUserName.ShortcutsEnabled = true;
            txtBoxUserName.Size = new Size(312, 48);
            txtBoxUserName.TabIndex = 0;
            txtBoxUserName.TabStop = false;
            txtBoxUserName.TextAlign = HorizontalAlignment.Left;
            txtBoxUserName.TrailingIcon = null;
            txtBoxUserName.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(190, 604);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(312, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Login";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.AnimateReadOnly = false;
            txtBoxPassword.BackgroundImageLayout = ImageLayout.None;
            txtBoxPassword.CharacterCasing = CharacterCasing.Normal;
            txtBoxPassword.Depth = 0;
            txtBoxPassword.ErrorMessage = "Hatalı parola girdiniz";
            txtBoxPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxPassword.HideSelection = true;
            txtBoxPassword.ImeMode = ImeMode.Alpha;
            txtBoxPassword.LeadingIcon = null;
            txtBoxPassword.Location = new Point(190, 514);
            txtBoxPassword.MaxLength = 32767;
            txtBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '\0';
            txtBoxPassword.PrefixSuffixText = null;
            txtBoxPassword.ReadOnly = false;
            txtBoxPassword.RightToLeft = RightToLeft.No;
            txtBoxPassword.SelectedText = "";
            txtBoxPassword.SelectionLength = 0;
            txtBoxPassword.SelectionStart = 0;
            txtBoxPassword.ShortcutsEnabled = true;
            txtBoxPassword.ShowAssistiveText = true;
            txtBoxPassword.Size = new Size(312, 64);
            txtBoxPassword.TabIndex = 2;
            txtBoxPassword.TabStop = false;
            txtBoxPassword.TextAlign = HorizontalAlignment.Left;
            txtBoxPassword.TrailingIcon = null;
            txtBoxPassword.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 373);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "Username :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 482);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Password  :";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "key.ico");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(217, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 256);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(681, 696);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxPassword);
            Controls.Add(materialButton1);
            Controls.Add(txtBoxUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtBoxUserName;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxPassword;
        private Label label1;
        private Label label2;
        private ImageList ımageList1;
        private PictureBox pictureBox1;
    }
}