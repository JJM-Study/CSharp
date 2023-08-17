
namespace Project
{
    partial class Main_Form
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
            this.btnNote = new System.Windows.Forms.Button();
            this.btnStory = new System.Windows.Forms.Button();
            this.dtgGroup = new System.Windows.Forms.DataGridView();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.btnWorld = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNote
            // 
            this.btnNote.Location = new System.Drawing.Point(12, 12);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(80, 70);
            this.btnNote.TabIndex = 0;
            this.btnNote.Text = "노트";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnStory
            // 
            this.btnStory.Location = new System.Drawing.Point(98, 12);
            this.btnStory.Name = "btnStory";
            this.btnStory.Size = new System.Drawing.Size(80, 70);
            this.btnStory.TabIndex = 1;
            this.btnStory.Text = "스토리";
            this.btnStory.UseVisualStyleBackColor = true;
            this.btnStory.Click += new System.EventHandler(this.btnStory_Click);
            // 
            // dtgGroup
            // 
            this.dtgGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group});
            this.dtgGroup.Location = new System.Drawing.Point(477, 38);
            this.dtgGroup.Name = "dtgGroup";
            this.dtgGroup.RowHeadersVisible = false;
            this.dtgGroup.RowTemplate.Height = 23;
            this.dtgGroup.Size = new System.Drawing.Size(123, 83);
            this.dtgGroup.TabIndex = 2;
            // 
            // Group
            // 
            this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "환경설정";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroup.Location = new System.Drawing.Point(488, 12);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(93, 15);
            this.lblGroup.TabIndex = 4;
            this.lblGroup.Text = "그룹 만들기";
            // 
            // btnWorld
            // 
            this.btnWorld.Location = new System.Drawing.Point(184, 12);
            this.btnWorld.Name = "btnWorld";
            this.btnWorld.Size = new System.Drawing.Size(80, 70);
            this.btnWorld.TabIndex = 5;
            this.btnWorld.Text = "세계관";
            this.btnWorld.UseVisualStyleBackColor = true;
            this.btnWorld.Click += new System.EventHandler(this.btnWorld_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(270, 12);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(80, 70);
            this.btnItem.TabIndex = 6;
            this.btnItem.Text = "아이템";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 134);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnWorld);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtgGroup);
            this.Controls.Add(this.btnStory);
            this.Controls.Add(this.btnNote);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnStory;
        private System.Windows.Forms.DataGridView dtgGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnWorld;
        private System.Windows.Forms.Button btnItem;
    }
}