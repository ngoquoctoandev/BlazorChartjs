﻿namespace FSH.BlazorChartjs.Models.Polar;

public class PolarDataset : Dataset
{
    /// <summary>
    ///     Gets or sets the color of the background.
    /// </summary>
    /// <value>
    ///     The color of the background.
    /// </value>
    [JsonPropertyName("backgroundColor")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> BackgroundColor { get; set; } = new();

    /// <summary>
    ///     Gets or sets the width of the border.
    /// </summary>
    /// <value>
    ///     The width of the border.
    /// </value>
    [JsonPropertyName("borderWidth")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? BorderWidth { get; set; }
}