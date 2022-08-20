const string DashboardLocation = @"C:\Program Files\Impulse Dashboard\Impulse.Dashboard.exe";

var pluginDirectory =
    @"C:\Users\lukeb\Documents\Impulse.Plugin.Template\Impulse.Plugin\Impulse.Plugin\bin\Debug\net6.0-windows";

System.Diagnostics.Process.Start(DashboardLocation, $"--plugin {pluginDirectory}");