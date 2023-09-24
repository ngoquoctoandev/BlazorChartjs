namespace FSH.BlazorChartjs.Models.Common.Context;

/// <summary>
///     Class ClickValue.
/// </summary>
public readonly record struct ClickValue(int DatasetIndex, int ValueIndex, decimal Value)
{
}