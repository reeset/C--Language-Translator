namespace lang_files
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckFrench = new System.Windows.Forms.CheckBox();
            this.ckDuctch = new System.Windows.Forms.CheckBox();
            this.ckFinnish = new System.Windows.Forms.CheckBox();
            this.ckChinese = new System.Windows.Forms.CheckBox();
            this.ckGerman = new System.Windows.Forms.CheckBox();
            this.ckGreek = new System.Windows.Forms.CheckBox();
            this.ckHindi = new System.Windows.Forms.CheckBox();
            this.ckItalian = new System.Windows.Forms.CheckBox();
            this.ckJapanese = new System.Windows.Forms.CheckBox();
            this.ckPoland = new System.Windows.Forms.CheckBox();
            this.ckRussian = new System.Windows.Forms.CheckBox();
            this.ckSpanish = new System.Windows.Forms.CheckBox();
            this.ckSwedish = new System.Windows.Forms.CheckBox();
            this.ckTurkish = new System.Windows.Forms.CheckBox();
            this.ckWelsh = new System.Windows.Forms.CheckBox();
            this.ckPortuguese = new System.Windows.Forms.CheckBox();
            this.rdEnglish = new System.Windows.Forms.RadioButton();
            this.lbstatus = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdDirectory = new System.Windows.Forms.PictureBox();
            this.cmdOpen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ckUrdu = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "C# Project File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Languages:";
            // 
            // ckFrench
            // 
            this.ckFrench.AutoSize = true;
            this.ckFrench.Location = new System.Drawing.Point(20, 278);
            this.ckFrench.Name = "ckFrench";
            this.ckFrench.Size = new System.Drawing.Size(74, 21);
            this.ckFrench.TabIndex = 5;
            this.ckFrench.Tag = "fr";
            this.ckFrench.Text = "French";
            this.ckFrench.UseVisualStyleBackColor = true;
            // 
            // ckDuctch
            // 
            this.ckDuctch.AutoSize = true;
            this.ckDuctch.Location = new System.Drawing.Point(20, 224);
            this.ckDuctch.Name = "ckDuctch";
            this.ckDuctch.Size = new System.Drawing.Size(67, 21);
            this.ckDuctch.TabIndex = 6;
            this.ckDuctch.Tag = "nl";
            this.ckDuctch.Text = "Dutch";
            this.ckDuctch.UseVisualStyleBackColor = true;
            // 
            // ckFinnish
            // 
            this.ckFinnish.AutoSize = true;
            this.ckFinnish.Location = new System.Drawing.Point(20, 251);
            this.ckFinnish.Name = "ckFinnish";
            this.ckFinnish.Size = new System.Drawing.Size(75, 21);
            this.ckFinnish.TabIndex = 7;
            this.ckFinnish.Tag = "fi";
            this.ckFinnish.Text = "Finnish";
            this.ckFinnish.UseVisualStyleBackColor = true;
            // 
            // ckChinese
            // 
            this.ckChinese.AutoSize = true;
            this.ckChinese.Location = new System.Drawing.Point(20, 197);
            this.ckChinese.Name = "ckChinese";
            this.ckChinese.Size = new System.Drawing.Size(125, 21);
            this.ckChinese.TabIndex = 8;
            this.ckChinese.Tag = "zh-CHT";
            this.ckChinese.Text = "Chinese (Trad)";
            this.ckChinese.UseVisualStyleBackColor = true;
            // 
            // ckGerman
            // 
            this.ckGerman.AutoSize = true;
            this.ckGerman.Location = new System.Drawing.Point(21, 305);
            this.ckGerman.Name = "ckGerman";
            this.ckGerman.Size = new System.Drawing.Size(81, 21);
            this.ckGerman.TabIndex = 9;
            this.ckGerman.Tag = "de";
            this.ckGerman.Text = "German";
            this.ckGerman.UseVisualStyleBackColor = true;
            // 
            // ckGreek
            // 
            this.ckGreek.AutoSize = true;
            this.ckGreek.Location = new System.Drawing.Point(153, 197);
            this.ckGreek.Name = "ckGreek";
            this.ckGreek.Size = new System.Drawing.Size(69, 21);
            this.ckGreek.TabIndex = 10;
            this.ckGreek.Tag = "el";
            this.ckGreek.Text = "Greek";
            this.ckGreek.UseVisualStyleBackColor = true;
            // 
            // ckHindi
            // 
            this.ckHindi.AutoSize = true;
            this.ckHindi.Location = new System.Drawing.Point(153, 224);
            this.ckHindi.Name = "ckHindi";
            this.ckHindi.Size = new System.Drawing.Size(62, 21);
            this.ckHindi.TabIndex = 11;
            this.ckHindi.Tag = "hi";
            this.ckHindi.Text = "Hindi";
            this.ckHindi.UseVisualStyleBackColor = true;
            // 
            // ckItalian
            // 
            this.ckItalian.AutoSize = true;
            this.ckItalian.Location = new System.Drawing.Point(153, 251);
            this.ckItalian.Name = "ckItalian";
            this.ckItalian.Size = new System.Drawing.Size(67, 21);
            this.ckItalian.TabIndex = 12;
            this.ckItalian.Tag = "it";
            this.ckItalian.Text = "Italian";
            this.ckItalian.UseVisualStyleBackColor = true;
            // 
            // ckJapanese
            // 
            this.ckJapanese.AutoSize = true;
            this.ckJapanese.Location = new System.Drawing.Point(153, 278);
            this.ckJapanese.Name = "ckJapanese";
            this.ckJapanese.Size = new System.Drawing.Size(92, 21);
            this.ckJapanese.TabIndex = 13;
            this.ckJapanese.Tag = "ja";
            this.ckJapanese.Text = "Japanese";
            this.ckJapanese.UseVisualStyleBackColor = true;
            // 
            // ckPoland
            // 
            this.ckPoland.AutoSize = true;
            this.ckPoland.Location = new System.Drawing.Point(153, 305);
            this.ckPoland.Name = "ckPoland";
            this.ckPoland.Size = new System.Drawing.Size(68, 21);
            this.ckPoland.TabIndex = 14;
            this.ckPoland.Tag = "pl";
            this.ckPoland.Text = "Polish";
            this.ckPoland.UseVisualStyleBackColor = true;
            // 
            // ckRussian
            // 
            this.ckRussian.AutoSize = true;
            this.ckRussian.Location = new System.Drawing.Point(268, 224);
            this.ckRussian.Name = "ckRussian";
            this.ckRussian.Size = new System.Drawing.Size(81, 21);
            this.ckRussian.TabIndex = 15;
            this.ckRussian.Tag = "ru";
            this.ckRussian.Text = "Russian";
            this.ckRussian.UseVisualStyleBackColor = true;
            // 
            // ckSpanish
            // 
            this.ckSpanish.AutoSize = true;
            this.ckSpanish.Location = new System.Drawing.Point(268, 251);
            this.ckSpanish.Name = "ckSpanish";
            this.ckSpanish.Size = new System.Drawing.Size(81, 21);
            this.ckSpanish.TabIndex = 16;
            this.ckSpanish.Tag = "es";
            this.ckSpanish.Text = "Spanish";
            this.ckSpanish.UseVisualStyleBackColor = true;
            // 
            // ckSwedish
            // 
            this.ckSwedish.AutoSize = true;
            this.ckSwedish.Location = new System.Drawing.Point(268, 278);
            this.ckSwedish.Name = "ckSwedish";
            this.ckSwedish.Size = new System.Drawing.Size(82, 21);
            this.ckSwedish.TabIndex = 17;
            this.ckSwedish.Tag = "sv";
            this.ckSwedish.Text = "Swedish";
            this.ckSwedish.UseVisualStyleBackColor = true;
            // 
            // ckTurkish
            // 
            this.ckTurkish.AutoSize = true;
            this.ckTurkish.Location = new System.Drawing.Point(268, 305);
            this.ckTurkish.Name = "ckTurkish";
            this.ckTurkish.Size = new System.Drawing.Size(77, 21);
            this.ckTurkish.TabIndex = 18;
            this.ckTurkish.Tag = "tr";
            this.ckTurkish.Text = "Turkish";
            this.ckTurkish.UseVisualStyleBackColor = true;
            // 
            // ckWelsh
            // 
            this.ckWelsh.AutoSize = true;
            this.ckWelsh.Location = new System.Drawing.Point(401, 224);
            this.ckWelsh.Name = "ckWelsh";
            this.ckWelsh.Size = new System.Drawing.Size(69, 21);
            this.ckWelsh.TabIndex = 19;
            this.ckWelsh.Tag = "cy";
            this.ckWelsh.Text = "Welsh";
            this.ckWelsh.UseVisualStyleBackColor = true;
            // 
            // ckPortuguese
            // 
            this.ckPortuguese.AutoSize = true;
            this.ckPortuguese.Location = new System.Drawing.Point(268, 197);
            this.ckPortuguese.Name = "ckPortuguese";
            this.ckPortuguese.Size = new System.Drawing.Size(103, 21);
            this.ckPortuguese.TabIndex = 20;
            this.ckPortuguese.Tag = "pt";
            this.ckPortuguese.Text = "Portuguese";
            this.ckPortuguese.UseVisualStyleBackColor = true;
            // 
            // rdEnglish
            // 
            this.rdEnglish.AutoSize = true;
            this.rdEnglish.Location = new System.Drawing.Point(12, 142);
            this.rdEnglish.Name = "rdEnglish";
            this.rdEnglish.Size = new System.Drawing.Size(139, 21);
            this.rdEnglish.TabIndex = 21;
            this.rdEnglish.TabStop = true;
            this.rdEnglish.Text = "Generate English";
            this.rdEnglish.UseVisualStyleBackColor = true;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(86, 352);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(46, 17);
            this.lbstatus.TabIndex = 22;
            this.lbstatus.Text = "label3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 22);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "C:\\Users\\reeset\\Documents\\GitHub\\marcedit_language_files\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Language Save File Directory:";
            // 
            // cmdDirectory
            // 
            this.cmdDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDirectory.Image = ((System.Drawing.Image)(resources.GetObject("cmdDirectory.Image")));
            this.cmdDirectory.Location = new System.Drawing.Point(355, 104);
            this.cmdDirectory.Name = "cmdDirectory";
            this.cmdDirectory.Size = new System.Drawing.Size(26, 26);
            this.cmdDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdDirectory.TabIndex = 25;
            this.cmdDirectory.TabStop = false;
            this.cmdDirectory.Click += new System.EventHandler(this.cmdDirectory_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Image = ((System.Drawing.Image)(resources.GetObject("cmdOpen.Image")));
            this.cmdOpen.Location = new System.Drawing.Point(355, 34);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(26, 26);
            this.cmdOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdOpen.TabIndex = 26;
            this.cmdOpen.TabStop = false;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // ckUrdu
            // 
            this.ckUrdu.AutoSize = true;
            this.ckUrdu.Location = new System.Drawing.Point(401, 197);
            this.ckUrdu.Name = "ckUrdu";
            this.ckUrdu.Size = new System.Drawing.Size(61, 21);
            this.ckUrdu.TabIndex = 28;
            this.ckUrdu.Tag = "ur";
            this.ckUrdu.Text = "Urdu";
            this.ckUrdu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 388);
            this.Controls.Add(this.ckUrdu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.cmdDirectory);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.rdEnglish);
            this.Controls.Add(this.ckPortuguese);
            this.Controls.Add(this.ckWelsh);
            this.Controls.Add(this.ckTurkish);
            this.Controls.Add(this.ckSwedish);
            this.Controls.Add(this.ckSpanish);
            this.Controls.Add(this.ckRussian);
            this.Controls.Add(this.ckPoland);
            this.Controls.Add(this.ckJapanese);
            this.Controls.Add(this.ckItalian);
            this.Controls.Add(this.ckHindi);
            this.Controls.Add(this.ckGreek);
            this.Controls.Add(this.ckGerman);
            this.Controls.Add(this.ckChinese);
            this.Controls.Add(this.ckFinnish);
            this.Controls.Add(this.ckDuctch);
            this.Controls.Add(this.ckFrench);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cmdDirectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckFrench;
        private System.Windows.Forms.CheckBox ckDuctch;
        private System.Windows.Forms.CheckBox ckFinnish;
        private System.Windows.Forms.CheckBox ckChinese;
        private System.Windows.Forms.CheckBox ckGerman;
        private System.Windows.Forms.CheckBox ckGreek;
        private System.Windows.Forms.CheckBox ckHindi;
        private System.Windows.Forms.CheckBox ckItalian;
        private System.Windows.Forms.CheckBox ckJapanese;
        private System.Windows.Forms.CheckBox ckPoland;
        private System.Windows.Forms.CheckBox ckRussian;
        private System.Windows.Forms.CheckBox ckSpanish;
        private System.Windows.Forms.CheckBox ckSwedish;
        private System.Windows.Forms.CheckBox ckTurkish;
        private System.Windows.Forms.CheckBox ckWelsh;
        private System.Windows.Forms.CheckBox ckPortuguese;
        private System.Windows.Forms.RadioButton rdEnglish;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox cmdDirectory;
        private System.Windows.Forms.PictureBox cmdOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox ckUrdu;
    }
}

