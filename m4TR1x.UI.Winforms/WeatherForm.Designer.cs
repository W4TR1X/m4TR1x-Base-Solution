
namespace m4TR1x.UI.Winforms
{
    partial class WeatherForm
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
            this.components = new System.ComponentModel.Container();
            this.foreverGroupBox1 = new System.Windows.Forms.GroupBox();
            this.day0LgImage = new System.Windows.Forms.PictureBox();
            this.day0Info = new System.Windows.Forms.Label();
            this.day0Temp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.foreverGroupBox2 = new System.Windows.Forms.GroupBox();
            this.day1Name = new System.Windows.Forms.Label();
            this.day1Temp = new System.Windows.Forms.Label();
            this.day1Image = new System.Windows.Forms.PictureBox();
            this.foreverGroupBox3 = new System.Windows.Forms.GroupBox();
            this.day2Name = new System.Windows.Forms.Label();
            this.day2Temp = new System.Windows.Forms.Label();
            this.day2Image = new System.Windows.Forms.PictureBox();
            this.foreverGroupBox4 = new System.Windows.Forms.GroupBox();
            this.day3Name = new System.Windows.Forms.Label();
            this.day3Temp = new System.Windows.Forms.Label();
            this.day3Image = new System.Windows.Forms.PictureBox();
            this.foreverGroupBox5 = new System.Windows.Forms.GroupBox();
            this.day4Name = new System.Windows.Forms.Label();
            this.day4Temp = new System.Windows.Forms.Label();
            this.day4Image = new System.Windows.Forms.PictureBox();
            this.foreverGroupBox6 = new System.Windows.Forms.GroupBox();
            this.day5Name = new System.Windows.Forms.Label();
            this.day5Temp = new System.Windows.Forms.Label();
            this.day5Image = new System.Windows.Forms.PictureBox();
            this.foreverGroupBox7 = new System.Windows.Forms.GroupBox();
            this.day6Name = new System.Windows.Forms.Label();
            this.day6Temp = new System.Windows.Forms.Label();
            this.day6Image = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.foreverGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day0LgImage)).BeginInit();
            this.foreverGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day1Image)).BeginInit();
            this.foreverGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day2Image)).BeginInit();
            this.foreverGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day3Image)).BeginInit();
            this.foreverGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day4Image)).BeginInit();
            this.foreverGroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day5Image)).BeginInit();
            this.foreverGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day6Image)).BeginInit();
            this.SuspendLayout();
            // 
            // foreverGroupBox1
            // 
            this.foreverGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.foreverGroupBox1.Controls.Add(this.day0LgImage);
            this.foreverGroupBox1.Controls.Add(this.day0Info);
            this.foreverGroupBox1.Controls.Add(this.day0Temp);
            this.foreverGroupBox1.Controls.Add(this.label1);
            this.foreverGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverGroupBox1.Location = new System.Drawing.Point(0, 3);
            this.foreverGroupBox1.Name = "foreverGroupBox1";
            this.foreverGroupBox1.Size = new System.Drawing.Size(547, 147);
            this.foreverGroupBox1.TabIndex = 0;
            this.foreverGroupBox1.TabStop = false;
            // 
            // day0LgImage
            // 
            this.day0LgImage.Location = new System.Drawing.Point(20, 20);
            this.day0LgImage.Name = "day0LgImage";
            this.day0LgImage.Size = new System.Drawing.Size(107, 107);
            this.day0LgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day0LgImage.TabIndex = 0;
            this.day0LgImage.TabStop = false;
            // 
            // day0Info
            // 
            this.day0Info.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day0Info.Location = new System.Drawing.Point(133, 87);
            this.day0Info.Name = "day0Info";
            this.day0Info.Size = new System.Drawing.Size(401, 40);
            this.day0Info.TabIndex = 2;
            this.day0Info.Text = "000";
            this.day0Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // day0Temp
            // 
            this.day0Temp.AutoSize = true;
            this.day0Temp.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day0Temp.Location = new System.Drawing.Point(121, 8);
            this.day0Temp.Name = "day0Temp";
            this.day0Temp.Size = new System.Drawing.Size(199, 86);
            this.day0Temp.TabIndex = 1;
            this.day0Temp.Text = "000*c";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(297, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Güncel Hava Durumu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // updateLabel
            // 
            this.updateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.updateLabel.Location = new System.Drawing.Point(17, 283);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(527, 16);
            this.updateLabel.TabIndex = 3;
            this.updateLabel.Text = "updated at";
            this.updateLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // foreverGroupBox2
            // 
            this.foreverGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.foreverGroupBox2.BackColor = System.Drawing.Color.White;
            this.foreverGroupBox2.Controls.Add(this.day1Name);
            this.foreverGroupBox2.Controls.Add(this.day1Temp);
            this.foreverGroupBox2.Controls.Add(this.day1Image);
            this.foreverGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverGroupBox2.Location = new System.Drawing.Point(0, 142);
            this.foreverGroupBox2.Name = "foreverGroupBox2";
            this.foreverGroupBox2.Size = new System.Drawing.Size(97, 138);
            this.foreverGroupBox2.TabIndex = 0;
            this.foreverGroupBox2.TabStop = false;
            // 
            // day1Name
            // 
            this.day1Name.Location = new System.Drawing.Point(12, 13);
            this.day1Name.Name = "day1Name";
            this.day1Name.Size = new System.Drawing.Size(72, 19);
            this.day1Name.TabIndex = 2;
            this.day1Name.Text = "X";
            this.day1Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day1Temp
            // 
            this.day1Temp.Location = new System.Drawing.Point(12, 110);
            this.day1Temp.Name = "day1Temp";
            this.day1Temp.Size = new System.Drawing.Size(72, 25);
            this.day1Temp.TabIndex = 1;
            this.day1Temp.Text = "0";
            this.day1Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day1Image
            // 
            this.day1Image.Location = new System.Drawing.Point(12, 35);
            this.day1Image.Name = "day1Image";
            this.day1Image.Size = new System.Drawing.Size(72, 72);
            this.day1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day1Image.TabIndex = 0;
            this.day1Image.TabStop = false;
            // 
            // foreverGroupBox3
            // 
            this.foreverGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.foreverGroupBox3.BackColor = System.Drawing.Color.White;
            this.foreverGroupBox3.Controls.Add(this.day2Name);
            this.foreverGroupBox3.Controls.Add(this.day2Temp);
            this.foreverGroupBox3.Controls.Add(this.day2Image);
            this.foreverGroupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverGroupBox3.Location = new System.Drawing.Point(90, 142);
            this.foreverGroupBox3.Name = "foreverGroupBox3";
            this.foreverGroupBox3.Size = new System.Drawing.Size(97, 138);
            this.foreverGroupBox3.TabIndex = 0;
            this.foreverGroupBox3.TabStop = false;
            // 
            // day2Name
            // 
            this.day2Name.Location = new System.Drawing.Point(12, 13);
            this.day2Name.Name = "day2Name";
            this.day2Name.Size = new System.Drawing.Size(72, 19);
            this.day2Name.TabIndex = 3;
            this.day2Name.Text = "X";
            this.day2Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day2Temp
            // 
            this.day2Temp.Location = new System.Drawing.Point(12, 110);
            this.day2Temp.Name = "day2Temp";
            this.day2Temp.Size = new System.Drawing.Size(72, 25);
            this.day2Temp.TabIndex = 1;
            this.day2Temp.Text = "0";
            this.day2Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day2Image
            // 
            this.day2Image.Location = new System.Drawing.Point(12, 35);
            this.day2Image.Name = "day2Image";
            this.day2Image.Size = new System.Drawing.Size(72, 72);
            this.day2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day2Image.TabIndex = 0;
            this.day2Image.TabStop = false;
            // 
            // foreverGroupBox4
            // 
            this.foreverGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.foreverGroupBox4.BackColor = System.Drawing.Color.White;
            this.foreverGroupBox4.Controls.Add(this.day3Name);
            this.foreverGroupBox4.Controls.Add(this.day3Temp);
            this.foreverGroupBox4.Controls.Add(this.day3Image);
            this.foreverGroupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverGroupBox4.Location = new System.Drawing.Point(180, 142);
            this.foreverGroupBox4.Name = "foreverGroupBox4";
            this.foreverGroupBox4.Size = new System.Drawing.Size(97, 138);
            this.foreverGroupBox4.TabIndex = 0;
            this.foreverGroupBox4.TabStop = false;
            // 
            // day3Name
            // 
            this.day3Name.Location = new System.Drawing.Point(12, 13);
            this.day3Name.Name = "day3Name";
            this.day3Name.Size = new System.Drawing.Size(72, 19);
            this.day3Name.TabIndex = 3;
            this.day3Name.Text = "X";
            this.day3Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day3Temp
            // 
            this.day3Temp.Location = new System.Drawing.Point(12, 110);
            this.day3Temp.Name = "day3Temp";
            this.day3Temp.Size = new System.Drawing.Size(72, 25);
            this.day3Temp.TabIndex = 1;
            this.day3Temp.Text = "0";
            this.day3Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day3Image
            // 
            this.day3Image.Location = new System.Drawing.Point(12, 35);
            this.day3Image.Name = "day3Image";
            this.day3Image.Size = new System.Drawing.Size(72, 72);
            this.day3Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day3Image.TabIndex = 0;
            this.day3Image.TabStop = false;
            // 
            // foreverGroupBox5
            // 
            this.foreverGroupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.foreverGroupBox5.BackColor = System.Drawing.Color.White;
            this.foreverGroupBox5.Controls.Add(this.day4Name);
            this.foreverGroupBox5.Controls.Add(this.day4Temp);
            this.foreverGroupBox5.Controls.Add(this.day4Image);
            this.foreverGroupBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverGroupBox5.Location = new System.Drawing.Point(270, 142);
            this.foreverGroupBox5.Name = "foreverGroupBox5";
            this.foreverGroupBox5.Size = new System.Drawing.Size(97, 138);
            this.foreverGroupBox5.TabIndex = 0;
            this.foreverGroupBox5.TabStop = false;
            // 
            // day4Name
            // 
            this.day4Name.Location = new System.Drawing.Point(12, 13);
            this.day4Name.Name = "day4Name";
            this.day4Name.Size = new System.Drawing.Size(72, 19);
            this.day4Name.TabIndex = 3;
            this.day4Name.Text = "X";
            this.day4Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day4Temp
            // 
            this.day4Temp.Location = new System.Drawing.Point(12, 110);
            this.day4Temp.Name = "day4Temp";
            this.day4Temp.Size = new System.Drawing.Size(72, 25);
            this.day4Temp.TabIndex = 1;
            this.day4Temp.Text = "0";
            this.day4Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day4Image
            // 
            this.day4Image.Location = new System.Drawing.Point(12, 35);
            this.day4Image.Name = "day4Image";
            this.day4Image.Size = new System.Drawing.Size(72, 72);
            this.day4Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day4Image.TabIndex = 0;
            this.day4Image.TabStop = false;
            // 
            // foreverGroupBox6
            // 
            this.foreverGroupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.foreverGroupBox6.BackColor = System.Drawing.Color.White;
            this.foreverGroupBox6.Controls.Add(this.day5Name);
            this.foreverGroupBox6.Controls.Add(this.day5Temp);
            this.foreverGroupBox6.Controls.Add(this.day5Image);
            this.foreverGroupBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverGroupBox6.Location = new System.Drawing.Point(360, 142);
            this.foreverGroupBox6.Name = "foreverGroupBox6";
            this.foreverGroupBox6.Size = new System.Drawing.Size(97, 138);
            this.foreverGroupBox6.TabIndex = 0;
            this.foreverGroupBox6.TabStop = false;
            // 
            // day5Name
            // 
            this.day5Name.Location = new System.Drawing.Point(12, 13);
            this.day5Name.Name = "day5Name";
            this.day5Name.Size = new System.Drawing.Size(72, 19);
            this.day5Name.TabIndex = 3;
            this.day5Name.Text = "X";
            this.day5Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day5Temp
            // 
            this.day5Temp.Location = new System.Drawing.Point(12, 110);
            this.day5Temp.Name = "day5Temp";
            this.day5Temp.Size = new System.Drawing.Size(72, 25);
            this.day5Temp.TabIndex = 1;
            this.day5Temp.Text = "0";
            this.day5Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day5Image
            // 
            this.day5Image.Location = new System.Drawing.Point(12, 35);
            this.day5Image.Name = "day5Image";
            this.day5Image.Size = new System.Drawing.Size(72, 72);
            this.day5Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day5Image.TabIndex = 0;
            this.day5Image.TabStop = false;
            // 
            // foreverGroupBox7
            // 
            this.foreverGroupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.foreverGroupBox7.BackColor = System.Drawing.Color.White;
            this.foreverGroupBox7.Controls.Add(this.day6Name);
            this.foreverGroupBox7.Controls.Add(this.day6Temp);
            this.foreverGroupBox7.Controls.Add(this.day6Image);
            this.foreverGroupBox7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverGroupBox7.Location = new System.Drawing.Point(450, 142);
            this.foreverGroupBox7.Name = "foreverGroupBox7";
            this.foreverGroupBox7.Size = new System.Drawing.Size(97, 138);
            this.foreverGroupBox7.TabIndex = 0;
            this.foreverGroupBox7.TabStop = false;
            // 
            // day6Name
            // 
            this.day6Name.Location = new System.Drawing.Point(12, 13);
            this.day6Name.Name = "day6Name";
            this.day6Name.Size = new System.Drawing.Size(72, 19);
            this.day6Name.TabIndex = 3;
            this.day6Name.Text = "X";
            this.day6Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day6Temp
            // 
            this.day6Temp.Location = new System.Drawing.Point(12, 110);
            this.day6Temp.Name = "day6Temp";
            this.day6Temp.Size = new System.Drawing.Size(72, 25);
            this.day6Temp.TabIndex = 1;
            this.day6Temp.Text = "0";
            this.day6Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day6Image
            // 
            this.day6Image.Location = new System.Drawing.Point(12, 35);
            this.day6Image.Name = "day6Image";
            this.day6Image.Size = new System.Drawing.Size(72, 72);
            this.day6Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day6Image.TabIndex = 0;
            this.day6Image.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoading.Location = new System.Drawing.Point(3, 1);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(541, 298);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "Yükleniyor...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeatherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(545, 301);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.foreverGroupBox7);
            this.Controls.Add(this.foreverGroupBox6);
            this.Controls.Add(this.foreverGroupBox5);
            this.Controls.Add(this.foreverGroupBox4);
            this.Controls.Add(this.foreverGroupBox3);
            this.Controls.Add(this.foreverGroupBox2);
            this.Controls.Add(this.foreverGroupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeatherForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hava Durumu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WeatherForm_FormClosing);
            this.foreverGroupBox1.ResumeLayout(false);
            this.foreverGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day0LgImage)).EndInit();
            this.foreverGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.day1Image)).EndInit();
            this.foreverGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.day2Image)).EndInit();
            this.foreverGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.day3Image)).EndInit();
            this.foreverGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.day4Image)).EndInit();
            this.foreverGroupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.day5Image)).EndInit();
            this.foreverGroupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.day6Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox foreverGroupBox1;
        private System.Windows.Forms.PictureBox day0LgImage;
        private System.Windows.Forms.Label day0Info;
        private System.Windows.Forms.Label day0Temp;
        private System.Windows.Forms.GroupBox foreverGroupBox2;
        private System.Windows.Forms.Label day1Temp;
        private System.Windows.Forms.PictureBox day1Image;
        private System.Windows.Forms.GroupBox foreverGroupBox3;
        private System.Windows.Forms.Label day2Temp;
        private System.Windows.Forms.PictureBox day2Image;
        private System.Windows.Forms.GroupBox foreverGroupBox4;
        private System.Windows.Forms.Label day3Temp;
        private System.Windows.Forms.PictureBox day3Image;
        private System.Windows.Forms.GroupBox foreverGroupBox5;
        private System.Windows.Forms.Label day4Temp;
        private System.Windows.Forms.PictureBox day4Image;
        private System.Windows.Forms.GroupBox foreverGroupBox6;
        private System.Windows.Forms.Label day5Temp;
        private System.Windows.Forms.PictureBox day5Image;
        private System.Windows.Forms.GroupBox foreverGroupBox7;
        private System.Windows.Forms.Label day6Temp;
        private System.Windows.Forms.PictureBox day6Image;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label day1Name;
        private System.Windows.Forms.Label day2Name;
        private System.Windows.Forms.Label day3Name;
        private System.Windows.Forms.Label day4Name;
        private System.Windows.Forms.Label day5Name;
        private System.Windows.Forms.Label day6Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}