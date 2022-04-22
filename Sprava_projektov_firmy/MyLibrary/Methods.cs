using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace MyLibrary {
    public class Methods {
            public string Path() {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(@"appconfig.xml");
                XmlElement xe = xdoc.DocumentElement;
                string path = xe.SelectSingleNode("path").InnerText;
                return path;      
            }
            public void Delete(ProjectCollection c, int k) {
                c.Projects.RemoveAt(k);
            }
            public ProjectCollection Read() {
                using (TextReader reader = new StreamReader(Path())) {
                    XmlSerializer serializer = new XmlSerializer(typeof(ProjectCollection));
                    return (ProjectCollection)serializer.Deserialize(reader);
                }
            }
            public void Save(ProjectCollection c) {
                var serializer = new XmlSerializer(c.GetType());
                using (var stream = new FileStream(Path(), FileMode.Create))
                    serializer.Serialize(stream, c);
            }
    }    
}
