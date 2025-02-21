using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class ResponseObj
{
    [JsonProperty("api")]
    public string api { get; set; }

    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public string error { get; set; }

    [JsonProperty("data")]
    public object data { get; set; }

}

}
