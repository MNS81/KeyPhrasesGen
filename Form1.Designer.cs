namespace KeyPhrasesGen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabControl = new TabControl();
            TabPage1 = new TabPage();
            panel1 = new Panel();
            GenerateButton = new Button();
            File2Button = new Button();
            File1Button = new Button();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            AuthorLabel = new Label();
            AuthorLinkLabel = new LinkLabel();
            AboutProgramLabel = new Label();
            PictureAbout = new PictureBox();
            AboutTitleLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            TabControl.SuspendLayout();
            TabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureAbout).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(213, 163);
            TabControl.TabIndex = 0;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(panel1);
            TabPage1.Location = new Point(4, 24);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(205, 135);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Генератор";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(GenerateButton);
            panel1.Controls.Add(File2Button);
            panel1.Controls.Add(File1Button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 129);
            panel1.TabIndex = 0;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(0, 75);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(199, 53);
            GenerateButton.TabIndex = 3;
            GenerateButton.Text = "Применить";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // File2Button
            // 
            File2Button.Location = new Point(0, 32);
            File2Button.Name = "File2Button";
            File2Button.Size = new Size(199, 23);
            File2Button.TabIndex = 1;
            File2Button.Text = "Выбрать файл";
            File2Button.UseVisualStyleBackColor = true;
            File2Button.Click += File2Button_Click;
            // 
            // File1Button
            // 
            File1Button.Location = new Point(0, 3);
            File1Button.Name = "File1Button";
            File1Button.Size = new Size(199, 23);
            File1Button.TabIndex = 0;
            File1Button.Text = "Выбрать файл";
            File1Button.UseVisualStyleBackColor = true;
            File1Button.Click += File1Button_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(205, 135);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "О программе";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(AuthorLabel);
            panel2.Controls.Add(AuthorLinkLabel);
            panel2.Controls.Add(AboutProgramLabel);
            panel2.Controls.Add(PictureAbout);
            panel2.Controls.Add(AboutTitleLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 129);
            panel2.TabIndex = 0;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(38, 112);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(71, 15);
            AuthorLabel.TabIndex = 4;
            AuthorLabel.Text = "Разработал";
            // 
            // AuthorLinkLabel
            // 
            AuthorLinkLabel.AutoSize = true;
            AuthorLinkLabel.Location = new Point(106, 112);
            AuthorLinkLabel.Name = "AuthorLinkLabel";
            AuthorLinkLabel.Size = new Size(48, 15);
            AuthorLinkLabel.TabIndex = 3;
            AuthorLinkLabel.TabStop = true;
            AuthorLinkLabel.Text = "MNS81";
            AuthorLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            AuthorLinkLabel.LinkClicked += AuthorLinkLabel_LinkClicked;
            // 
            // AboutProgramLabel
            // 
            AboutProgramLabel.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AboutProgramLabel.Location = new Point(92, 20);
            AboutProgramLabel.Name = "AboutProgramLabel";
            AboutProgramLabel.Size = new Size(100, 92);
            AboutProgramLabel.TabIndex = 2;
            AboutProgramLabel.Text = "Программа получает списки ключей и объединяет их в отсортированный список уникальных комбинаций.";
            // 
            // PictureAbout
            // 
            PictureAbout.Image = Properties.Resources.Title;
            PictureAbout.Location = new Point(5, 15);
            PictureAbout.Name = "PictureAbout";
            PictureAbout.Size = new Size(81, 92);
            PictureAbout.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureAbout.TabIndex = 1;
            PictureAbout.TabStop = false;
            // 
            // AboutTitleLabel
            // 
            AboutTitleLabel.Location = new Point(2, -3);
            AboutTitleLabel.Name = "AboutTitleLabel";
            AboutTitleLabel.Size = new Size(194, 15);
            AboutTitleLabel.TabIndex = 0;
            AboutTitleLabel.Text = "Генератор ключевых фраз";
            AboutTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 163);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Генератор ключевых фраз";
            TabControl.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureAbout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabPage1;
        private TabPage tabPage2;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Button File1Button;
        private SaveFileDialog saveFileDialog1;
        private Button GenerateButton;
        private Button File2Button;
        private Panel panel2;
        private PictureBox PictureAbout;
        private Label AboutTitleLabel;
        private Label AboutProgramLabel;
        private Label AuthorLabel;
        private LinkLabel AuthorLinkLabel;
    }
}
