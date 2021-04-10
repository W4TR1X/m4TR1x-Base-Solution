
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
            this.SuspendLayout();
            // 
            // btnWeatherForm
            // 
            this.btnWeatherForm.Location = new System.Drawing.Point(327, 221);
            this.btnWeatherForm.Name = "btnWeatherForm";
            this.btnWeatherForm.Size = new System.Drawing.Size(167, 49);
            this.btnWeatherForm.TabIndex = 7;
            this.btnWeatherForm.Text = "Weather Info";
            this.btnWeatherForm.UseVisualStyleBackColor = true;
            this.btnWeatherForm.Click += new System.EventHandler(this.btnWeatherForm_Click);
            // 
            // btnDailyMessageForm
            // 
            this.btnDailyMessageForm.Location = new System.Drawing.Point(500, 221);
            this.btnDailyMessageForm.Name = "btnDailyMessageForm";
            this.btnDailyMessageForm.Size = new System.Drawing.Size(167, 49);
            this.btnDailyMessageForm.TabIndex = 7;
            this.btnDailyMessageForm.Text = "Daily Messages";
            this.btnDailyMessageForm.UseVisualStyleBackColor = true;
            this.btnDailyMessageForm.Click += new System.EventHandler(this.btnDailyMessageForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(679, 282);
            this.Controls.Add(this.btnDailyMessageForm);
            this.Controls.Add(this.btnWeatherForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWeatherForm;
        private System.Windows.Forms.Button btnDailyMessageForm;
    }
}