﻿using System.Collections.Generic;

namespace Prototype
{
    public class SandwichMenu
    {
        private readonly Dictionary<string, SandwichPrototype> sandwiches;

        public SandwichMenu()
        {
            sandwiches = new Dictionary<string, SandwichPrototype>();
        }

        public SandwichPrototype this[string name]
        {
            get
            {
                return sandwiches[name];
            }
            set
            {
                sandwiches.Add(name, value);
            }
        }

    }
}
