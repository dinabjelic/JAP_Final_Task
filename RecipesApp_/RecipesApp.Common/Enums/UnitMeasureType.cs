using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecipesApp.Common.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UnitMeasureType
    {
        kg=1,
        gr=2,
        ml=3, 
        l=4
    }
}
