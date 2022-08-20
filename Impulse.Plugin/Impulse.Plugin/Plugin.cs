using Impulse.Application.Documents;
using Impulse.SharedFramework.Application;
using Impulse.SharedFramework.Plugin;
using Impulse.SharedFramework.Ribbon;

namespace Impulse.Application;

public class Plugin : IPlugin
{
    public IDashboardProvider Dashboard { get; set; }

    public Task Initialize()
    {
        var ribbonService = this.Dashboard.RibbonService;

        ribbonService.AddTab("PluginTemplate.Home", "Home");
        ribbonService.AddGroup("PluginTemplate.Home.GettingStarted", "Group");

        var myButton = new RibbonButtonViewModel()
        {
            Id = "PluginTemplate.Home.GettingStarted.MyButton",
            Title = "Button",
            Callback = this.MyButtonClick,
            EnabledIcon = "pack://application:,,,/Impulse.Dashboard;Component/Icons/Export/DefaultIcon.png",
        };

        ribbonService.AddButton(myButton);

        return Task.CompletedTask;
    }

    public Task OnClose()
    {
        return Task.CompletedTask;
    }

    private void MyButtonClick()
    {
        var documentService = this.Dashboard.DocumentService;
        var document = new MyFirstDocumentViewModel();
        documentService.OpenDocument(document);
    }
}