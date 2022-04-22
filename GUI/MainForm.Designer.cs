
namespace GUI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.ListOfProjectsButton = new System.Windows.Forms.Button();
            this.NewProjectButton = new System.Windows.Forms.Button();
            this.ProjectEditingButton = new System.Windows.Forms.Button();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.AutoSize = true;
            this.MainTitleLabel.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainTitleLabel.Location = new System.Drawing.Point(139, 9);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(464, 59);
            this.MainTitleLabel.TabIndex = 0;
            this.MainTitleLabel.Text = "Správa projektů firmy";
            // 
            // ListOfProjectsButton
            // 
            this.ListOfProjectsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListOfProjectsButton.Location = new System.Drawing.Point(51, 238);
            this.ListOfProjectsButton.Name = "ListOfProjectsButton";
            this.ListOfProjectsButton.Size = new System.Drawing.Size(147, 85);
            this.ListOfProjectsButton.TabIndex = 1;
            this.ListOfProjectsButton.Text = "Seznam projektů";
            this.ListOfProjectsButton.UseVisualStyleBackColor = false;
            this.ListOfProjectsButton.Click += new System.EventHandler(this.ListOfProjectsButton_Click);
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewProjectButton.Location = new System.Drawing.Point(236, 238);
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(147, 85);
            this.NewProjectButton.TabIndex = 2;
            this.NewProjectButton.Text = "Nový projekt";
            this.NewProjectButton.UseVisualStyleBackColor = false;
            this.NewProjectButton.Click += new System.EventHandler(this.NewProjectButton_Click);
            // 
            // ProjectEditingButton
            // 
            this.ProjectEditingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProjectEditingButton.Location = new System.Drawing.Point(424, 238);
            this.ProjectEditingButton.Name = "ProjectEditingButton";
            this.ProjectEditingButton.Size = new System.Drawing.Size(147, 85);
            this.ProjectEditingButton.TabIndex = 3;
            this.ProjectEditingButton.Text = "Editace projektu";
            this.ProjectEditingButton.UseVisualStyleBackColor = false;
            this.ProjectEditingButton.Click += new System.EventHandler(this.EditProjectButton_Click);
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteProjectButton.Location = new System.Drawing.Point(610, 238);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(147, 85);
            this.DeleteProjectButton.TabIndex = 4;
            this.DeleteProjectButton.Text = "Smazání projektu";
            this.DeleteProjectButton.UseVisualStyleBackColor = false;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteProjectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteProjectButton);
            this.Controls.Add(this.ProjectEditingButton);
            this.Controls.Add(this.NewProjectButton);
            this.Controls.Add(this.ListOfProjectsButton);
            this.Controls.Add(this.MainTitleLabel);
            this.Name = "MainForm";
            this.Text = "Správa projektů firmy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.Button ListOfProjectsButton;
        private System.Windows.Forms.Button NewProjectButton;
        private System.Windows.Forms.Button ProjectEditingButton;
        private System.Windows.Forms.Button DeleteProjectButton;
    }
}