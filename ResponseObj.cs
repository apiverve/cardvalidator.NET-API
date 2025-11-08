using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Code data
    /// </summary>
    public class Code
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

    }
    /// <summary>
    /// Card data
    /// </summary>
    public class Card
    {
        [JsonProperty("niceType")]
        public string NiceType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("patterns")]
        public int[] Patterns { get; set; }

        [JsonProperty("gaps")]
        public int[] Gaps { get; set; }

        [JsonProperty("lengths")]
        public int[] Lengths { get; set; }

        [JsonProperty("code")]
        public Code Code { get; set; }

        [JsonProperty("matchStrength")]
        public int MatchStrength { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("card")]
        public Card Card { get; set; }

        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
