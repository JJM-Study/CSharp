
namespace Project
{
    partial class Form_SkillList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SkillList));
            this.ilImageList = new System.Windows.Forms.ImageList(this.components);
            this.lvISkillList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ilImageList
            // 
            this.ilImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImageList.ImageStream")));
            this.ilImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImageList.Images.SetKeyName(0, "551A394A433A900012.jpg");
            this.ilImageList.Images.SetKeyName(1, "4E4D280734388A4B8C.jpg");
            // 
            // lvISkillList
            // 
            this.lvISkillList.HideSelection = false;
            this.lvISkillList.Location = new System.Drawing.Point(12, 12);
            this.lvISkillList.Name = "lvISkillList";
            this.lvISkillList.Size = new System.Drawing.Size(209, 394);
            this.lvISkillList.SmallImageList = this.ilImageList;
            this.lvISkillList.TabIndex = 0;
            this.lvISkillList.UseCompatibleStateImageBehavior = false;
            this.lvISkillList.View = System.Windows.Forms.View.List;
            // 
            // Form_SkillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 394);
            this.Controls.Add(this.lvISkillList);
            this.Name = "Form_SkillList";
            this.Text = "Form_SkillList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilImageList;
        private System.Windows.Forms.ListView lvISkillList;
    }
}