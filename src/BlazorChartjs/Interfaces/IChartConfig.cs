namespace FSH.BlazorChartjs.Interfaces;

public interface IChartConfig
{
    string   CanvasId { get; }
    string   Type     { get; set; }
    IOptions Options  { get; }
}