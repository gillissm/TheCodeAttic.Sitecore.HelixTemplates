using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCodeAttic.Layer.ModuleName
{
    public static class Constants
    {
        public static class ModuleName
        {

            public const string TemplateIdString = "templateID";
            public static readonly Guid TemplateId = new Guid(TemplateIdString);
            public static readonly ID SitecoreTemplateID = new ID(TemplateIdString);


            public const string nameFieldIdString = "FieldID";
            public static readonly ID nameFieldID = new ID(nameFieldIdString);
            public const string nameFieldName = "SitecoreFldName";

        }
    }
}
