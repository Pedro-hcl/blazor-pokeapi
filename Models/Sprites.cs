using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models
{
    public class Sprites
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }
}