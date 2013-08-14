using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
    public class CRUDPresentationAttribute : Attribute
    {
        private string _KOBinding = "BindToSelf";
        public string KOBinding { get { return _KOBinding; } set { this._KOBinding = value; } }


        public string Label { get; set; }
    }
}
