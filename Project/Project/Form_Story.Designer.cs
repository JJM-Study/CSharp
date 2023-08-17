
namespace Project
{
    partial class Form_Story
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
            this.spl1 = new System.Windows.Forms.SplitContainer();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.rtxMemo = new System.Windows.Forms.RichTextBox();
            this.cmsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.col_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lbllist = new System.Windows.Forms.Label();
            this.pn1 = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.nudInput_ChNum = new System.Windows.Forms.NumericUpDown();
            this.lblChNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHidePnl1 = new System.Windows.Forms.Button();
            this.btnFixPnl1Height = new System.Windows.Forms.Button();
            this.dtgHdnInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hidden_filepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hidden_detailpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hidden_imgpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSaveMode = new System.Windows.Forms.TextBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lbldetail = new System.Windows.Forms.Label();
            this.dtgDetail_Info = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCPage = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblLPage = new System.Windows.Forms.Label();
            this.cldColorDialog = new System.Windows.Forms.ColorDialog();
            this.fndFontDialog = new System.Windows.Forms.FontDialog();
            this.txtDetailTextPath = new System.Windows.Forms.TextBox();
            this.txtTextFilePath = new System.Windows.Forms.TextBox();
            this.txtImgFolderPath = new System.Windows.Forms.TextBox();
            this.txtOri_Num = new System.Windows.Forms.TextBox();
            this.txtOri_Name = new System.Windows.Forms.TextBox();
            this.txtPfImgFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spl1)).BeginInit();
            this.spl1.Panel1.SuspendLayout();
            this.spl1.Panel2.SuspendLayout();
            this.spl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.cmsContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.pnl1.SuspendLayout();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput_ChNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHdnInfo)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetail_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // spl1
            // 
            this.spl1.Location = new System.Drawing.Point(177, 76);
            this.spl1.Name = "spl1";
            this.spl1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spl1.Panel1
            // 
            this.spl1.Panel1.Controls.Add(this.picImg);
            // 
            // spl1.Panel2
            // 
            this.spl1.Panel2.Controls.Add(this.rtxMemo);
            this.spl1.Size = new System.Drawing.Size(443, 497);
            this.spl1.SplitterDistance = 180;
            this.spl1.TabIndex = 0;
            // 
            // picImg
            // 
            this.picImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImg.Image = global::Project.Properties.Resources.Add_Image;
            this.picImg.Location = new System.Drawing.Point(0, 0);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(443, 180);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            this.picImg.Click += new System.EventHandler(this.picImg_Click);
            // 
            // rtxMemo
            // 
            this.rtxMemo.ContextMenuStrip = this.cmsContextMenuStrip;
            this.rtxMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxMemo.Location = new System.Drawing.Point(0, 0);
            this.rtxMemo.Name = "rtxMemo";
            this.rtxMemo.Size = new System.Drawing.Size(443, 313);
            this.rtxMemo.TabIndex = 26;
            this.rtxMemo.Text = "";
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
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(142, 22);
            this.tsmiCopy.Text = "복사";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(142, 22);
            this.tsmiPaste.Text = "붙여놓기";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(142, 22);
            this.tsmiSelectAll.Text = "모두 선택";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(142, 22);
            this.tsmiFont.Text = "폰트 지정";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiColor
            // 
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(142, 22);
            this.tsmiColor.Text = "폰트 색 지정";
            this.tsmiColor.Click += new System.EventHandler(this.tsmiColor_Click);
            // 
            // dtgList
            // 
            this.dtgList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.ColumnHeadersVisible = false;
            this.dtgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Num,
            this.col_Info});
            this.dtgList.Location = new System.Drawing.Point(795, 146);
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersVisible = false;
            this.dtgList.RowTemplate.Height = 23;
            this.dtgList.Size = new System.Drawing.Size(165, 427);
            this.dtgList.TabIndex = 1;
            this.dtgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellClick);
            // 
            // col_Num
            // 
            this.col_Num.HeaderText = "col_Header";
            this.col_Num.Name = "col_Num";
            this.col_Num.Width = 50;
            // 
            // col_Info
            // 
            this.col_Info.HeaderText = "col_Info";
            this.col_Info.Name = "col_Info";
            this.col_Info.Width = 112;
            // 
            // pnl1
            // 
            this.pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl1.Controls.Add(this.lbllist);
            this.pnl1.Location = new System.Drawing.Point(795, 78);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(165, 62);
            this.pnl1.TabIndex = 58;
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("굴림체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbllist.Location = new System.Drawing.Point(16, 12);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(117, 37);
            this.lbllist.TabIndex = 0;
            this.lbllist.Text = " List";
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.btnMain);
            this.pn1.Controls.Add(this.nudInput_ChNum);
            this.pn1.Controls.Add(this.lblChNum);
            this.pn1.Controls.Add(this.lblName);
            this.pn1.Controls.Add(this.txtName);
            this.pn1.Controls.Add(this.btnDelete);
            this.pn1.Controls.Add(this.btnNew);
            this.pn1.Controls.Add(this.btnSave);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(966, 70);
            this.pn1.TabIndex = 59;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.MintCream;
            this.btnMain.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMain.Location = new System.Drawing.Point(626, 8);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(79, 54);
            this.btnMain.TabIndex = 64;
            this.btnMain.Text = "To Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // nudInput_ChNum
            // 
            this.nudInput_ChNum.Location = new System.Drawing.Point(63, 25);
            this.nudInput_ChNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInput_ChNum.Name = "nudInput_ChNum";
            this.nudInput_ChNum.Size = new System.Drawing.Size(52, 21);
            this.nudInput_ChNum.TabIndex = 63;
            this.nudInput_ChNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblChNum
            // 
            this.lblChNum.AutoSize = true;
            this.lblChNum.Location = new System.Drawing.Point(23, 29);
            this.lblChNum.Name = "lblChNum";
            this.lblChNum.Size = new System.Drawing.Size(25, 12);
            this.lblChNum.TabIndex = 62;
            this.lblChNum.Text = "No.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(131, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 61;
            this.lblName.Text = "Title";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(111, 21);
            this.txtName.TabIndex = 60;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(881, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 54);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Aqua;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.Location = new System.Drawing.Point(711, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 54);
            this.btnNew.TabIndex = 58;
            this.btnNew.Text = "New Story";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(796, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 54);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHidePnl1
            // 
            this.btnHidePnl1.Location = new System.Drawing.Point(90, 78);
            this.btnHidePnl1.Name = "btnHidePnl1";
            this.btnHidePnl1.Size = new System.Drawing.Size(81, 35);
            this.btnHidePnl1.TabIndex = 60;
            this.btnHidePnl1.Text = "그림 숨김";
            this.btnHidePnl1.UseVisualStyleBackColor = true;
            this.btnHidePnl1.Click += new System.EventHandler(this.btnHidePnl1_Click);
            // 
            // btnFixPnl1Height
            // 
            this.btnFixPnl1Height.Location = new System.Drawing.Point(3, 78);
            this.btnFixPnl1Height.Name = "btnFixPnl1Height";
            this.btnFixPnl1Height.Size = new System.Drawing.Size(81, 35);
            this.btnFixPnl1Height.TabIndex = 61;
            this.btnFixPnl1Height.Text = "이미지 현재 크기 고정";
            this.btnFixPnl1Height.UseVisualStyleBackColor = true;
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
            this.dtgHdnInfo.Location = new System.Drawing.Point(3, 456);
            this.dtgHdnInfo.Name = "dtgHdnInfo";
            this.dtgHdnInfo.ReadOnly = true;
            this.dtgHdnInfo.RowHeadersVisible = false;
            this.dtgHdnInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgHdnInfo.RowTemplate.Height = 23;
            this.dtgHdnInfo.Size = new System.Drawing.Size(169, 42);
            this.dtgHdnInfo.TabIndex = 62;
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
            // txtSaveMode
            // 
            this.txtSaveMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSaveMode.Location = new System.Drawing.Point(150, 504);
            this.txtSaveMode.Name = "txtSaveMode";
            this.txtSaveMode.Size = new System.Drawing.Size(22, 21);
            this.txtSaveMode.TabIndex = 42;
            // 
            // pnl2
            // 
            this.pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(192)))));
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.lbldetail);
            this.pnl2.Location = new System.Drawing.Point(625, 78);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(165, 62);
            this.pnl2.TabIndex = 63;
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
            // dtgDetail_Info
            // 
            this.dtgDetail_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDetail_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetail_Info.ColumnHeadersVisible = false;
            this.dtgDetail_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgDetail_Info.Location = new System.Drawing.Point(625, 146);
            this.dtgDetail_Info.Name = "dtgDetail_Info";
            this.dtgDetail_Info.RowHeadersVisible = false;
            this.dtgDetail_Info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgDetail_Info.RowTemplate.Height = 23;
            this.dtgDetail_Info.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDetail_Info.Size = new System.Drawing.Size(165, 427);
            this.dtgDetail_Info.TabIndex = 64;
            this.dtgDetail_Info.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgDetail_Info_KeyDown);
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
            // lblCPage
            // 
            this.lblCPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCPage.AutoSize = true;
            this.lblCPage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCPage.Location = new System.Drawing.Point(61, 557);
            this.lblCPage.Name = "lblCPage";
            this.lblCPage.Size = new System.Drawing.Size(12, 12);
            this.lblCPage.TabIndex = 67;
            this.lblCPage.Text = "1";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl1.Location = new System.Drawing.Point(82, 557);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(12, 12);
            this.lbl1.TabIndex = 66;
            this.lbl1.Text = "/";
            // 
            // lblLPage
            // 
            this.lblLPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLPage.AutoSize = true;
            this.lblLPage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLPage.Location = new System.Drawing.Point(94, 557);
            this.lblLPage.Name = "lblLPage";
            this.lblLPage.Size = new System.Drawing.Size(19, 12);
            this.lblLPage.TabIndex = 65;
            this.lblLPage.Text = "10";
            // 
            // txtDetailTextPath
            // 
            this.txtDetailTextPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDetailTextPath.Location = new System.Drawing.Point(41, 530);
            this.txtDetailTextPath.Name = "txtDetailTextPath";
            this.txtDetailTextPath.Size = new System.Drawing.Size(22, 21);
            this.txtDetailTextPath.TabIndex = 69;
            // 
            // txtTextFilePath
            // 
            this.txtTextFilePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTextFilePath.Location = new System.Drawing.Point(12, 530);
            this.txtTextFilePath.Name = "txtTextFilePath";
            this.txtTextFilePath.Size = new System.Drawing.Size(22, 21);
            this.txtTextFilePath.TabIndex = 68;
            // 
            // txtImgFolderPath
            // 
            this.txtImgFolderPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtImgFolderPath.Location = new System.Drawing.Point(122, 504);
            this.txtImgFolderPath.Name = "txtImgFolderPath";
            this.txtImgFolderPath.Size = new System.Drawing.Size(22, 21);
            this.txtImgFolderPath.TabIndex = 70;
            // 
            // txtOri_Num
            // 
            this.txtOri_Num.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtOri_Num.Location = new System.Drawing.Point(12, 418);
            this.txtOri_Num.Name = "txtOri_Num";
            this.txtOri_Num.Size = new System.Drawing.Size(22, 21);
            this.txtOri_Num.TabIndex = 72;
            // 
            // txtOri_Name
            // 
            this.txtOri_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtOri_Name.Location = new System.Drawing.Point(40, 418);
            this.txtOri_Name.Name = "txtOri_Name";
            this.txtOri_Name.Size = new System.Drawing.Size(22, 21);
            this.txtOri_Name.TabIndex = 71;
            // 
            // txtPfImgFilePath
            // 
            this.txtPfImgFilePath.Location = new System.Drawing.Point(96, 504);
            this.txtPfImgFilePath.Name = "txtPfImgFilePath";
            this.txtPfImgFilePath.Size = new System.Drawing.Size(22, 21);
            this.txtPfImgFilePath.TabIndex = 73;
            // 
            // Form_Story
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 578);
            this.Controls.Add(this.txtPfImgFilePath);
            this.Controls.Add(this.txtOri_Num);
            this.Controls.Add(this.txtOri_Name);
            this.Controls.Add(this.txtImgFolderPath);
            this.Controls.Add(this.txtDetailTextPath);
            this.Controls.Add(this.txtTextFilePath);
            this.Controls.Add(this.lblCPage);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblLPage);
            this.Controls.Add(this.dtgDetail_Info);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.txtSaveMode);
            this.Controls.Add(this.btnFixPnl1Height);
            this.Controls.Add(this.btnHidePnl1);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.spl1);
            this.Controls.Add(this.dtgHdnInfo);
            this.Name = "Form_Story";
            this.Text = "Story";
            this.Load += new System.EventHandler(this.Form_Set_Load);
            this.spl1.Panel1.ResumeLayout(false);
            this.spl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl1)).EndInit();
            this.spl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.cmsContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput_ChNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHdnInfo)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetail_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spl1;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.RichTextBox rtxMemo;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHidePnl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Info;
        private System.Windows.Forms.NumericUpDown nudInput_ChNum;
        private System.Windows.Forms.Label lblChNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnFixPnl1Height;
        private System.Windows.Forms.DataGridView dtgHdnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hidden_filepath;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hidden_detailpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hidden_imgpath;
        private System.Windows.Forms.TextBox txtSaveMode;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lbldetail;
        private System.Windows.Forms.DataGridView dtgDetail_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblCPage;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblLPage;
        private System.Windows.Forms.ColorDialog cldColorDialog;
        private System.Windows.Forms.ContextMenuStrip cmsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.FontDialog fndFontDialog;
        private System.Windows.Forms.TextBox txtDetailTextPath;
        private System.Windows.Forms.TextBox txtTextFilePath;
        private System.Windows.Forms.TextBox txtImgFolderPath;
        private System.Windows.Forms.TextBox txtOri_Num;
        private System.Windows.Forms.TextBox txtOri_Name;
        public System.Windows.Forms.TextBox txtPfImgFilePath;
    }
}