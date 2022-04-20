using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace MyLibrary {
    public class Methods {
            public string Path() {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"appconfig.xml");
                XmlElement de = doc.DocumentElement;
                string path = de.SelectSingleNode("path").InnerText;
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
