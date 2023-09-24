namespace FSH.BlazorChartjs.Models.Common;

/// <summary>
///     Data for Bar
/// </summary>
public class Data<T> where T : class
{
    /// <summary>
    ///     Gets or sets the datasets.
    /// </summary>
    /// <value>
    ///     The datasets.
    /// </value>
    [JsonPropertyName("datasets")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<T> Datasets { get; set; } = new();

    /// <summary>
    ///     Gets or sets the labels.
    /// </summary>
    /// <value>
    ///     The labels.
    /// </value>
    [JsonPropertyName("labels")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> Labels { get; set; } = new();
}