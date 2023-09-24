namespace FSH.BlazorChartjs.Models.Common.StringEnums;

/// <summary>
///     Class DatalabelsAlign.
/// </summary>
public class DatalabelsAlign
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DatalabelsAlign" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private DatalabelsAlign(string value) => Value = value;

    /// <summary>
    ///     Gets the bottom.
    /// </summary>
    /// <value>The bottom.</value>
    public static DatalabelsAlign Bottom => new("bottom");

    /// <summary>
    ///     Center
    /// </summary>
    /// <value>
    ///     Center
    /// </value>
    public static DatalabelsAlign Center => new("center");

    /// <summary>
    ///     End
    /// </summary>
    /// <value>
    ///     End
    /// </value>
    public static DatalabelsAlign End => new("end");

    /// <summary>
    ///     Gets the left.
    /// </summary>
    /// <value>The left.</value>
    public static DatalabelsAlign Left => new("left");

    /// <summary>
    ///     Gets the right.
    /// </summary>
    /// <value>The right.</value>
    public static DatalabelsAlign Right => new("right");

    /// <summary>
    ///     Start
    /// </summary>
    /// <value>
    ///     Start
    /// </value>
    public static DatalabelsAlign Start => new("start");

    /// <summary>
    ///     Gets the top.
    /// </summary>
    /// <value>The top.</value>
    public static DatalabelsAlign Top => new("top");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>
    ///     The value.
    /// </value>
    public string Value { get; private set; }
}