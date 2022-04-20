using System;
using System.Windows.Forms;

namespace GUI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e) {
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
        }
        private void btn2_Click(object sender, EventArgs e) {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }
        private void btn3_Click(object sender, EventArgs e) {
            Form4 fm4 = new Form4();
            fm4.ShowDialog();
        }
        private void btn4_Click(object sender, EventArgs e) {
            Form5 fm5 = new Form5();
            fm5.ShowDialog();
        }
    }
}
