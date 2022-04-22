using System;
using System.Windows.Forms;

namespace GUI {
    public partial class ThrowExceptionForm : Form {
        string ex = "";
        public ThrowExceptionForm(string ex) {
            InitializeComponent();
            this.ex = ex;
        }
        private void ThrowExceptionForm_Load(object sender, EventArgs e) {
            ThrowExceptionLabel.Text = "Zachycena výjimka typu: " + ex;
        }
    }
}
