using System;
using System.Windows.Forms;
using MyLibrary;
using System.IO;
using System.Xml;

namespace GUI {
    public partial class Form5 : Form {
        Methods m = new Methods();
        ProjectCollection c = new ProjectCollection();
        private Panel buttonPanel = new Panel();
        public Form5() {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e) {
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
                Form6 frm6 = new Form6(ex.Message);
                frm6.ShowDialog();
                this.Close();
            }
            catch (IOException ex) {
                Form6 frm6 = new Form6(ex.Message);
                frm6.ShowDialog();
                this.Close();
            }
            catch (XmlException ex) {
                Form6 frm6 = new Form6(ex.Message);
                frm6.ShowDialog();
                this.Close();
            }
        }
        private void btn5_Click(object sender, EventArgs e) {
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
                Form6 frm6 = new Form6(ex.Message);
                frm6.ShowDialog();
                this.Close();
            }
            catch (IOException ex) {
                Form6 frm6 = new Form6(ex.Message);
                frm6.ShowDialog();
                this.Close();
            }
            catch (XmlException ex) {
                Form6 frm6 = new Form6(ex.Message);
                frm6.ShowDialog();
                this.Close();
            }
        }
    }
}
