
namespace m4TR1x.UI.Winforms
{
    partial class MainForm
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
            this.btnWeatherForm = new System.Windows.Forms.Button();
            this.btnDailyMessageForm = new System.Windows.Forms.Button();
            this.btnNewTestForm = new System.Windows.Forms.Button();
            this.btnDisplayAllForms = new System.Windows.Forms.Button();
            this.btnCloseAllForms = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWeatherForm
            // 
            this.btnWeatherForm.Location = new System.Drawing.Point(134, 22);
            this.btnWeatherForm.Name = "btnWeatherForm";
            this.btnWeatherForm.Size = new System.Drawing.Size(122, 35);
            this.btnWeatherForm.TabIndex = 7;
            this.btnWeatherForm.Text = "Weather Info";
            this.btnWeatherForm.UseVisualStyleBackColor = true;
            this.btnWeatherForm.Click += new System.EventHandler(this.btnWeatherForm_Click);
            // 
            // btnDailyMessageForm
            // 
            this.btnDailyMessageForm.Location = new System.Drawing.Point(6, 22);
            this.btnDailyMessageForm.Name = "btnDailyMessageForm";
            this.btnDailyMessageForm.Size = new System.Drawing.Size(122, 35);
            this.btnDailyMessageForm.TabIndex = 7;
            this.btnDailyMessageForm.Text = "Daily Messages";
            this.btnDailyMessageForm.UseVisualStyleBackColor = true;
            this.btnDailyMessageForm.Click += new System.EventHandler(this.btnDailyMessageForm_Click);
            // 
            // btnNewTestForm
            // 
            this.btnNewTestForm.Location = new System.Drawing.Point(6, 22);
            this.btnNewTestForm.Name = "btnNewTestForm";
            this.btnNewTestForm.Size = new System.Drawing.Size(122, 35);
            this.btnNewTestForm.TabIndex = 8;
            this.btnNewTestForm.Text = "New Test Form";
            this.btnNewTestForm.UseVisualStyleBackColor = true;
            this.btnNewTestForm.Click += new System.EventHandler(this.btnNewTestForm_Click);
            // 
            // btnDisplayAllForms
            // 
            this.btnDisplayAllForms.Location = new System.Drawing.Point(142, 227);
            this.btnDisplayAllForms.Name = "btnDisplayAllForms";
            this.btnDisplayAllForms.Size = new System.Drawing.Size(144, 35);
            this.btnDisplayAllForms.TabIndex = 8;
            this.btnDisplayAllForms.Text = "Display All Forms";
            this.btnDisplayAllForms.UseVisualStyleBackColor = true;
            this.btnDisplayAllForms.Click += new System.EventHandler(this.btnDisplayAllForms_Click);
            // 
            // btnCloseAllForms
            // 
            this.btnCloseAllForms.Location = new System.Drawing.Point(292, 227);
            this.btnCloseAllForms.Name = "btnCloseAllForms";
            this.btnCloseAllForms.Size = new System.Drawing.Size(139, 35);
            this.btnCloseAllForms.TabIndex = 8;
            this.btnCloseAllForms.Text = "Close All Forms";
            this.btnCloseAllForms.UseVisualStyleBackColor = true;
            this.btnCloseAllForms.Click += new System.EventHandler(this.btnCloseAllForms_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewTestForm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 66);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiple instances";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWeatherForm);
            this.groupBox2.Controls.Add(this.btnDailyMessageForm);
            this.groupBox2.Location = new System.Drawing.Point(162, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 66);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "One instance only";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(443, 274);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseAllForms);
            this.Controls.Add(this.btnDisplayAllForms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWeatherForm;
        private System.Windows.Forms.Button btnDailyMessageForm;
        private System.Windows.Forms.Button btnNewTestForm;
        private System.Windows.Forms.Button btnDisplayAllForms;
        private System.Windows.Forms.Button btnCloseAllForms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}