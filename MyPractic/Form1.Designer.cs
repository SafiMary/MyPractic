namespace MyPractic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelNewpath = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelReport = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonSuspend = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(33, 66);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(133, 20);
            this.textBoxInput.TabIndex = 0;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(30, 50);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(141, 13);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "введите слова для поиска";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(33, 147);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(148, 13);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "выберите папку для поиска";
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(76, 321);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "ПОИСК";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelNewpath
            // 
            this.labelNewpath.AutoSize = true;
            this.labelNewpath.Location = new System.Drawing.Point(36, 214);
            this.labelNewpath.Name = "labelNewpath";
            this.labelNewpath.Size = new System.Drawing.Size(229, 13);
            this.labelNewpath.TabIndex = 4;
            this.labelNewpath.Text = "укажите папку, куда сохранить новый файл";
            this.labelNewpath.Click += new System.EventHandler(this.labelNewpath_Click);
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.Location = new System.Drawing.Point(36, 267);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(230, 13);
            this.labelReport.TabIndex = 5;
            this.labelReport.Text = "укажите папку, куда сохранить файл отчета";
            this.labelReport.Click += new System.EventHandler(this.labelReport_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(446, 107);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(279, 53);
            this.progressBar.TabIndex = 6;
            // 
            // buttonSuspend
            // 
            this.buttonSuspend.Location = new System.Drawing.Point(423, 346);
            this.buttonSuspend.Name = "buttonSuspend";
            this.buttonSuspend.Size = new System.Drawing.Size(75, 23);
            this.buttonSuspend.TabIndex = 7;
            this.buttonSuspend.Text = "приостановить";
            this.buttonSuspend.UseVisualStyleBackColor = true;
            // 
            // buttonResume
            // 
            this.buttonResume.Location = new System.Drawing.Point(541, 346);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(75, 23);
            this.buttonResume.TabIndex = 8;
            this.buttonResume.Text = "возобновить";
            this.buttonResume.UseVisualStyleBackColor = true;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(649, 345);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 9;
            this.buttonAbort.Text = "завершить";
            this.buttonAbort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.buttonSuspend);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.labelNewpath);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelNewpath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelReport;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonSuspend;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Button buttonAbort;
    }
}

