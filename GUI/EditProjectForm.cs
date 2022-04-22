using System;
using System.Windows.Forms;
using MyLibrary;
using System.IO;
using System.Xml;

namespace GUI {
    public partial class EditProjectForm : Form {
        Methods m = new Methods();
        ProjectCollection c = new ProjectCollection();
        private Panel buttonPanel = new Panel();
        public EditProjectForm() {
            InitializeComponent();
        }
        private void EditProjectForm_Load(object sender, EventArgs e) {
            try {
                c = m.Read();
                this.Controls.Add(this.buttonPanel);
                ProjectDataGridView.ColumnCount = 3;
                ProjectDataGridView.Columns[0].Name = "Název";
                ProjectDataGridView.Columns[1].Name = "Zkratka";
                ProjectDataGridView.Columns[2].Name = "Zákazník";
                for (int i = 0; i < c.Projects.Count; i++) {
                    ProjectDataGridView.Rows.Add(c.Projects[i].name, c.Projects[i].abbreviation, c.Projects[i].customer);
                }
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
        private void ProjectDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            int counter;
            for (counter = 0; counter < (ProjectDataGridView.Rows.Count); counter++)  { 
                c.Projects[counter].name = ProjectDataGridView.Rows[counter].Cells["Název"].Value.ToString();
                c.Projects[counter].abbreviation = ProjectDataGridView.Rows[counter].Cells["Zkratka"].Value.ToString();
                c.Projects[counter].customer = ProjectDataGridView.Rows[counter].Cells["Zákazník"].Value.ToString();
            }
            try {
                m.Save(c);
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
    }
}
