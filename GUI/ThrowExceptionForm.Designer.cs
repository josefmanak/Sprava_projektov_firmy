
namespace GUI {
    partial class ThrowExceptionForm {
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
            this.ThrowExceptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThrowExceptionLabel
            // 
            this.ThrowExceptionLabel.Location = new System.Drawing.Point(92, 115);
            this.ThrowExceptionLabel.Name = "ThrowExceptionLabel";
            this.ThrowExceptionLabel.Size = new System.Drawing.Size(614, 161);
            this.ThrowExceptionLabel.TabIndex = 0;
            this.ThrowExceptionLabel.Text = "ThrowExceptionLabel";
            this.ThrowExceptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThrowExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThrowExceptionLabel);
            this.Name = "ThrowExceptionForm";
            this.Text = "Správa projektů firmy";
            this.Load += new System.EventHandler(this.ThrowExceptionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ThrowExceptionLabel;
    }
}