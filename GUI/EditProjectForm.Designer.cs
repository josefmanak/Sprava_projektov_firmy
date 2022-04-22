
namespace GUI {
    partial class EditProjectForm {
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.ProjectDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.AutoSize = true;
            this.MainTitleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainTitleLabel.Location = new System.Drawing.Point(249, 9);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(272, 45);
            this.MainTitleLabel.TabIndex = 0;
            this.MainTitleLabel.Text = "Editace projektu";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(272, 367);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(249, 71);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Zavřít";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProjectDataGridView
            // 
            this.ProjectDataGridView.AllowUserToAddRows = false;
            this.ProjectDataGridView.AllowUserToDeleteRows = false;
            this.ProjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProjectDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDataGridView.Location = new System.Drawing.Point(2, 57);
            this.ProjectDataGridView.Name = "ProjectDataGridView";
            this.ProjectDataGridView.RowHeadersWidth = 51;
            this.ProjectDataGridView.RowTemplate.Height = 29;
            this.ProjectDataGridView.Size = new System.Drawing.Size(796, 290);
            this.ProjectDataGridView.TabIndex = 7;
            this.ProjectDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectDataGridView_CellValueChanged);
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProjectDataGridView);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MainTitleLabel);
            this.Name = "EditProjectForm";
            this.Text = "Správa projektů firmy";
            this.Load += new System.EventHandler(this.EditProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView ProjectDataGridView;
    }
}