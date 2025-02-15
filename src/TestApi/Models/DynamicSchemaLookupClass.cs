﻿using Plumsail.Swashbuckle.MicrosoftPowerAutomate.Attributes;
using System.Collections.Generic;

namespace TestApi.Models
{
    [DynamicSchemaLookup("DynamicSchemaOpId", "schema", "param1={test}&param2=test")]
    [DynamicPropertiesLookup("DynamicSchemaOpId", "schema", "param1={object/test}&param2=test")]
    public class DynamicSchemaLookupClass
    {
        [DynamicSchemaLookup("DynamicSchemaOpId", "schema", "param1={test}&param2=test")]
        public IDictionary<string, object> LookupProperty { get; set; }
    }
}