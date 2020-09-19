namespace TranspositionCipher
{
    partial class GlobalCipherForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalCipherForm));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lockedBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.engLanguageRadioBtn = new System.Windows.Forms.RadioButton();
            this.rusLanguageRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            resources.ApplyResources(this.inputTextBox, "inputTextBox");
            this.inputTextBox.Name = "inputTextBox";
            // 
            // outputTextBox
            // 
            resources.ApplyResources(this.outputTextBox, "outputTextBox");
            this.outputTextBox.Name = "outputTextBox";
            // 
            // keyTextBox
            // 
            resources.ApplyResources(this.keyTextBox, "keyTextBox");
            this.keyTextBox.Name = "keyTextBox";
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.decryptRadioButton);
            this.groupBox1.Controls.Add(this.encryptRadioButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // decryptRadioButton
            // 
            resources.ApplyResources(this.decryptRadioButton, "decryptRadioButton");
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // encryptRadioButton
            // 
            resources.ApplyResources(this.encryptRadioButton, "encryptRadioButton");
            this.encryptRadioButton.Checked = true;
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lockedBox
            // 
            resources.ApplyResources(this.lockedBox, "lockedBox");
            this.lockedBox.Name = "lockedBox";
            this.lockedBox.UseVisualStyleBackColor = true;
            this.lockedBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // engLanguageRadioBtn
            // 
            resources.ApplyResources(this.engLanguageRadioBtn, "engLanguageRadioBtn");
            this.engLanguageRadioBtn.Name = "engLanguageRadioBtn";
            this.engLanguageRadioBtn.TabStop = true;
            this.engLanguageRadioBtn.UseVisualStyleBackColor = true;
            this.engLanguageRadioBtn.CheckedChanged += new System.EventHandler(this.engLanguageRadioBtn_CheckedChanged);
            // 
            // rusLanguageRadioBtn
            // 
            resources.ApplyResources(this.rusLanguageRadioBtn, "rusLanguageRadioBtn");
            this.rusLanguageRadioBtn.Name = "rusLanguageRadioBtn";
            this.rusLanguageRadioBtn.TabStop = true;
            this.rusLanguageRadioBtn.UseVisualStyleBackColor = true;
            this.rusLanguageRadioBtn.CheckedChanged += new System.EventHandler(this.rusLanguageRadioBtn_CheckedChanged);
            // 
            // GlobalCipherForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rusLanguageRadioBtn);
            this.Controls.Add(this.engLanguageRadioBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lockedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "GlobalCipherForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decryptRadioButton;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.CheckBox lockedBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton engLanguageRadioBtn;
        private System.Windows.Forms.RadioButton rusLanguageRadioBtn;
    }
}

