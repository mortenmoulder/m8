using Microsoft.AspNetCore.Components;

namespace m8.Web.Pages;

public partial class Index : ComponentBase
{
    public int Age { get; set; }

    protected override void OnInitialized()
    {
        var birth = new DateTime(1994, 3, 11);
        var now = DateTime.Now;

        Age = now.Year - birth.Year;
    }
}
