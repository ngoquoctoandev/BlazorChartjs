namespace FSH.BlazorChartjs.Models.Common.Context;

/// <summary>
///     Legend Click Context.
/// </summary>
public readonly record struct LegendClickContext(int LegendIndex, string LegendText)
{
}