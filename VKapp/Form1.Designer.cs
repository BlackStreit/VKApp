
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakeRequests
            // 
            this.btnMakeRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeRequests.Location = new System.Drawing.Point(717, 27);
            this.btnMakeRequests.Name = "btnMakeRequests";
            this.btnMakeRequests.Size = new System.Drawing.Size(162, 32);
            this.btnMakeRequests.TabIndex = 0;
            this.btnMakeRequests.Text = "Сделать запрос";
            this.btnMakeRequests.UseVisualStyleBackColor = true;
            this.btnMakeRequests.Click += new System.EventHandler(this.btnMakeRequests_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserId.Location = new System.Drawing.Point(25, 33);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(675, 23);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Text = "itds_istu";
            // 
            // txtRespone
            // 
            this.txtRespone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRespone.Location = new System.Drawing.Point(504, 65);
            this.txtRespone.Name = "txtRespone";
            this.txtRespone.Size = new System.Drawing.Size(375, 490);
            this.txtRespone.TabIndex = 2;
            this.txtRespone.Text = "";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGroupName.Location = new System.Drawing.Point(98, 191);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(49, 19);
            this.lblGroupName.TabIndex = 3;
            this.lblGroupName.Text = "label1";
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(23, 65);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(475, 98);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 4;
            this.picCover.TabStop = false;
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(23, 169);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(60, 60);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 5;
            this.picAvatar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 567);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtRespone);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnMakeRequests);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeRequests;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.RichTextBox txtRespone;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.PictureBox picAvatar;
    }
}

