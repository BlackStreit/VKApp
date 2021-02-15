
namespace VKapp
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
            this.btnMakeRequests = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtRespone = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnMakeRequests
            // 
            this.btnMakeRequests.Location = new System.Drawing.Point(12, 113);
            this.btnMakeRequests.Name = "btnMakeRequests";
            this.btnMakeRequests.Size = new System.Drawing.Size(162, 32);
            this.btnMakeRequests.TabIndex = 0;
            this.btnMakeRequests.Text = "Сделать запрос";
            this.btnMakeRequests.UseVisualStyleBackColor = true;
            this.btnMakeRequests.Click += new System.EventHandler(this.btnMakeRequests_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(12, 73);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(162, 23);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Text = "166766754";
            // 
            // txtRespone
            // 
            this.txtRespone.Location = new System.Drawing.Point(200, 25);
            this.txtRespone.Name = "txtRespone";
            this.txtRespone.Size = new System.Drawing.Size(367, 180);
            this.txtRespone.TabIndex = 2;
            this.txtRespone.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 242);
            this.Controls.Add(this.txtRespone);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnMakeRequests);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeRequests;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.RichTextBox txtRespone;
    }
}

