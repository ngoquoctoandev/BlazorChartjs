namespace FSH.BlazorChartjs.Models.Common.StringEnums;

/// <summary>
///     Point Style
/// </summary>
public class CrossAlign
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CrossAlign" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private CrossAlign(string value) => Value = value;

    /// <summary>
    ///     Near
    /// </summary>
    /// <value>
    ///     Near
    /// </value>
    public static CrossAlign Near => new("near");

    /// <summary>
    ///     Center
    /// </summary>
    /// <value>
    ///     Center
    /// </value>
    public static CrossAlign Center => new("center");

    /// <summary>
    ///     Far
    /// </summary>
    /// <value>
    ///     Far
    /// </value>
    public static CrossAlign Far => new("far");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>
    ///     The value.
    /// </value>
    public string Value { get; private set; }
}