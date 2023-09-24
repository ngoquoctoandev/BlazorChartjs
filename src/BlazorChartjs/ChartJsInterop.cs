namespace FSH.BlazorChartjs;

// This class provides an example of how JavaScript functionality can be wrapped
// in a .NET class for easy consumption. The associated JavaScript module is
// loaded on demand when first needed.
//
// This class can be registered as scoped DI service and then injected into Blazor
// components for use.

public class ChartJsInterop : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> _moduleTask;

    public ChartJsInterop(IJSRuntime jsRuntime)
    {
        _moduleTask = new Lazy<Task<IJSObjectReference>>(() => jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/FSH.BlazorChartjs/blazorchart.js").AsTask());
    }

    public async ValueTask DisposeAsync()
    {
        if (_moduleTask.IsValueCreated)
        {
            var module = await _moduleTask.Value;
            await module.DisposeAsync();
        }
    }

    public async ValueTask Setup(DotNetObjectReference<IChartConfig> dotNetObjectRef, IChartConfig config)
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("chartSetup", config.CanvasId, dotNetObjectRef, config);
    }

    public async ValueTask AddData(string canvasId, List<string> labels, int datasetIndex, List<decimal?> data)
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("addData", canvasId, labels, datasetIndex, data);
    }

    public async ValueTask AddNewDataset<T>(string canvasId, T dataset) where T : class
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("addNewDataset", canvasId, dataset);
    }
}