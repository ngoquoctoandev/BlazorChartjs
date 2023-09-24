namespace FSH.BlazorChartjs.Models.Line;

/// <summary>
///     Chart config for Bars
/// </summary>
public class LineChartConfig : IChartConfig
{
    /// <summary>
    ///     Gets or sets the data.
    /// </summary>
    /// <value>
    ///     The data.
    /// </value>
    [JsonPropertyName("data")]
    public LineData Data { get; set; } = new();

    /// <summary>
    ///     Gets or sets the options.
    /// </summary>
    /// <value>
    ///     The options.
    /// </value>
    [JsonPropertyName("options")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Options Options { get; set; }

    /// <summary>
    ///     Gets the canvas identifier.
    /// </summary>
    /// <value>
    ///     The canvas identifier.
    /// </value>
    [JsonIgnore]
    public string CanvasId { get; } = Guid.NewGuid().ToString();

    /// <summary>
    ///     Gets the options.
    /// </summary>
    /// <value>
    ///     The options.
    /// </value>
    IOptions IChartConfig.Options => Options;

    /// <summary>
    ///     Gets or sets the type.
    /// </summary>
    /// <value>
    ///     The type.
    /// </value>
    [JsonPropertyName("type")]
    public string Type { get; set; } = ChartType.Line;
}