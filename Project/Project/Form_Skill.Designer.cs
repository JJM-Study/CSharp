
namespace Project
{
    partial class Form_Skill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Skill));
            this.picImg = new System.Windows.Forms.PictureBox();
            this.rtxMemo = new System.Windows.Forms.RichTextBox();
            this.dtgDetail_Info = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lbldetail = new System.Windows.Forms.Label();
            this.lblNlbl = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.nudInput_ChNum = new System.Windows.Forms.NumericUpDown();
            this.lblChNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCNlbl = new System.Windows.Forms.Label();
            this.lblChNo = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lbllist = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.col_header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgHdnInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hidden_filepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hidden_detailpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hidden_imgpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPfImgFilePath = new System.Windows.Forms.TextBox();
            this.txtImgFolderPath = new System.Windows.Forms.TextBox();
            this.txtSaveMode = new System.Windows.Forms.TextBox();
            this.txtDetailTextPath = new System.Windows.Forms.TextBox();
            this.txtTextFilePath = new System.Windows.Forms.TextBox();
            this.lblCPage = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblLPage = new System.Windows.Forms.Label();
            this.txtOri_Num = new System.Windows.Forms.TextBox();
            this.txtOri_Name = new System.Windows.Forms.TextBox();
            this.fndFontDialog = new System.Windows.Forms.FontDialog();
            this.cldColorDialog = new System.Windows.Forms.ColorDialog();
            this.cmsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPicBox = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnUnset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetail_Info)).BeginInit();
            this.pnl2.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput_ChNum)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHdnInfo)).BeginInit();
            this.cmsContextMenuStrip.SuspendLayout();
            this.pnlPicBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.BackColor = System.Drawing.SystemColors.Control;
            this.picImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImg.Image = global::Project.Properties.Resources.Add_Image;
            this.picImg.Location = new System.Drawing.Point(5, 5);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(157, 149);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            this.picImg.Click += new System.EventHandler(this.picImg_Click);
            // 
            // rtxMemo
            // 
            this.rtxMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxMemo.Location = new System.Drawing.Point(4, 225);
            this.rtxMemo.Name = "rtxMemo";
            this.rtxMemo.Size = new System.Drawing.Size(353, 217);
            this.rtxMemo.TabIndex = 26;
            this.rtxMemo.Text = "처음부터 모든 스킬들은 리스트에 다 나오게 하고, 특정 노트 lbl no이 있는지 없는지에 따라서. 가지고 있는 스킬은 리스트에서 따로 필터하는" +
    " 기능을 추가하거나 행 색을 수정하는 방식을 택할 것.";
            // 
            // dtgDetail_Info
            // 
            this.dtgDetail_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDetail_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetail_Info.ColumnHeadersVisible = false;
            this.dtgDetail_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgDetail_Info.Location = new System.Drawing.Point(363, 132);
            this.dtgDetail_Info.Name = "dtgDetail_Info";
            this.dtgDetail_Info.RowHeadersVisible = false;
            this.dtgDetail_Info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgDetail_Info.RowTemplate.Height = 23;
            this.dtgDetail_Info.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDetail_Info.Size = new System.Drawing.Size(169, 310);
            this.dtgDetail_Info.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "col_header";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "col_Info";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pnl2
            // 
            this.pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(192)))));
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.lbldetail);
            this.pnl2.Location = new System.Drawing.Point(364, 70);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(168, 56);
            this.pnl2.TabIndex = 62;
            // 
            // lbldetail
            // 
            this.lbldetail.AutoSize = true;
            this.lbldetail.Font = new System.Drawing.Font("굴림체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbldetail.Location = new System.Drawing.Point(17, 8);
            this.lbldetail.Name = "lbldetail";
            this.lbldetail.Size = new System.Drawing.Size(137, 37);
            this.lbldetail.TabIndex = 0;
            this.lbldetail.Text = "Detail";
            // 
            // lblNlbl
            // 
            this.lblNlbl.AutoSize = true;
            this.lblNlbl.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNlbl.Location = new System.Drawing.Point(178, 101);
            this.lblNlbl.Name = "lblNlbl";
            this.lblNlbl.Size = new System.Drawing.Size(65, 15);
            this.lblNlbl.TabIndex = 63;
            this.lblNlbl.Text = "Name : ";
            this.lblNlbl.Visible = false;
            // 
            // pnlInput
            // 
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.btnNew);
            this.pnlInput.Controls.Add(this.nudInput_ChNum);
            this.pnlInput.Controls.Add(this.lblChNum);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.txtName);
            this.pnlInput.Controls.Add(this.btnDelete);
            this.pnlInput.Controls.Add(this.btnSave);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(714, 64);
            this.pnlInput.TabIndex = 65;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Aqua;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.Location = new System.Drawing.Point(458, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 54);
            this.btnNew.TabIndex = 68;
            this.btnNew.Text = "New Skill";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // nudInput_ChNum
            // 
            this.nudInput_ChNum.Location = new System.Drawing.Point(52, 22);
            this.nudInput_ChNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInput_ChNum.Name = "nudInput_ChNum";
            this.nudInput_ChNum.Size = new System.Drawing.Size(52, 21);
            this.nudInput_ChNum.TabIndex = 67;
            this.nudInput_ChNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblChNum
            // 
            this.lblChNum.AutoSize = true;
            this.lblChNum.Location = new System.Drawing.Point(23, 26);
            this.lblChNum.Name = "lblChNum";
            this.lblChNum.Size = new System.Drawing.Size(25, 12);
            this.lblChNum.TabIndex = 66;
            this.lblChNum.Text = "No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 65;
            this.label1.Text = "Title";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(111, 21);
            this.txtName.TabIndex = 64;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(626, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 54);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(541, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 54);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(242, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 15);
            this.lblName.TabIndex = 66;
            this.lblName.Text = " ";
            this.lblName.Visible = false;
            // 
            // lblCNlbl
            // 
            this.lblCNlbl.AutoSize = true;
            this.lblCNlbl.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCNlbl.Location = new System.Drawing.Point(178, 75);
            this.lblCNlbl.Name = "lblCNlbl";
            this.lblCNlbl.Size = new System.Drawing.Size(61, 15);
            this.lblCNlbl.TabIndex = 67;
            this.lblCNlbl.Text = "Ch.N : ";
            this.lblCNlbl.Visible = false;
            // 
            // lblChNo
            // 
            this.lblChNo.AutoSize = true;
            this.lblChNo.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChNo.Location = new System.Drawing.Point(241, 75);
            this.lblChNo.Name = "lblChNo";
            this.lblChNo.Size = new System.Drawing.Size(13, 15);
            this.lblChNo.TabIndex = 68;
            this.lblChNo.Text = " ";
            this.lblChNo.Visible = false;
            // 
            // pnl1
            // 
            this.pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl1.Controls.Add(this.lbllist);
            this.pnl1.Location = new System.Drawing.Point(539, 70);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(168, 56);
            this.pnl1.TabIndex = 70;
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("굴림체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbllist.Location = new System.Drawing.Point(16, 8);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(117, 37);
            this.lbllist.TabIndex = 0;
            this.lbllist.Text = " List";
            // 
            // dtgList
            // 
            this.dtgList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.ColumnHeadersVisible = false;
            this.dtgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_header,
            this.Info});
            this.dtgList.Location = new System.Drawing.Point(538, 132);
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersVisible = false;
            this.dtgList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgList.RowTemplate.Height = 23;
            this.dtgList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgList.Size = new System.Drawing.Size(169, 310);
            this.dtgList.TabIndex = 69;
            // 
            // col_header
            // 
            this.col_header.HeaderText = "col_header";
            this.col_header.Name = "col_header";
            this.col_header.ReadOnly = true;
            this.col_header.Width = 40;
            // 
            // Info
            // 
            this.Info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Info.HeaderText = "col_Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtgHdnInfo
            // 
            this.dtgHdnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgHdnInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHdnInfo.ColumnHeadersVisible = false;
            this.dtgHdnInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.col_hidden_filepath,
            this.col_hidden_detailpath,
            this.col_hidden_imgpath});
            this.dtgHdnInfo.Location = new System.Drawing.Point(363, 400);
            this.dtgHdnInfo.Name = "dtgHdnInfo";
            this.dtgHdnInfo.ReadOnly = true;
            this.dtgHdnInfo.RowHeadersVisible = false;
            this.dtgHdnInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgHdnInfo.RowTemplate.Height = 23;
            this.dtgHdnInfo.Size = new System.Drawing.Size(169, 42);
            this.dtgHdnInfo.TabIndex = 71;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "col_hidden_number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "col_hidden_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_hidden_filepath
            // 
            this.col_hidden_filepath.HeaderText = "col_hidden_filepath";
            this.col_hidden_filepath.Name = "col_hidden_filepath";
            this.col_hidden_filepath.ReadOnly = true;
            // 
            // col_hidden_detailpath
            // 
            this.col_hidden_detailpath.HeaderText = "col_hidden_detailpath";
            this.col_hidden_detailpath.Name = "col_hidden_detailpath";
            this.col_hidden_detailpath.ReadOnly = true;
            // 
            // col_hidden_imgpath
            // 
            this.col_hidden_imgpath.HeaderText = "col_hidden_imgpath";
            this.col_hidden_imgpath.Name = "col_hidden_imgpath";
            this.col_hidden_imgpath.ReadOnly = true;
            // 
            // txtPfImgFilePath
            // 
            this.txtPfImgFilePath.Location = new System.Drawing.Point(277, 426);
            this.txtPfImgFilePath.Name = "txtPfImgFilePath";
            this.txtPfImgFilePath.Size = new System.Drawing.Size(22, 21);
            this.txtPfImgFilePath.TabIndex = 78;
            // 
            // txtImgFolderPath
            // 
            this.txtImgFolderPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtImgFolderPath.Location = new System.Drawing.Point(303, 426);
            this.txtImgFolderPath.Name = "txtImgFolderPath";
            this.txtImgFolderPath.Size = new System.Drawing.Size(22, 21);
            this.txtImgFolderPath.TabIndex = 77;
            // 
            // txtSaveMode
            // 
            this.txtSaveMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSaveMode.Location = new System.Drawing.Point(331, 426);
            this.txtSaveMode.Name = "txtSaveMode";
            this.txtSaveMode.Size = new System.Drawing.Size(22, 21);
            this.txtSaveMode.TabIndex = 74;
            // 
            // txtDetailTextPath
            // 
            this.txtDetailTextPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDetailTextPath.Location = new System.Drawing.Point(223, 426);
            this.txtDetailTextPath.Name = "txtDetailTextPath";
            this.txtDetailTextPath.Size = new System.Drawing.Size(22, 21);
            this.txtDetailTextPath.TabIndex = 76;
            // 
            // txtTextFilePath
            // 
            this.txtTextFilePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTextFilePath.Location = new System.Drawing.Point(194, 426);
            this.txtTextFilePath.Name = "txtTextFilePath";
            this.txtTextFilePath.Size = new System.Drawing.Size(22, 21);
            this.txtTextFilePath.TabIndex = 75;
            // 
            // lblCPage
            // 
            this.lblCPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCPage.AutoSize = true;
            this.lblCPage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCPage.Location = new System.Drawing.Point(179, 207);
            this.lblCPage.Name = "lblCPage";
            this.lblCPage.Size = new System.Drawing.Size(12, 12);
            this.lblCPage.TabIndex = 81;
            this.lblCPage.Text = "1";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl1.Location = new System.Drawing.Point(200, 207);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(12, 12);
            this.lbl1.TabIndex = 80;
            this.lbl1.Text = "/";
            // 
            // lblLPage
            // 
            this.lblLPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLPage.AutoSize = true;
            this.lblLPage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLPage.Location = new System.Drawing.Point(212, 207);
            this.lblLPage.Name = "lblLPage";
            this.lblLPage.Size = new System.Drawing.Size(19, 12);
            this.lblLPage.TabIndex = 79;
            this.lblLPage.Text = "10";
            // 
            // txtOri_Num
            // 
            this.txtOri_Num.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtOri_Num.Location = new System.Drawing.Point(12, 426);
            this.txtOri_Num.Name = "txtOri_Num";
            this.txtOri_Num.Size = new System.Drawing.Size(22, 21);
            this.txtOri_Num.TabIndex = 83;
            // 
            // txtOri_Name
            // 
            this.txtOri_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtOri_Name.Location = new System.Drawing.Point(40, 426);
            this.txtOri_Name.Name = "txtOri_Name";
            this.txtOri_Name.Size = new System.Drawing.Size(22, 21);
            this.txtOri_Name.TabIndex = 82;
            // 
            // cmsContextMenuStrip
            // 
            this.cmsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiSelectAll,
            this.tsmiFont,
            this.tsmiColor});
            this.cmsContextMenuStrip.Name = "cmsContextMenuStrip";
            this.cmsContextMenuStrip.Size = new System.Drawing.Size(143, 136);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(142, 22);
            this.tsmiCut.Text = "잘라내기";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(142, 22);
            this.tsmiCopy.Text = "복사";
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(142, 22);
            this.tsmiPaste.Text = "붙여놓기";
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(142, 22);
            this.tsmiSelectAll.Text = "모두 선택";
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(142, 22);
            this.tsmiFont.Text = "폰트 지정";
            // 
            // tsmiColor
            // 
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(142, 22);
            this.tsmiColor.Text = "폰트 색 지정";
            // 
            // pnlPicBox
            // 
            this.pnlPicBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPicBox.BackgroundImage")));
            this.pnlPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPicBox.Controls.Add(this.picImg);
            this.pnlPicBox.Location = new System.Drawing.Point(4, 64);
            this.pnlPicBox.Name = "pnlPicBox";
            this.pnlPicBox.Size = new System.Drawing.Size(169, 161);
            this.pnlPicBox.TabIndex = 85;
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSet.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSet.Location = new System.Drawing.Point(255, 149);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(98, 32);
            this.btnSet.TabIndex = 86;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnUnset
            // 
            this.btnUnset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUnset.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUnset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUnset.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUnset.Location = new System.Drawing.Point(255, 187);
            this.btnUnset.Name = "btnUnset";
            this.btnUnset.Size = new System.Drawing.Size(98, 32);
            this.btnUnset.TabIndex = 87;
            this.btnUnset.Text = "UnSet";
            this.btnUnset.UseVisualStyleBackColor = false;
            this.btnUnset.Click += new System.EventHandler(this.btnUnset_Click);
            // 
            // Form_Skill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 452);
            this.Controls.Add(this.btnUnset);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.pnlPicBox);
            this.Controls.Add(this.txtOri_Num);
            this.Controls.Add(this.txtOri_Name);
            this.Controls.Add(this.lblCPage);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblLPage);
            this.Controls.Add(this.txtPfImgFilePath);
            this.Controls.Add(this.txtImgFolderPath);
            this.Controls.Add(this.txtDetailTextPath);
            this.Controls.Add(this.txtTextFilePath);
            this.Controls.Add(this.txtSaveMode);
            this.Controls.Add(this.dtgHdnInfo);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.lblChNo);
            this.Controls.Add(this.lblCNlbl);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.lblNlbl);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.dtgDetail_Info);
            this.Controls.Add(this.rtxMemo);
            this.Name = "Form_Skill";
            this.Text = "Skill";
            this.Load += new System.EventHandler(this.Form_Skill_Load);
            this.Resize += new System.EventHandler(this.Form_Skill_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetail_Info)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput_ChNum)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHdnInfo)).EndInit();
            this.cmsContextMenuStrip.ResumeLayout(false);
            this.pnlPicBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.RichTextBox rtxMemo;
        private System.Windows.Forms.DataGridView dtgDetail_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lbldetail;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        public System.Windows.Forms.Label lblNlbl;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblCNlbl;
        public System.Windows.Forms.Label lblChNo;
        private System.Windows.Forms.DataGridView dtgHdnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hidden_filepath;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hidden_detailpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hidden_imgpath;
        public System.Windows.Forms.TextBox txtPfImgFilePath;
        private System.Windows.Forms.TextBox txtImgFolderPath;
        private System.Windows.Forms.TextBox txtSaveMode;
        private System.Windows.Forms.TextBox txtDetailTextPath;
        private System.Windows.Forms.TextBox txtTextFilePath;
        private System.Windows.Forms.NumericUpDown nudInput_ChNum;
        private System.Windows.Forms.Label lblChNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCPage;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblLPage;
        private System.Windows.Forms.TextBox txtOri_Num;
        private System.Windows.Forms.TextBox txtOri_Name;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.FontDialog fndFontDialog;
        private System.Windows.Forms.ColorDialog cldColorDialog;
        private System.Windows.Forms.ContextMenuStrip cmsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.Panel pnlPicBox;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnUnset;
    }
}