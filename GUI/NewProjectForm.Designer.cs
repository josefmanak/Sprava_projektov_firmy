
namespace GUI {
    partial class NewProjectForm {
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
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectAbbreviationTextBox = new System.Windows.Forms.TextBox();
            this.ProjectCustomerTextBox = new System.Windows.Forms.TextBox();
            this.SaveRecordButton = new System.Windows.Forms.Button();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.ProjectAbbreviationLabel = new System.Windows.Forms.Label();
            this.ProjectCustomerLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.AutoSize = true;
            this.MainTitleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainTitleLabel.Location = new System.Drawing.Point(278, 9);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(222, 45);
            this.MainTitleLabel.TabIndex = 0;
            this.MainTitleLabel.Text = "Nový projekt";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(194, 111);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(385, 27);
            this.ProjectNameTextBox.TabIndex = 1;
            // 
            // ProjectAbbreviationTextBox
            // 
            this.ProjectAbbreviationTextBox.Location = new System.Drawing.Point(194, 179);
            this.ProjectAbbreviationTextBox.Name = "ProjectAbbreviationTextBox";
            this.ProjectAbbreviationTextBox.Size = new System.Drawing.Size(385, 27);
            this.ProjectAbbreviationTextBox.TabIndex = 2;
            // 
            // ProjectCustomerTextBox
            // 
            this.ProjectCustomerTextBox.Location = new System.Drawing.Point(194, 241);
            this.ProjectCustomerTextBox.Name = "ProjectCustomerTextBox";
            this.ProjectCustomerTextBox.Size = new System.Drawing.Size(382, 27);
            this.ProjectCustomerTextBox.TabIndex = 3;
            // 
            // SaveRecordButton
            // 
            this.SaveRecordButton.Location = new System.Drawing.Point(194, 303);
            this.SaveRecordButton.Name = "SaveRecordButton";
            this.SaveRecordButton.Size = new System.Drawing.Size(176, 76);
            this.SaveRecordButton.TabIndex = 4;
            this.SaveRecordButton.Text = "Uložit záznam";
            this.SaveRecordButton.UseVisualStyleBackColor = true;
            this.SaveRecordButton.Click += new System.EventHandler(this.SaveRecordButton_Click);
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(330, 88);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(109, 20);
            this.ProjectNameLabel.TabIndex = 5;
            this.ProjectNameLabel.Text = "Název projektu";
            // 
            // ProjectAbbreviationLabel
            // 
            this.ProjectAbbreviationLabel.AutoSize = true;
            this.ProjectAbbreviationLabel.Location = new System.Drawing.Point(353, 156);
            this.ProjectAbbreviationLabel.Name = "ProjectAbbreviationLabel";
            this.ProjectAbbreviationLabel.Size = new System.Drawing.Size(58, 20);
            this.ProjectAbbreviationLabel.TabIndex = 6;
            this.ProjectAbbreviationLabel.Text = "Zkratka";
            // 
            // ProjectCustomerLabel
            // 
            this.ProjectCustomerLabel.AutoSize = true;
            this.ProjectCustomerLabel.Location = new System.Drawing.Point(353, 218);
            this.ProjectCustomerLabel.Name = "ProjectCustomerLabel";
            this.ProjectCustomerLabel.Size = new System.Drawing.Size(67, 20);
            this.ProjectCustomerLabel.TabIndex = 7;
            this.ProjectCustomerLabel.Text = "Zákazník";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(403, 303);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(176, 76);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Zavřít";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ProjectCustomerLabel);
            this.Controls.Add(this.ProjectAbbreviationLabel);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.SaveRecordButton);
            this.Controls.Add(this.ProjectCustomerTextBox);
            this.Controls.Add(this.ProjectAbbreviationTextBox);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.MainTitleLabel);
            this.Name = "NewProjectForm";
            this.Text = "Správa projektů firmy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.TextBox ProjectAbbreviationTextBox;
        private System.Windows.Forms.TextBox ProjectCustomerTextBox;
        private System.Windows.Forms.Button SaveRecordButton;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label ProjectAbbreviationLabel;
        private System.Windows.Forms.Label ProjectCustomerLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}