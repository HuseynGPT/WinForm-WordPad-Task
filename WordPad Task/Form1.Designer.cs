namespace WordPad_Task
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
            richTextBox1 = new RichTextBox();
            ToolsPanel = new Panel();
            button1 = new Button();
            SaveBtn = new Button();
            LoadBtn = new Button();
            regularBtn = new Button();
            StrikeoutBtn = new Button();
            UnderlinedBtn = new Button();
            boldFontStyleBtn = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            fontsComboBox = new ComboBox();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            ToolsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 339);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // ToolsPanel
            // 
            ToolsPanel.Controls.Add(button1);
            ToolsPanel.Controls.Add(SaveBtn);
            ToolsPanel.Controls.Add(LoadBtn);
            ToolsPanel.Controls.Add(regularBtn);
            ToolsPanel.Controls.Add(StrikeoutBtn);
            ToolsPanel.Controls.Add(UnderlinedBtn);
            ToolsPanel.Controls.Add(boldFontStyleBtn);
            ToolsPanel.Controls.Add(label3);
            ToolsPanel.Controls.Add(comboBox1);
            ToolsPanel.Controls.Add(label2);
            ToolsPanel.Controls.Add(label1);
            ToolsPanel.Controls.Add(fontsComboBox);
            ToolsPanel.Dock = DockStyle.Top;
            ToolsPanel.Location = new Point(0, 0);
            ToolsPanel.Name = "ToolsPanel";
            ToolsPanel.Size = new Size(800, 100);
            ToolsPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(360, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Transparent;
            SaveBtn.BackgroundImage = Properties.Resources.save_96px;
            SaveBtn.BackgroundImageLayout = ImageLayout.Zoom;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Location = new Point(675, 9);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 72);
            SaveBtn.TabIndex = 12;
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.Transparent;
            LoadBtn.BackgroundImage = Properties.Resources.Load_Resume_Template_96px;
            LoadBtn.BackgroundImageLayout = ImageLayout.Zoom;
            LoadBtn.FlatStyle = FlatStyle.Flat;
            LoadBtn.Location = new Point(577, 9);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(75, 72);
            LoadBtn.TabIndex = 11;
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // regularBtn
            // 
            regularBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            regularBtn.Location = new Point(211, 34);
            regularBtn.Name = "regularBtn";
            regularBtn.Size = new Size(28, 24);
            regularBtn.TabIndex = 8;
            regularBtn.Text = "R";
            regularBtn.UseVisualStyleBackColor = true;
            regularBtn.Click += regularBtn_Click;
            // 
            // StrikeoutBtn
            // 
            StrikeoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point);
            StrikeoutBtn.Location = new Point(313, 33);
            StrikeoutBtn.Name = "StrikeoutBtn";
            StrikeoutBtn.Size = new Size(28, 24);
            StrikeoutBtn.TabIndex = 7;
            StrikeoutBtn.Text = "S";
            StrikeoutBtn.UseVisualStyleBackColor = true;
            StrikeoutBtn.Click += StrikeoutBtn_Click;
            // 
            // UnderlinedBtn
            // 
            UnderlinedBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            UnderlinedBtn.Location = new Point(279, 33);
            UnderlinedBtn.Name = "UnderlinedBtn";
            UnderlinedBtn.Size = new Size(28, 24);
            UnderlinedBtn.TabIndex = 6;
            UnderlinedBtn.Text = "U";
            UnderlinedBtn.UseVisualStyleBackColor = true;
            UnderlinedBtn.Click += UnderlinedBtn_Click;
            // 
            // boldFontStyleBtn
            // 
            boldFontStyleBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            boldFontStyleBtn.Location = new Point(245, 34);
            boldFontStyleBtn.Name = "boldFontStyleBtn";
            boldFontStyleBtn.Size = new Size(28, 24);
            boldFontStyleBtn.TabIndex = 5;
            boldFontStyleBtn.Text = "B";
            boldFontStyleBtn.UseVisualStyleBackColor = true;
            boldFontStyleBtn.Click += boldFontStyleBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 15);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "FontStyle";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "25", "28", "36", "48", "72" });
            comboBox1.Location = new Point(155, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(38, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 15);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 15);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Fonts";
            // 
            // fontsComboBox
            // 
            fontsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fontsComboBox.FormattingEnabled = true;
            fontsComboBox.Location = new Point(12, 33);
            fontsComboBox.Name = "fontsComboBox";
            fontsComboBox.Size = new Size(121, 23);
            fontsComboBox.TabIndex = 0;
            fontsComboBox.SelectedIndexChanged += fontsComboBox_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ToolsPanel);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "WordPad";
            Load += Form1_Load;
            ToolsPanel.ResumeLayout(false);
            ToolsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel ToolsPanel;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ComboBox fontsComboBox;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button regularBtn;
        private Button StrikeoutBtn;
        private Button UnderlinedBtn;
        private Button boldFontStyleBtn;
        private Button SaveBtn;
        private Button LoadBtn;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
    }
}