﻿using FSH.BlazorChartjs.Models.Common.StringEnums;

namespace FSH.BlazorChartjs.Models.Common;

/// <summary>
///     Ticks
/// </summary>
public class Ticks
{
    private CrossAlign? _crossAlign;

    /// <summary>
    ///     Gets or sets the call back.
    /// </summary>
    /// <value>
    ///     The call back.
    /// </value>
    [JsonPropertyName("callback")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CallBack { get; set; }

    /// <summary>
    ///     Gets or sets the color.
    /// </summary>
    /// <value>
    ///     The color.
    /// </value>
    [JsonPropertyName("color")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Color { get; set; }

    /// <summary>
    ///     Gets or sets the cross align.
    /// </summary>
    /// <value>
    ///     The cross align
    /// </value>
    [JsonIgnore]
    public CrossAlign? CrossAlign
    {
        get => _crossAlign;
        set
        {
            _crossAlign      = value;
            CrossAlignString = _crossAlign.Value;
        }
    }

    /// <summary>
    ///     Gets or sets the cross align.
    /// </summary>
    /// <value>
    ///     The cross align.
    /// </value>
    [JsonPropertyName("crossAlign")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CrossAlignString { get; set; }

    /// <summary>
    ///     Gets or sets the maximum rotation.
    /// </summary>
    /// <value>
    ///     The maximum rotation.
    /// </value>
    [JsonPropertyName("maxRotation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MaxRotation { get; set; }

    /// <summary>
    ///     Gets or sets the Maximum number of ticks and gridlines to show.
    /// </summary>
    /// <value>The maximum ticks limit.</value>
    [JsonPropertyName("maxTicksLimit")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MaxTicksLimit { get; set; }

    /// <summary>
    ///     Gets or sets the minimum rotation.
    /// </summary>
    /// <value>
    ///     The minimum rotation.
    /// </value>
    [JsonPropertyName("minRotation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MinRotation { get; set; }

    /// <summary>
    ///     Gets or sets the size of the step.
    ///     If set, the scale ticks will be enumerated by multiple of stepSize, having one tick per increment.
    ///     If not set, the ticks are labelled automatically using the nice numbers algorithm.
    /// </summary>
    /// <value>The size of the step.</value>
    [JsonPropertyName("stepSize")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? StepSize { get; set; }
}