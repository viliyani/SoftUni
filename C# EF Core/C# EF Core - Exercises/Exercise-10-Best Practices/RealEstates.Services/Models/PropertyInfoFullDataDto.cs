﻿using RealEstates.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RealEstates.Services.Models
{
    [XmlType("Property")]
    public class PropertyInfoFullDataDto
    {
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("DistrictName")]
        public string DistrictName { get; set; }

        [XmlElement("Size")]
        public int Size { get; set; }

        [XmlElement("Price")]
        public int Price { get; set; }

        [XmlElement("PropertyType")]
        public string PropertyType { get; set; }

        [XmlElement("BuildingType")]
        public string BuildingType { get; set; }

    }
}
