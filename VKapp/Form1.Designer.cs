
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
            this.grdUsers = new System.Windows.Forms.DataGridView();
            this.pnUserInfo = new System.Windows.Forms.Panel();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.lblSureName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnVisible = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.pnUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
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
            this.txtRespone.Size = new System.Drawing.Size(375, 409);
            this.txtRespone.TabIndex = 2;
            this.txtRespone.Text = "";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGroupName.Location = new System.Drawing.Point(98, 191);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(0, 19);
            this.lblGroupName.TabIndex = 3;
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(20, 65);
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
            // grdUsers
            // 
            this.grdUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Location = new System.Drawing.Point(20, 265);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.ReadOnly = true;
            this.grdUsers.RowTemplate.Height = 25;
            this.grdUsers.Size = new System.Drawing.Size(477, 209);
            this.grdUsers.TabIndex = 6;
            this.grdUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsers_CellDoubleClick);
            // 
            // pnUserInfo
            // 
            this.pnUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUserInfo.Controls.Add(this.picUserAvatar);
            this.pnUserInfo.Controls.Add(this.lblSureName);
            this.pnUserInfo.Controls.Add(this.lblName);
            this.pnUserInfo.Controls.Add(this.btnVisible);
            this.pnUserInfo.Location = new System.Drawing.Point(130, 77);
            this.pnUserInfo.Name = "pnUserInfo";
            this.pnUserInfo.Size = new System.Drawing.Size(605, 369);
            this.pnUserInfo.TabIndex = 7;
            this.pnUserInfo.Visible = false;
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Location = new System.Drawing.Point(314, 35);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(256, 256);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserAvatar.TabIndex = 3;
            this.picUserAvatar.TabStop = false;
            // 
            // lblSureName
            // 
            this.lblSureName.AutoSize = true;
            this.lblSureName.Location = new System.Drawing.Point(60, 71);
            this.lblSureName.Name = "lblSureName";
            this.lblSureName.Size = new System.Drawing.Size(38, 15);
            this.lblSureName.TabIndex = 2;
            this.lblSureName.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(267, 298);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(98, 37);
            this.btnVisible.TabIndex = 0;
            this.btnVisible.Text = "Скрыть";
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 486);
            this.Controls.Add(this.pnUserInfo);
            this.Controls.Add(this.grdUsers);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.pnUserInfo.ResumeLayout(false);
            this.pnUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
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
        private System.Windows.Forms.DataGridView grdUsers;
        private System.Windows.Forms.Panel pnUserInfo;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label lblSureName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnVisible;
    }
}

