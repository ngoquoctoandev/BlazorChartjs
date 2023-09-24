namespace FSH.BlazorChartjs.Models.Common.StringEnums;

/// <summary>
///     Class Align.
/// </summary>
public class Align
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Align" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private Align(string value) => Value = value;

    /// <summary>
    ///     Start
    /// </summary>
    /// <value>
    ///     Start
    /// </value>
    public static Align Start => new("start");

    /// <summary>
    ///     Center
    /// </summary>
    /// <value>
    ///     Center
    /// </value>
    public static Align Center => new("center");

    /// <summary>
    ///     End
    /// </summary>
    /// <value>
    ///     End
    /// </value>
    public static Align End => new("end");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>
    ///     The value.
    /// </value>
    public string Value { get; private set; }
}