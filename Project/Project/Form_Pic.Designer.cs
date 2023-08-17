
namespace Project
{
    partial class Form_Pic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pic));
            this.spl = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCPage = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblLPage = new System.Windows.Forms.Label();
            this.txtMImgFileFullName = new System.Windows.Forms.TextBox();
            this.txtMImgFilePath = new System.Windows.Forms.TextBox();
            this.lblChNum = new System.Windows.Forms.Label();
            this.lblChName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPfImgFilePath = new System.Windows.Forms.TextBox();
            this.txtPImgFileFullName = new System.Windows.Forms.TextBox();
            this.picPfimgBox = new System.Windows.Forms.PictureBox();
            this.lblPRImgAdd = new System.Windows.Forms.Label();
            this.pnlPicBox = new System.Windows.Forms.Panel();
            this.lblNo = new System.Windows.Forms.Label();
            this.tabImgTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picImgBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spl)).BeginInit();
            this.spl.Panel1.SuspendLayout();
            this.spl.Panel2.SuspendLayout();
            this.spl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPfimgBox)).BeginInit();
            this.tabImgTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // spl
            // 
            this.spl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl.Location = new System.Drawing.Point(0, 0);
            this.spl.Name = "spl";
            // 
            // spl.Panel1
            // 
            this.spl.Panel1.Controls.Add(this.btnDelete);
            this.spl.Panel1.Controls.Add(this.lblCPage);
            this.spl.Panel1.Controls.Add(this.lbl1);
            this.spl.Panel1.Controls.Add(this.lblLPage);
            this.spl.Panel1.Controls.Add(this.txtMImgFileFullName);
            this.spl.Panel1.Controls.Add(this.txtMImgFilePath);
            this.spl.Panel1.Controls.Add(this.lblChNum);
            this.spl.Panel1.Controls.Add(this.lblChName);
            this.spl.Panel1.Controls.Add(this.btnSave);
            this.spl.Panel1.Controls.Add(this.txtPfImgFilePath);
            this.spl.Panel1.Controls.Add(this.txtPImgFileFullName);
            this.spl.Panel1.Controls.Add(this.picPfimgBox);
            this.spl.Panel1.Controls.Add(this.lblPRImgAdd);
            this.spl.Panel1.Controls.Add(this.pnlPicBox);
            this.spl.Panel1.Controls.Add(this.lblNo);
            // 
            // spl.Panel2
            // 
            this.spl.Panel2.Controls.Add(this.tabImgTab);
            this.spl.Size = new System.Drawing.Size(822, 482);
            this.spl.SplitterDistance = 201;
            this.spl.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(9, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 42);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCPage
            // 
            this.lblCPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCPage.AutoSize = true;
            this.lblCPage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCPage.Location = new System.Drawing.Point(79, 457);
            this.lblCPage.Name = "lblCPage";
            this.lblCPage.Size = new System.Drawing.Size(12, 12);
            this.lblCPage.TabIndex = 35;
            this.lblCPage.Text = "1";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl1.Location = new System.Drawing.Point(100, 457);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(12, 12);
            this.lbl1.TabIndex = 34;
            this.lbl1.Text = "/";
            // 
            // lblLPage
            // 
            this.lblLPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLPage.AutoSize = true;
            this.lblLPage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLPage.Location = new System.Drawing.Point(112, 457);
            this.lblLPage.Name = "lblLPage";
            this.lblLPage.Size = new System.Drawing.Size(19, 12);
            this.lblLPage.TabIndex = 33;
            this.lblLPage.Text = "10";
            // 
            // txtMImgFileFullName
            // 
            this.txtMImgFileFullName.Enabled = false;
            this.txtMImgFileFullName.Location = new System.Drawing.Point(12, 329);
            this.txtMImgFileFullName.Name = "txtMImgFileFullName";
            this.txtMImgFileFullName.Size = new System.Drawing.Size(22, 21);
            this.txtMImgFileFullName.TabIndex = 32;
            // 
            // txtMImgFilePath
            // 
            this.txtMImgFilePath.Enabled = false;
            this.txtMImgFilePath.Location = new System.Drawing.Point(12, 302);
            this.txtMImgFilePath.Name = "txtMImgFilePath";
            this.txtMImgFilePath.Size = new System.Drawing.Size(22, 21);
            this.txtMImgFilePath.TabIndex = 31;
            // 
            // lblChNum
            // 
            this.lblChNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChNum.AutoSize = true;
            this.lblChNum.Location = new System.Drawing.Point(37, 187);
            this.lblChNum.Name = "lblChNum";
            this.lblChNum.Size = new System.Drawing.Size(11, 12);
            this.lblChNum.TabIndex = 29;
            this.lblChNum.Text = "1";
            // 
            // lblChName
            // 
            this.lblChName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChName.AutoSize = true;
            this.lblChName.Location = new System.Drawing.Point(59, 187);
            this.lblChName.Name = "lblChName";
            this.lblChName.Size = new System.Drawing.Size(39, 12);
            this.lblChName.TabIndex = 28;
            this.lblChName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(9, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 42);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPfImgFilePath
            // 
            this.txtPfImgFilePath.Enabled = false;
            this.txtPfImgFilePath.Location = new System.Drawing.Point(12, 220);
            this.txtPfImgFilePath.Name = "txtPfImgFilePath";
            this.txtPfImgFilePath.Size = new System.Drawing.Size(22, 21);
            this.txtPfImgFilePath.TabIndex = 26;
            // 
            // txtPImgFileFullName
            // 
            this.txtPImgFileFullName.Enabled = false;
            this.txtPImgFileFullName.Location = new System.Drawing.Point(12, 247);
            this.txtPImgFileFullName.Name = "txtPImgFileFullName";
            this.txtPImgFileFullName.Size = new System.Drawing.Size(22, 21);
            this.txtPImgFileFullName.TabIndex = 25;
            // 
            // picPfimgBox
            // 
            this.picPfimgBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picPfimgBox.BackColor = System.Drawing.SystemColors.Control;
            this.picPfimgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPfimgBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPfimgBox.Image = global::Project.Properties.Resources.Add_Image;
            this.picPfimgBox.Location = new System.Drawing.Point(53, 32);
            this.picPfimgBox.Name = "picPfimgBox";
            this.picPfimgBox.Size = new System.Drawing.Size(100, 100);
            this.picPfimgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPfimgBox.TabIndex = 22;
            this.picPfimgBox.TabStop = false;
            this.picPfimgBox.Click += new System.EventHandler(this.picPfimgBox_Click_1);
            // 
            // lblPRImgAdd
            // 
            this.lblPRImgAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPRImgAdd.AutoSize = true;
            this.lblPRImgAdd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPRImgAdd.Location = new System.Drawing.Point(10, 156);
            this.lblPRImgAdd.Name = "lblPRImgAdd";
            this.lblPRImgAdd.Size = new System.Drawing.Size(189, 12);
            this.lblPRImgAdd.TabIndex = 24;
            this.lblPRImgAdd.Text = "Add Profile Image (100x100)";
            // 
            // pnlPicBox
            // 
            this.pnlPicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPicBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPicBox.BackgroundImage")));
            this.pnlPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPicBox.Location = new System.Drawing.Point(43, 22);
            this.pnlPicBox.Name = "pnlPicBox";
            this.pnlPicBox.Size = new System.Drawing.Size(120, 120);
            this.pnlPicBox.TabIndex = 23;
            // 
            // lblNo
            // 
            this.lblNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(16, 187);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(25, 12);
            this.lblNo.TabIndex = 30;
            this.lblNo.Text = "No.";
            // 
            // tabImgTab
            // 
            this.tabImgTab.Controls.Add(this.tabPage1);
            this.tabImgTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabImgTab.Location = new System.Drawing.Point(0, 0);
            this.tabImgTab.Name = "tabImgTab";
            this.tabImgTab.SelectedIndex = 0;
            this.tabImgTab.Size = new System.Drawing.Size(617, 482);
            this.tabImgTab.TabIndex = 1;
            this.tabImgTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabImg_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picImgBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image_1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picImgBox
            // 
            this.picImgBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImgBox.Image = ((System.Drawing.Image)(resources.GetObject("picImgBox.Image")));
            this.picImgBox.Location = new System.Drawing.Point(3, 3);
            this.picImgBox.Name = "picImgBox";
            this.picImgBox.Size = new System.Drawing.Size(603, 450);
            this.picImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImgBox.TabIndex = 0;
            this.picImgBox.TabStop = false;
            this.picImgBox.Click += new System.EventHandler(this.picImgBox_Click);
            // 
            // Form_Pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(822, 482);
            this.Controls.Add(this.spl);
            this.Name = "Form_Pic";
            this.Text = "Form_Pic";
            this.Load += new System.EventHandler(this.Form_Pic_Load);
            this.spl.Panel1.ResumeLayout(false);
            this.spl.Panel1.PerformLayout();
            this.spl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl)).EndInit();
            this.spl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPfimgBox)).EndInit();
            this.tabImgTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spl;
        private System.Windows.Forms.Label lblPRImgAdd;
        private System.Windows.Forms.Panel pnlPicBox;
        public System.Windows.Forms.PictureBox picPfimgBox;
        private System.Windows.Forms.TabControl tabImgTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox picImgBox;
        public System.Windows.Forms.TextBox txtPfImgFilePath;
        public System.Windows.Forms.TextBox txtPImgFileFullName;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblChNum;
        public System.Windows.Forms.Label lblChName;
        public System.Windows.Forms.Label lblNo;
        public System.Windows.Forms.TextBox txtMImgFilePath;
        public System.Windows.Forms.TextBox txtMImgFileFullName;
        private System.Windows.Forms.Label lblCPage;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblLPage;
        private System.Windows.Forms.Button btnDelete;
    }
}