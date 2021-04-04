
namespace m4TR1x.Ui.Winforms
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbWeatherImage = new System.Windows.Forms.PictureBox();
            this.lbltemp = new System.Windows.Forms.Label();
            this.lblWeatherText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(12, 31);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(542, 133);
            this.lblMessage.TabIndex = 0;
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.White;
            this.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(82, 170);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(472, 23);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbWeatherImage
            // 
            this.pbWeatherImage.BackColor = System.Drawing.Color.White;
            this.pbWeatherImage.Location = new System.Drawing.Point(560, 31);
            this.pbWeatherImage.Name = "pbWeatherImage";
            this.pbWeatherImage.Size = new System.Drawing.Size(120, 120);
            this.pbWeatherImage.TabIndex = 3;
            this.pbWeatherImage.TabStop = false;
            // 
            // lbltemp
            // 
            this.lbltemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltemp.Location = new System.Drawing.Point(560, 154);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(120, 39);
            this.lbltemp.TabIndex = 4;
            this.lbltemp.Text = "Wait";
            // 
            // lblWeatherText
            // 
            this.lblWeatherText.AutoSize = true;
            this.lblWeatherText.BackColor = System.Drawing.Color.White;
            this.lblWeatherText.Location = new System.Drawing.Point(560, 136);
            this.lblWeatherText.Name = "lblWeatherText";
            this.lblWeatherText.Size = new System.Drawing.Size(31, 15);
            this.lblWeatherText.TabIndex = 5;
            this.lblWeatherText.Text = "Wait";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Daily Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Weather";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(692, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeatherText);
            this.Controls.Add(this.lbltemp);
            this.Controls.Add(this.pbWeatherImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbWeatherImage;
        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.Label lblWeatherText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}