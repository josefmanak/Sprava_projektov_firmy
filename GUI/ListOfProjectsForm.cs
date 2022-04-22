using System;
using System.Windows.Forms;
using System.Xml;
using MyLibrary;
using System.IO;

namespace GUI {
    public partial class ListOfProjectsForm : Form {
        Methods m = new Methods();
        private Panel buttonPanel = new Panel();
        ProjectCollection c = new ProjectCollection();
        public ListOfProjectsForm() {
            InitializeComponent();
        }
        private void ListOfProjectsForm_Load(object sender, EventArgs e) {
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
            catch (IOException ex) {
                ThrowExceptionForm tef = new ThrowExceptionForm(ex.Message);
                tef.ShowDialog();
                this.Close();
            }
            catch (ArgumentException ex) {
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
