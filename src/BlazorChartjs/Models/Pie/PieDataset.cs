﻿namespace FSH.BlazorChartjs.Models.Pie;

/// <summary>
///     Pie Dataset
/// </summary>
/// <seealso cref="Dataset" />
public class PieDataset : Dataset
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

    /// <summary>
    ///     Gets or sets the arc offset when hovered (in pixels)
    /// </summary>
    /// <value>
    ///     The hover offset.
    /// </value>
    [JsonPropertyName("hoverOffset")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? HoverOffset { get; set; }
}