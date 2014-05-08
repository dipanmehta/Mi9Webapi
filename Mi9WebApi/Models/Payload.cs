using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace Mi9Project.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Payload
    {
        [JsonProperty(PropertyName="payload")]
        public List<Show> payload { get; set; }

        [JsonProperty(PropertyName="skip")]
        public int skip { get; set; }

        [JsonProperty(PropertyName="take")]
        public int take { get; set; }

        [JsonProperty(PropertyName="totalRecords")]
        public int totalRecords { get; set; }

    }
}