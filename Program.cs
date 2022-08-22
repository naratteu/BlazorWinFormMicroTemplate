using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

internal static class Program
{
    internal static readonly Form Form = new();
    [STAThread] static void Main() => Application.Run(Form);
    static Program()
    {
        ServiceCollection services = new();
        services.AddWindowsFormsBlazorWebView();
        BlazorWebView webview = new()
        {
            Dock = DockStyle.Fill,
            HostPage = "wwwroot/index.html",
            Services = services.BuildServiceProvider(),
        };
        webview.RootComponents.Add<BlazorWinFormMicroTemplate.Counter>("#app");
        Form.Controls.Add(webview);
    }
}