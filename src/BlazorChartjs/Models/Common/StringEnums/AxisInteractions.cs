namespace FSH.BlazorChartjs.Models.Common.StringEnums;

/// <summary>
///     Class AxisInteractions.
/// </summary>
public class AxisInteractions
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CrossAlign" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private AxisInteractions(string value) => Value = value;

    /// <summary>
    ///     Gets the r.
    /// </summary>
    /// <value>The r.</value>
    public static AxisInteractions R => new("r");

    /// <summary>
    ///     X
    /// </summary>
    /// <value>
    ///     X
    /// </value>
    public static AxisInteractions X => new("x");

    /// <summary>
    ///     Gets the xy.
    /// </summary>
    /// <value>The xy.</value>
    public static AxisInteractions XY => new("xy");

    /// <summary>
    ///     Gets the y.
    /// </summary>
    /// <value>The y.</value>
    public static AxisInteractions Y => new("y");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>The value.</value>
    public string Value { get; private set; }
}