using System;

namespace PersonInfo
{
    public class Robot : IIdentifiable
    {
        public Robot(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
