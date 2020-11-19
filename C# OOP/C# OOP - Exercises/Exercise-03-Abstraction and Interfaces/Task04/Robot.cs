using System;

namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Id { get; private set; }
        public string Model { get; private set; }

        public bool ValidateId(string lastDigitsValid)
        {
            return Id.EndsWith(lastDigitsValid);
        }
    }
}
