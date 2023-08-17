
namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.fndFontDialog = new System.Windows.Forms.FontDialog();
            this.cldColorDialog = new System.Windows.Forms.ColorDialog();
            this.rtxMemo = new System.Windows.Forms.RichTextBox();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.col_header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.lblImgAdd = new System.Windows.Forms.Label();
            this.txtDetailTextPath = new System.Windows.Forms.TextBox();
            this.txtImgFolderPath = new System.Windows.Forms.TextBox();
            this.txtOri_Num = new System.Windows.Forms.TextBox();
            this.txtOriNum = new System.Windows.Forms.TextBox();
            this.txtOri_Name = new System.Windows.Forms.TextBox();
            this.txtTextFilePath = new System.Windows.Forms.TextBox();
            this.txtSaveMode = new System.Windows.Forms.TextBox();
            this.lblCPage = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblLPage = new System.Windows.Forms.Label();
            this.dtgHdnInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hidden_filepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hidden_detailpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hidden_imgpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDetail_Info = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblChNum = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudInput_NtNum = new System.Windows.Forms.NumericUpDown();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lbllist = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lbldetail = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.picPfimgBox = new System.Windows.Forms.PictureBox();
            this.pnlPicBox = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmsContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHdnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetail_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput_NtNum)).BeginInit();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPfimgBox)).BeginInit();
            this.SuspendLayout();
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
            // rtxMemo
            // 
            this.rtxMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxMemo.ContextMenuStrip = this.cmsContextMenuStrip;
            this.rtxMemo.Location = new System.Drawing.Point(136, 70);
            this.rtxMemo.Name = "rtxMemo";
            this.rtxMemo.Size = new System.Drawing.Size(432, 440);
            this.rtxMemo.TabIndex = 25;
            this.rtxMemo.Text = "";
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
            this.dtgList.Location = new System.Drawing.Point(748, 131);
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersVisible = false;
            this.dtgList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgList.RowTemplate.Height = 23;
            this.dtgList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgList.Size = new System.Drawing.Size(169, 377);
            this.dtgList.TabIndex = 27;
            this.dtgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellClick);
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
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // lblImgAdd
            // 
            this.lblImgAdd.AutoSize = true;
            this.lblImgAdd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblImgAdd.Location = new System.Drawing.Point(53, 193);
            this.lblImgAdd.Name = "lblImgAdd";
            this.lblImgAdd.Size = new System.Drawing.Size(75, 12);
            this.lblImgAdd.TabIndex = 33;
            this.lblImgAdd.Text = "Add Image";
            // 
            // txtDetailTextPath
            // 
            this.txtDetailTextPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDetailTextPath.Location = new System.Drawing.Point(475, 525);
            this.txtDetailTextPath.Name = "txtDetailTextPath";
            this.txtDetailTextPath.Size = new System.Drawing.Size(22, 21);
            this.txtDetailTextPath.TabIndex = 48;
            this.txtDetailTextPath.Visible = false;
            // 
            // txtImgFolderPath
            // 
            this.txtImgFolderPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtImgFolderPath.Location = new System.Drawing.Point(416, 525);
            this.txtImgFolderPath.Name = "txtImgFolderPath";
            this.txtImgFolderPath.Size = new System.Drawing.Size(22, 21);
            this.txtImgFolderPath.TabIndex = 47;
            this.txtImgFolderPath.Visible = false;
            // 
            // txtOri_Num
            // 
            this.txtOri_Num.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtOri_Num.Location = new System.Drawing.Point(242, 525);
            this.txtOri_Num.Name = "txtOri_Num";
            this.txtOri_Num.Size = new System.Drawing.Size(22, 21);
            this.txtOri_Num.TabIndex = 46;
            this.txtOri_Num.Visible = false;
            // 
            // txtOriNum
            // 
            this.txtOriNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtOriNum.Location = new System.Drawing.Point(213, 525);
            this.txtOriNum.Name = "txtOriNum";
            this.txtOriNum.Size = new System.Drawing.Size(22, 21);
            this.txtOriNum.TabIndex = 45;
            this.txtOriNum.Visible = false;
            // 
            // txtOri_Name
            // 
            this.txtOri_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtOri_Name.Location = new System.Drawing.Point(298, 525);
            this.txtOri_Name.Name = "txtOri_Name";
            this.txtOri_Name.Size = new System.Drawing.Size(22, 21);
            this.txtOri_Name.TabIndex = 44;
            this.txtOri_Name.Visible = false;
            // 
            // txtTextFilePath
            // 
            this.txtTextFilePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTextFilePath.Location = new System.Drawing.Point(446, 525);
            this.txtTextFilePath.Name = "txtTextFilePath";
            this.txtTextFilePath.Size = new System.Drawing.Size(22, 21);
            this.txtTextFilePath.TabIndex = 43;
            this.txtTextFilePath.Visible = false;
            // 
            // txtSaveMode
            // 
            this.txtSaveMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSaveMode.Location = new System.Drawing.Point(270, 525);
            this.txtSaveMode.Name = "txtSaveMode";
            this.txtSaveMode.Size = new System.Drawing.Size(22, 21);
            this.txtSaveMode.TabIndex = 41;
            this.txtSaveMode.Visible = false;
            // 
            // lblCPage
            // 
            this.lblCPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCPage.AutoSize = true;
            this.lblCPage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCPage.Location = new System.Drawing.Point(329, 530);
            this.lblCPage.Name = "lblCPage";
            this.lblCPage.Size = new System.Drawing.Size(12, 12);
            this.lblCPage.TabIndex = 40;
            this.lblCPage.Text = "1";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl1.Location = new System.Drawing.Point(350, 530);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(12, 12);
            this.lbl1.TabIndex = 39;
            this.lbl1.Text = "/";
            // 
            // lblLPage
            // 
            this.lblLPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLPage.AutoSize = true;
            this.lblLPage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLPage.Location = new System.Drawing.Point(362, 530);
            this.lblLPage.Name = "lblLPage";
            this.lblLPage.Size = new System.Drawing.Size(19, 12);
            this.lblLPage.TabIndex = 38;
            this.lblLPage.Text = "10";
            // 
            // dtgHdnInfo
            // 
            this.dtgHdnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgHdnInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHdnInfo.ColumnHeadersVisible = false;
            this.dtgHdnInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.col_hidden_filepath,
            this.col_hidden_detailpath,
            this.col_hidden_imgpath});
            this.dtgHdnInfo.Location = new System.Drawing.Point(748, 515);
            this.dtgHdnInfo.Name = "dtgHdnInfo";
            this.dtgHdnInfo.ReadOnly = true;
            this.dtgHdnInfo.RowHeadersVisible = false;
            this.dtgHdnInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgHdnInfo.RowTemplate.Height = 23;
            this.dtgHdnInfo.Size = new System.Drawing.Size(169, 42);
            this.dtgHdnInfo.TabIndex = 58;
            this.dtgHdnInfo.Visible = false;
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
            // dtgDetail_Info
            // 
            this.dtgDetail_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDetail_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetail_Info.ColumnHeadersVisible = false;
            this.dtgDetail_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgDetail_Info.Location = new System.Drawing.Point(573, 131);
            this.dtgDetail_Info.Name = "dtgDetail_Info";
            this.dtgDetail_Info.RowHeadersVisible = false;
            this.dtgDetail_Info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgDetail_Info.RowTemplate.Height = 23;
            this.dtgDetail_Info.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDetail_Info.Size = new System.Drawing.Size(169, 377);
            this.dtgDetail_Info.TabIndex = 60;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(111, 21);
            this.txtName.TabIndex = 50;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(118, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 12);
            this.lblName.TabIndex = 51;
            this.lblName.Text = "Name";
            // 
            // lblChNum
            // 
            this.lblChNum.AutoSize = true;
            this.lblChNum.Location = new System.Drawing.Point(6, 20);
            this.lblChNum.Name = "lblChNum";
            this.lblChNum.Size = new System.Drawing.Size(51, 12);
            this.lblChNum.TabIndex = 52;
            this.lblChNum.Text = "Note.No";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(745, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 54);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudInput_NtNum
            // 
            this.nudInput_NtNum.Location = new System.Drawing.Point(60, 16);
            this.nudInput_NtNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInput_NtNum.Name = "nudInput_NtNum";
            this.nudInput_NtNum.Size = new System.Drawing.Size(52, 21);
            this.nudInput_NtNum.TabIndex = 54;
            this.nudInput_NtNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Aqua;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.Location = new System.Drawing.Point(660, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 54);
            this.btnNew.TabIndex = 55;
            this.btnNew.Text = "New Note";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(830, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 54);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnl1
            // 
            this.pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl1.Controls.Add(this.lbllist);
            this.pnl1.Location = new System.Drawing.Point(748, 69);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(165, 56);
            this.pnl1.TabIndex = 57;
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
            // pnl2
            // 
            this.pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(250)))), ((int)(((byte)(192)))));
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.lbldetail);
            this.pnl2.Location = new System.Drawing.Point(574, 69);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(168, 56);
            this.pnl2.TabIndex = 61;
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
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.btnMain);
            this.pnlInput.Controls.Add(this.txtName);
            this.pnlInput.Controls.Add(this.lblName);
            this.pnlInput.Controls.Add(this.lblChNum);
            this.pnlInput.Controls.Add(this.nudInput_NtNum);
            this.pnlInput.Controls.Add(this.btnNew);
            this.pnlInput.Controls.Add(this.btnDelete);
            this.pnlInput.Controls.Add(this.btnSave);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(916, 64);
            this.pnlInput.TabIndex = 64;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.MintCream;
            this.btnMain.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMain.Location = new System.Drawing.Point(575, 5);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(79, 54);
            this.btnMain.TabIndex = 57;
            this.btnMain.Text = "To Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Visible = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Image = global::Project.Properties.Resources.Prev;
            this.btnPrev.Location = new System.Drawing.Point(25, 444);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 64);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Image = global::Project.Properties.Resources.Next;
            this.btnNext.Location = new System.Drawing.Point(65, 444);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 64);
            this.btnNext.TabIndex = 12;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picPfimgBox
            // 
            this.picPfimgBox.BackColor = System.Drawing.SystemColors.Control;
            this.picPfimgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPfimgBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPfimgBox.Image = global::Project.Properties.Resources.Add_Image;
            this.picPfimgBox.Location = new System.Drawing.Point(18, 80);
            this.picPfimgBox.Name = "picPfimgBox";
            this.picPfimgBox.Size = new System.Drawing.Size(100, 100);
            this.picPfimgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPfimgBox.TabIndex = 31;
            this.picPfimgBox.TabStop = false;
            this.picPfimgBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pnlPicBox
            // 
            this.pnlPicBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPicBox.BackgroundImage")));
            this.pnlPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPicBox.Location = new System.Drawing.Point(8, 70);
            this.pnlPicBox.Name = "pnlPicBox";
            this.pnlPicBox.Size = new System.Drawing.Size(120, 120);
            this.pnlPicBox.TabIndex = 32;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "col_button";
            this.dataGridViewImageColumn1.Image = global::Project.Properties.Resources.mini_Delete1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(916, 558);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.dtgDetail_Info);
            this.Controls.Add(this.dtgHdnInfo);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.txtDetailTextPath);
            this.Controls.Add(this.txtImgFolderPath);
            this.Controls.Add(this.txtOri_Num);
            this.Controls.Add(this.txtOriNum);
            this.Controls.Add(this.txtOri_Name);
            this.Controls.Add(this.txtTextFilePath);
            this.Controls.Add(this.txtSaveMode);
            this.Controls.Add(this.lblCPage);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblLPage);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblImgAdd);
            this.Controls.Add(this.picPfimgBox);
            this.Controls.Add(this.pnlPicBox);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.rtxMemo);
            this.Name = "Form1";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHdnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetail_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput_NtNum)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPfimgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fndFontDialog;
        private System.Windows.Forms.ColorDialog cldColorDialog;
        private System.Windows.Forms.ContextMenuStrip cmsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.RichTextBox rtxMemo;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblImgAdd;
        public System.Windows.Forms.PictureBox picPfimgBox;
        private System.Windows.Forms.Panel pnlPicBox;
        private System.Windows.Forms.TextBox txtDetailTextPath;
        private System.Windows.Forms.TextBox txtImgFolderPath;
        private System.Windows.Forms.TextBox txtOri_Num;
        private System.Windows.Forms.TextBox txtOriNum;
        private System.Windows.Forms.TextBox txtOri_Name;
        private System.Windows.Forms.TextBox txtTextFilePath;
        private System.Windows.Forms.TextBox txtSaveMode;
        private System.Windows.Forms.Label lblCPage;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblLPage;
        private System.Windows.Forms.DataGridView dtgHdnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hidden_filepath;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hidden_detailpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hidden_imgpath;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridView dtgDetail_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblChNum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudInput_NtNum;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lbldetail;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnMain;
    }
}

