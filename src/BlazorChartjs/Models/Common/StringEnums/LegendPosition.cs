namespace FSH.BlazorChartjs.Models.Common.StringEnums;

public class LegendPosition
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="LegendPosition" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private LegendPosition(string value) => Value = value;

    /// <summary>
    ///     Bar
    /// </summary>
    /// <value>
    ///     Bar
    /// </value>
    public static LegendPosition Bar => new("bar");

    /// <summary>
    ///     Bottom
    /// </summary>
    /// <value>
    ///     Bottom
    /// </value>
    public static LegendPosition Bottom => new("bottom");

    /// <summary>
    ///     Chart area
    /// </summary>
    /// <value>
    ///     Chart area
    /// </value>
    public static LegendPosition ChartArea => new("chartArea");

    /// <summary>
    ///     Left
    /// </summary>
    /// <value>
    ///     Left
    /// </value>
    public static LegendPosition Left => new("left");

    /// <summary>
    ///     Right.
    /// </summary>
    /// <value>
    ///     Right
    /// </value>
    public static LegendPosition Right => new("right");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>
    ///     The value.
    /// </value>
    public string Value { get; private set; }
}