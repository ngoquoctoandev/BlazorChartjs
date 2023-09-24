namespace FSH.BlazorChartjs.Models.Common.StringEnums;

public class Position
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Position" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private Position(string value) => Value = value;

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>
    ///     The value.
    /// </value>
    public string Value { get; private set; }

    /// <summary>
    ///     Top.
    /// </summary>
    /// <value>
    ///     Top.
    /// </value>
    public static Position Top => new("top");

    /// <summary>
    ///     Left.
    /// </summary>
    /// <value>
    ///     Left.
    /// </value>
    public static Position Left => new("left");

    /// <summary>
    ///     Bottom.
    /// </summary>
    /// <value>
    ///     Bottom.
    /// </value>
    public static Position Bottom => new("bottom");

    /// <summary>
    ///     Right.
    /// </summary>
    /// <value>
    ///     Right.
    /// </value>
    public static Position Right => new("right");
}