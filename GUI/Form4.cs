using System;
using System.Windows.Forms;
using MyLibrary;
using System.IO;
using System.Xml;

namespace GUI {
    public partial class Form4 : Form {
        Methods m = new Methods();
        ProjectCollection c = new ProjectCollection();
        public Form4() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            try {
                c = m.Read();
                Project project = new Project();
                project.name = tb1.Text;
                project.abbreviation = tb2.Text;
                project.customer = tb3.Text;
                c.Projects.Add(project);
                m.Save(c);
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
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
        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
