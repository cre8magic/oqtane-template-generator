﻿using System.Text.Json.Serialization;

// ReSharper disable CheckNamespace
namespace ToSic.Cre8magic.Oqtane.Transformer.Models;

/// <summary>
/// Represents a rule for source, rename, or process configuration.
/// </summary>
public class TransformerConfigRule
{
    [JsonPropertyName("include")]
    public List<string> Include { get; set; } = new();

    [JsonPropertyName("exclude")]
    public List<string> Exclude { get; set; } = new();

    [JsonPropertyName("replace")]
    public Dictionary<string, string>? Replace { get; set; }
}
