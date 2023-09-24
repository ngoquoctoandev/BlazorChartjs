﻿namespace FSH.BlazorChartjs.Models.Common.Animations;

/// <summary>
///     Tension
/// </summary>
public class Tension : Animation
{
    /// <summary>
    ///     Gets or sets from.
    /// </summary>
    /// <value>
    ///     From.
    /// </value>
    [JsonPropertyName("from")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? From { get; set; }

    /// <summary>
    ///     Gets or sets to.
    /// </summary>
    /// <value>
    ///     To.
    /// </value>
    [JsonPropertyName("to")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? To { get; set; }
}