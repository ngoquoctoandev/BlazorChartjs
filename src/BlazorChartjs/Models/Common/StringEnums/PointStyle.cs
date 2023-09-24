namespace FSH.BlazorChartjs.Models.Common.StringEnums;

/// <summary>
///     Point Style
/// </summary>
public class PointStyle
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PointStyle" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private PointStyle(string value) => Value = value;

    /// <summary>
    ///     The circle.
    /// </summary>
    /// <value>
    ///     The circle.
    /// </value>
    public static PointStyle Circle => new("circle");

    /// <summary>
    ///     The cross.
    /// </summary>
    /// <value>
    ///     The cross.
    /// </value>
    public static PointStyle Cross => new("cross");

    /// <summary>
    ///     The cross rot.
    /// </summary>
    /// <value>
    ///     The cross rot.
    /// </value>
    public static PointStyle CrossRot => new("crossRot");

    /// <summary>
    ///     The dash.
    /// </summary>
    /// <value>
    ///     The dash.
    /// </value>
    public static PointStyle Dash => new("dash");

    /// <summary>
    ///     The line.
    /// </summary>
    /// <value>
    ///     The line.
    /// </value>
    public static PointStyle Line => new("line");

    /// <summary>
    ///     The rectangle.
    /// </summary>
    /// <value>
    ///     The rectangle.
    /// </value>
    public static PointStyle Rectangle => new("rect");

    /// <summary>
    ///     The rectangle rot.
    /// </summary>
    /// <value>
    ///     The rectangle rot.
    /// </value>
    public static PointStyle RectangleRot => new("rectRot");

    /// <summary>
    ///     The rectangle rounded.
    /// </summary>
    /// <value>
    ///     The rectangle rounded.
    /// </value>
    public static PointStyle RectangleRounded => new("rectRounded");

    /// <summary>
    ///     The star.
    /// </summary>
    /// <value>
    ///     The star.
    /// </value>
    public static PointStyle Star => new("star");

    /// <summary>
    ///     The triangle.
    /// </summary>
    /// <value>
    ///     The triangle.
    /// </value>
    public static PointStyle Triangle => new("triangle");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>
    ///     The value.
    /// </value>
    public string Value { get; private set; }
}