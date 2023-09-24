namespace FSH.BlazorChartjs.Models.Common.Zoom;

/// <summary>
///     Pinch
/// </summary>
public class Pinch
{
    /// <summary>
    ///     Gets or sets enable zooming via pinch
    /// </summary>
    /// <value>
    ///     The enabled.
    /// </value>
    [JsonPropertyName("enabled")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Enabled { get; set; }
}