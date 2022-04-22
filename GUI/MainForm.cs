using System;
using System.Windows.Forms;

namespace GUI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        private void DeleteProjectButton_Click(object sender, EventArgs e) {
            DeleteProjectForm dpf = new DeleteProjectForm();
            dpf.ShowDialog();
        }
        private void ListOfProjectsButton_Click(object sender, EventArgs e) {
            ListOfProjectsForm lopf = new ListOfProjectsForm();
            lopf.ShowDialog();
        }
        private void NewProjectButton_Click(object sender, EventArgs e) {
            NewProjectForm npf = new NewProjectForm();
            npf.ShowDialog();
        }
        private void EditProjectButton_Click(object sender, EventArgs e) {
            EditProjectForm epf = new EditProjectForm();
            epf.ShowDialog();
        }
    }
}
