using Microsoft.AspNetCore.Components;

namespace m8.Web.Components;

public partial class SidebarInfoComponent : ComponentBase
{
    [Parameter] 
    public string CssClass { get; set; } = "";
    [Parameter]
    public string InfoTitle { get; set; }
    [Parameter]
    public string Text { get; set; }
    public List<string> Infos { get; set; }

    protected override void OnInitialized()
    {
        Infos = Text.Split(',', StringSplitOptions.TrimEntries).ToList();
    }
}
