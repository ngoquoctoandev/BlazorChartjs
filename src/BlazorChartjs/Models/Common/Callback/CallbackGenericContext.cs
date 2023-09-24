namespace FSH.BlazorChartjs.Models.Common.Callback;

/// <summary>
///     Callback Generic Context
/// </summary>
public readonly record struct CallbackGenericContext(int DatasetIndex, int DataIndex, decimal Value)
{
}