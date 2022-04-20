using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace GUI {
    public partial class Form1 : Form {
       
        public Form1() {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e) {
            try {
                XmlDocument doc = new XmlDocument();
                doc.Load("appconfig.xml");
                XmlElement de = doc.DocumentElement;
                string password = de.SelectSingleNode("password").InnerText;
                string s = tb.Text;
                if (s == password) {
                    MainForm mfm = new MainForm();
                    mfm.ShowDialog();
                    this.Close();
                }
                else {
                    lb.Text = "Zadáno špatné heslo";

                }
            }
            catch (IOException ex) {       
                Form6 frm6 = new Form6(ex.Message);
                frm6.ShowDialog();
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
    }
}
