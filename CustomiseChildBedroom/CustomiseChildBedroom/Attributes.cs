﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomiseChildBedroom
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class CommandName : Attribute
    {
        public string Name;
        public CommandName(string name)
        {
            Name = name;
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    internal class CommandDescription : Attribute
    {
        public string Description;
        public CommandDescription(string line1, params string[] description)
        {
            string temp = string.Join(Environment.NewLine, description);
            Description = string.Join(Environment.NewLine, new[] { line1, temp });
            //Description = string.Join(Environment.NewLine, Description, description);
        }
    }
}
