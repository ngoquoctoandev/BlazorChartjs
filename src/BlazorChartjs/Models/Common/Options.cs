using FSH.BlazorChartjs.Models.Common.Callback;
using FSH.BlazorChartjs.Models.Common.Context;

namespace FSH.BlazorChartjs.Models.Common;

/// <summary>
///     Options
/// </summary>
public class Options : IOptions
{
    private bool? _groupXAxis;
    private bool? _groupYAxis;

    /// <summary>
    ///     Gets or sets the animations.
    /// </summary>
    /// <value>
    ///     Enables/disables all animations
    /// </value>
    [JsonPropertyName("animation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Animation { get; set; }

    /// <summary>
    ///     Gets or sets the animations.
    /// </summary>
    /// <value>
    ///     The animations.
    /// </value>
    [JsonPropertyName("animations")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Animations.Animations? Animations { get; set; }

    /// <summary>
    ///     Gets or sets the elements.
    /// </summary>
    /// <value>
    ///     The elements.
    /// </value>
    [JsonPropertyName("elements")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Elements? Elements { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether there are groups for axes.
    /// </summary>
    /// <value><c>true</c> if there are groups for axes (the label should have a semicolumn (;) to divide the label to the name of the gorup); otherwise, <c>false</c>.</value>
    [JsonPropertyName("groupXAxis")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? GroupXAxis
    {
        get => _groupXAxis;
        set
        {
            _groupXAxis = value;

            Scales ??= new Dictionary<string, Axis>();

            if (Scales.Keys.All(k => k != "x"))
                Scales.Add("x", new Axis { Ticks = new Ticks() });
            if (Scales.Keys.All(k => k != "xAxis2"))
                Scales.Add("xAxis2", new Axis
                {
                    Type = "category",
                    Grid = new Grid
                    {
                        DrawOnChartArea = false
                    },
                    Ticks = new Ticks()
                });
        }
    }

    /// <summary>
    ///     Gets or sets a value indicating whether [group y axis].
    /// </summary>
    /// <value><c>null</c> if [group y axis] contains no value, <c>true</c> if [group y axis]; otherwise, <c>false</c>.</value>
    [JsonPropertyName("groupYAxis")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? GroupYAxis
    {
        get => _groupYAxis;
        set
        {
            _groupYAxis = value;

            Scales ??= new Dictionary<string, Axis>();

            if (Scales.Keys.All(k => k != "y"))
                Scales.Add("y", new Axis { Ticks = new Ticks() });
            if (Scales.Keys.All(k => k != "yAxis2"))
                Scales.Add("yAxis2", new Axis
                {
                    Type = "category",
                    Grid = new Grid
                    {
                        DrawOnChartArea = false
                    },
                    Ticks = new Ticks()
                });
        }
    }

    /// <summary>
    ///     Gets a value indicating whether this instance has on hover asynchronous.
    /// </summary>
    /// <value>
    ///     <c>true</c> if this instance has on hover asynchronous; otherwise, <c>false</c>.
    /// </value>
    [JsonInclude]
    [JsonPropertyName("hasOnHoverAsync")]
    public bool HasOnHoverAsync => OnHoverAsync != null;

    /// <summary>
    ///     Gets or sets the height.
    /// </summary>
    /// <value>
    ///     The height.
    /// </value>
    [JsonIgnore]
    public string? Height { get; set; }

    /// <summary>
    ///     Gets or sets the index axis. <seealso cref="Axes" />
    /// </summary>
    /// <value>
    ///     X or Y
    /// </value>
    [JsonPropertyName("indexAxis")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string IndexAxis { get; set; } = Axes.Default;

    /// <summary>
    ///     Gets or sets the interaction.
    /// </summary>
    /// <value>The interaction.</value>
    [JsonPropertyName("interaction")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Interaction? Interaction { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether [maintain aspect ratio].
    /// </summary>
    /// <value>
    ///     <c>true</c> if [maintain aspect ratio]; otherwise, <c>false</c>.
    /// </value>
    [JsonPropertyName("maintainAspectRatio")]
    public bool MaintainAspectRatio { get; set; } = false;

    /// <summary>
    ///     Gets or sets the plugins.
    /// </summary>
    /// <value>
    ///     The plugins.
    /// </value>
    [JsonPropertyName("plugins")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Plugins Plugins { get; set; } = new();

    /// <summary>
    ///     Gets or sets a value indicating whether this <see cref="Options" /> is responsive.
    /// </summary>
    /// <value>
    ///     <c>true</c> if responsive; otherwise, <c>false</c>.
    /// </value>
    [JsonPropertyName("responsive")]
    public bool Responsive { get; set; } = true;

    /// <summary>
    ///     Gets or sets a value indicating if you want to register the DataLabels plugin.
    ///     If the Chart doesn't find the DataLabels script, this plugin won't be added to the chart
    /// </summary>
    /// <value><c>true</c> if you want to register the DataLabels plugin for ChartJs; otherwise, <c>false</c> (by default).</value>
    [JsonPropertyName("registerDataLabels")]
    public bool RegisterDataLabels { get; set; } = false;

    /// <summary>
    ///     Gets or sets the scales.
    /// </summary>
    /// <value>
    ///     The scales.
    /// </value>
    [JsonPropertyName("scales")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, Axis>? Scales { get; set; }

    #region Events

    /// <summary>
    ///     Gets or sets the on chart click.
    /// </summary>
    /// <value>The on chart click.</value>
    [JsonIgnore]
    public Func<CallbackGenericContext, ValueTask>? OnClickAsync { get; set; }

    /// <summary>
    ///     Gets or sets the on hover asynchronous.
    /// </summary>
    /// <value>
    ///     The on hover asynchronous.
    /// </value>
    [JsonIgnore]
    public Func<HoverContext, ValueTask>? OnHoverAsync { get; set; }

    /// <summary>
    ///     Gets or sets the on mouse out asynchronous.
    /// </summary>
    /// <value>
    ///     The on mouse out asynchronous.
    /// </value>
    [JsonIgnore]
    public Func<MouseEventArgs, ValueTask>? OnMouseOutAsync { get; set; }

    #endregion Events
}