namespace FSH.BlazorChartjs.Models.Common.StringEnums;

/// <summary>
///     Class InteractionMode.
/// </summary>
public class InteractionMode
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="InteractionMode" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private InteractionMode(string value) => Value = value;

    /// <summary>
    ///     Gets the dataset.
    /// </summary>
    /// <value>The dataset.</value>
    public static InteractionMode Dataset => new("dataset");

    /// <summary>
    ///     Gets the index.
    /// </summary>
    /// <value>The index.</value>
    public static InteractionMode Index => new("index");

    /// <summary>
    ///     Gets the nearest.
    /// </summary>
    /// <value>The nearest.</value>
    public static InteractionMode Nearest => new("nearest");

    /// <summary>
    ///     Gets the point.
    /// </summary>
    /// <value>The point.</value>
    public static InteractionMode Point => new("point");

    /// <summary>
    ///     Gets the x.
    /// </summary>
    /// <value>The x.</value>
    public static InteractionMode X => new("x");

    /// <summary>
    ///     Gets the y.
    /// </summary>
    /// <value>The y.</value>
    public static InteractionMode Y => new("y");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>The value.</value>
    public string Value { get; private set; }
}