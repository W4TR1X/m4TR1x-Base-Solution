
namespace m4TR1x.UI.Winforms
{
    partial class DailyMessageForm
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
            this.btnFetch = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(12, 148);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(64, 24);
            this.btnFetch.TabIndex = 9;
            this.btnFetch.Text = "Yenile";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.White;
            this.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor.Location = new System.Drawing.Point(82, 148);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(472, 23);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(542, 133);
            this.lblMessage.TabIndex = 7;
            // 
            // DailyMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 183);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DailyMessageForm";
            this.Text = "Daily Message";
            this.Load += new System.EventHandler(this.DailyMessageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblMessage;
    }
}