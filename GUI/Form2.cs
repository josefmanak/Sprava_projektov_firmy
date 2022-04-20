using System;
using System.Windows.Forms;
using System.Xml;
using MyLibrary;
using System.IO;

namespace GUI {
    public partial class Form2 : Form {
        Methods m = new Methods();
        private Panel buttonPanel = new Panel();
        ProjectCollection c = new ProjectCollection();
        public Form2() {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e) {
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
                Form6 frm6 = new Form6(ex.Message);
                frm6.ShowDialog();
                this.Close();
            }
            catch (ArgumentException ex) {
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
        private void btn1_Click(object sender, EventArgs e) { 
            this.Close();
        }
    }
}
