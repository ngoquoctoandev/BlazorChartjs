namespace FSH.BlazorChartjs.Models.Common;

/// <summary>
///     Elements
/// </summary>
public sealed class Elements
{
    /// <summary>
    ///     Gets or sets the line.
    /// </summary>
    /// <value>
    ///     The line.
    /// </value>
    [JsonPropertyName("line")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Line? Line { get; set; }
}