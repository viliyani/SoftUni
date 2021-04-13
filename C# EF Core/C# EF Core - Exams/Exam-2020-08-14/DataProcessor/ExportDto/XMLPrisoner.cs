using System.Xml.Serialization;

namespace SoftJail.DataProcessor.ExportDto
{
    [XmlType("Prisoner")]
    public class XMLPrisoner
    {
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("IncarcerationDate")]
        public string IncarcerationDate { get; set; }

        [XmlArray("EncryptedMessages")]
        public XMLEncryptedMessage[] EncryptedMessages { get; set; }
    }

    [XmlType("Message")]
    public class XMLEncryptedMessage
    {
        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
