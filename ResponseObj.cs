using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class code
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("size")]
    public int size { get; set; }

}

public class card
{
    [JsonProperty("niceType")]
    public string niceType { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("patterns")]
    public int[] patterns { get; set; }

    [JsonProperty("gaps")]
    public int[] gaps { get; set; }

    [JsonProperty("lengths")]
    public int[] lengths { get; set; }

    [JsonProperty("code")]
    public code code { get; set; }

    [JsonProperty("matchStrength")]
    public int matchStrength { get; set; }

}

public class data
{
    [JsonProperty("card")]
    public card card { get; set; }

    [JsonProperty("cardNumber")]
    public string cardNumber { get; set; }

    [JsonProperty("isValid")]
    public bool isValid { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
