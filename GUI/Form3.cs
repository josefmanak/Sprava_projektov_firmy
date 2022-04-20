using System;
using System.Windows.Forms;
using MyLibrary;
using System.IO;
using System.Xml;

namespace GUI {
    public partial class Form3 : Form {
        Methods m = new Methods();
        ProjectCollection c = new ProjectCollection();
        private Panel buttonPanel = new Panel();
        public Form3() {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e) {
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
        private void btn6_Click(object sender, EventArgs e) {
            try {
                if (this.ProjectDataGridView.SelectedRows.Count > 0 &&
                   this.ProjectDataGridView.SelectedRows[0].Index !=
                   this.ProjectDataGridView.Rows.Count) {
                    int k = this.ProjectDataGridView.SelectedRows[0].Index;
                    this.ProjectDataGridView.Rows.RemoveAt(k);
                    m.Delete(c, k);
                }
            }
            catch (ArgumentException ex) {
                Form6 frm6 = new Form6(ex.Message);
                frm6.ShowDialog();
                this.Close();
            }
        }
        private void btn7_Click(object sender, EventArgs e) {
            try {
                m.Save(c);
                this.Close();
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
