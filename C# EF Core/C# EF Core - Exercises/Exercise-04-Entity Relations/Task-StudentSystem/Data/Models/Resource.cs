﻿using StudentSystem.Data.Models.Enumerations;

namespace StudentSystem.Data.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
