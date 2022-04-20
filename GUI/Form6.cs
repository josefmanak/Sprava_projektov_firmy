using System;
using System.Windows.Forms;

namespace GUI {
    public partial class Form6 : Form {
        string ex = "";
        public Form6(string ex) {
            InitializeComponent();
            this.ex = ex;
        }
        private void Form6_Load(object sender, EventArgs e) {
            lb5.Text = "Zachycena výjimka typu: " + ex;
        }
    }
}
