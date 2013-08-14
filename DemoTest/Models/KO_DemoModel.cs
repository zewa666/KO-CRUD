using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoTest.Models
{
    public class KO_DemoModel : KO_BaseModel
    {
        [CRUDPresentation(Label="Thats the Prename")]
        public string Prename { get; set; }
        [CRUDPresentation()]
        public string Surname { get; set; }
        public string Birthday { get; set; }

        [ModelMethodDescriber(koComputed = false, Description = "Handling submit event", DisplayMode=ModelMethodDisplayMode.DisplayAsSubmit)]
        [CRUDPresentation(Label = "Save now")]
        public void Submit()
        {
        }
    }
}