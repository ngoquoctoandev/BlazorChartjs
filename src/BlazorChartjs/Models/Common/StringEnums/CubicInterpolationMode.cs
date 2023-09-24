namespace FSH.BlazorChartjs.Models.Common.StringEnums;

/// <summary>
///     Class CubicInterpolationMode.
/// </summary>
public class CubicInterpolationMode
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CubicInterpolationMode" /> class.
    /// </summary>
    /// <param name="value">The value.</param>
    private CubicInterpolationMode(string value) => Value = value;

    /// <summary>
    ///     Gets the defaut.
    /// </summary>
    /// <value>The defaut.</value>
    public static CubicInterpolationMode Default => new("default");

    /// <summary>
    ///     Gets the monotone.
    /// </summary>
    /// <value>The monotone.</value>
    public static CubicInterpolationMode Monotone => new("monotone");

    /// <summary>
    ///     Gets the value.
    /// </summary>
    /// <value>
    ///     The value.
    /// </value>
    public string Value { get; private set; }
}