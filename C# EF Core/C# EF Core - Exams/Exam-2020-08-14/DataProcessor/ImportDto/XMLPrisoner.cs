using System.Xml.Serialization;

namespace SoftJail.DataProcessor.ImportDto
{
    [XmlType("Prisoner")]
    public class XMLPrisoner
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}
