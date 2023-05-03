using Microsoft.Extensions.DependencyInjection;

static class Program
{
    [STAThread]
    static void Main() => Application.Run(new Form
    {
        Controls = {
            new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView
            {
                Dock = DockStyle.Fill,
                HostPage = "wwwroot/index.html",
                Services = new ServiceCollection().AddWindowsFormsBlazorWebView().Services.BuildServiceProvider(),
                RootComponents = { new("#app", typeof(BlazorWinFormMicroTemplate.Counter), null) },
            }
        }
    });
}