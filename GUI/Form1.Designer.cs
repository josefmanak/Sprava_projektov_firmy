
namespace GUI {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tb = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(257, 187);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(266, 27);
            this.tb.TabIndex = 0;
            this.tb.UseSystemPasswordChar = true;
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb.Location = new System.Drawing.Point(308, 151);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(164, 23);
            this.lb.TabIndex = 1;
            this.lb.Text = "Vložte heslo";
            this.lb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(293, 282);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(188, 59);
            this.btn.TabIndex = 2;
            this.btn.Text = "Vstup";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btn;
    }
}

