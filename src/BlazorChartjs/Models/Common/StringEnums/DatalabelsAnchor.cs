namespace FSH.BlazorChartjs.Models.Common.StringEnums;

/// <summary>
///     Class DatalabelsAnchor.
/// </summary>
public class DatalabelsAnchor
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DatalabelsAnchor" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private DatalabelsAnchor(string value) => Value = value;

    /// <summary>
    ///     Start
    /// </summary>
    /// <value>
    ///     Start
    /// </value>
    public static DatalabelsAnchor Start => new("start");

    /// <summary>
    ///     Center
    /// </summary>
    /// <value>
    ///     Center
    /// </value>
    public static DatalabelsAnchor Center => new("center");

    /// <summary>
    ///     End
    /// </summary>
    /// <value>
    ///     End
    /// </value>
    public static DatalabelsAnchor End => new("end");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>
    ///     The value.
    /// </value>
    public string Value { get; private set; }
}