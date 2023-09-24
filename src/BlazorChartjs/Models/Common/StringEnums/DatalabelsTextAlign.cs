namespace FSH.BlazorChartjs.Models.Common.StringEnums;

/// <summary>
///     Class DatalabelsAlign.
/// </summary>
public class DatalabelsTextAlign
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DatalabelsTextAlign" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private DatalabelsTextAlign(string value) => Value = value;

    /// <summary>
    ///     Center
    /// </summary>
    /// <value>
    ///     Center
    /// </value>
    public static DatalabelsTextAlign Center => new("center");

    /// <summary>
    ///     End
    /// </summary>
    /// <value>
    ///     End
    /// </value>
    public static DatalabelsTextAlign End => new("end");

    /// <summary>
    ///     Gets the left.
    /// </summary>
    /// <value>The left.</value>
    public static DatalabelsTextAlign Left => new("left");

    /// <summary>
    ///     Gets the right.
    /// </summary>
    /// <value>The right.</value>
    public static DatalabelsTextAlign Right => new("right");

    /// <summary>
    ///     Start
    /// </summary>
    /// <value>
    ///     Start
    /// </value>
    public static DatalabelsTextAlign Start => new("start");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>
    ///     The value.
    /// </value>
    public string Value { get; private set; }
}