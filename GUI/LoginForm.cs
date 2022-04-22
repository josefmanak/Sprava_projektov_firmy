using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace GUI {
    public partial class LoginForm : Form {
       
        public LoginForm() {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e) {
            try {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load("appconfig.xml");
                XmlElement xe = xdoc.DocumentElement;
                string password = xe.SelectSingleNode("password").InnerText;
                string s = PasswordTextBox.Text;
                if (s == password) {
                    MainForm mf = new MainForm();
                    mf.ShowDialog();
                    this.Close();
                }
                else {
                    PasswordLabel.Text = "Zadáno špatné heslo";

                }
            }
            catch (IOException ex) {       
                ThrowExceptionForm tef = new ThrowExceptionForm(ex.Message);
                tef.ShowDialog();
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
    }
}
