namespace TestRandomSelector
{
    partial class Form1
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
            this.btnGenerateGroup = new System.Windows.Forms.Button();
            this.lstAllStudents = new System.Windows.Forms.ListBox();
            this.lstGroup = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.lblMembers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateGroup
            // 
            this.btnGenerateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateGroup.Location = new System.Drawing.Point(454, 143);
            this.btnGenerateGroup.Name = "btnGenerateGroup";
            this.btnGenerateGroup.Size = new System.Drawing.Size(158, 45);
            this.btnGenerateGroup.TabIndex = 2;
            this.btnGenerateGroup.Text = "Make a group";
            this.btnGenerateGroup.UseVisualStyleBackColor = true;
            this.btnGenerateGroup.Click += new System.EventHandler(this.btnGenerateGroup_Click);
            // 
            // lstAllStudents
            // 
            this.lstAllStudents.FormattingEnabled = true;
            this.lstAllStudents.Location = new System.Drawing.Point(103, 211);
            this.lstAllStudents.Name = "lstAllStudents";
            this.lstAllStudents.Size = new System.Drawing.Size(169, 186);
            this.lstAllStudents.TabIndex = 3;
            this.lstAllStudents.SelectedIndexChanged += new System.EventHandler(this.lstAllStudents_SelectedIndexChanged);
            // 
            // lstGroup
            // 
            this.lstGroup.FormattingEnabled = true;
            this.lstGroup.Location = new System.Drawing.Point(454, 211);
            this.lstGroup.Name = "lstGroup";
            this.lstGroup.Size = new System.Drawing.Size(158, 186);
            this.lstGroup.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(29, 400);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 5;
            this.lblError.Visible = false;
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.Location = new System.Drawing.Point(454, 73);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(100, 43);
            this.lstMembers.TabIndex = 6;
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.Location = new System.Drawing.Point(451, 54);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(196, 16);
            this.lblMembers.TabIndex = 7;
            this.lblMembers.Text = "Enter a number of members";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lstGroup);
            this.Controls.Add(this.lstAllStudents);
            this.Controls.Add(this.btnGenerateGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerateGroup;
        private System.Windows.Forms.ListBox lstAllStudents;
        private System.Windows.Forms.ListBox lstGroup;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Label lblMembers;
    }
}

