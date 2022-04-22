using System;
using System.Windows.Forms;
using MyLibrary;
using System.IO;
using System.Xml;

namespace GUI {
    public partial class NewProjectForm : Form {
        Methods m = new Methods();
        ProjectCollection c = new ProjectCollection();
        public NewProjectForm() {
            InitializeComponent();
        }
        private void SaveRecordButton_Click(object sender, EventArgs e) {
            try {
                c = m.Read();
                Project project = new Project();
                project.name = ProjectNameTextBox.Text;
                project.abbreviation = ProjectAbbreviationTextBox.Text;
                project.customer = ProjectCustomerTextBox.Text;
                c.Projects.Add(project);
                m.Save(c);
                ProjectNameTextBox.Text = "";
                ProjectAbbreviationTextBox.Text = "";
                ProjectCustomerTextBox.Text = "";
            }
            catch (ArgumentException ex) {
                ThrowExceptionForm tef = new ThrowExceptionForm(ex.Message);
                tef.ShowDialog();
                this.Close();
            }
            catch (IOException ex) {
                ThrowExceptionForm tef = new ThrowExceptionForm(ex.Message);
                tef.ShowDialog();
                this.Close();
            }
            catch (XmlException ex) {
                ThrowExceptionForm tef = new ThrowExceptionForm(ex.Message);
                tef.ShowDialog();
                this.Close();
            }
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
