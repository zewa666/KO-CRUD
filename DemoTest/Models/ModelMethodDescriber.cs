using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoTest.Models
{
    public enum ModelMethodDisplayMode
    {
        None,
        DisplayAsSubmit
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class ModelMethodDescriber : Attribute
    {
        public bool koComputed { get; set; }
        public string Description { get; set; }
        public ModelMethodDisplayMode DisplayMode { get; set; }
    }
}