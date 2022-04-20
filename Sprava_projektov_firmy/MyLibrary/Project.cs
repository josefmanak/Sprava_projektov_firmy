using System.Collections.Generic;
using System.Xml.Serialization;



namespace MyLibrary {

    public class Project {
       
        public string name { get; set; } 
        public string abbreviation { get; set; } 
        public string customer { get; set; }

    }

    [XmlRootAttribute("projects")]
    public class ProjectCollection {

        [XmlElement("project")]
        public List<Project> Projects { get; set; }
        [XmlAttribute("id")]
        public string id { get; set; }

    }

}
