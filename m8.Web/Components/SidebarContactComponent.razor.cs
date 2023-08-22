using m8.Web.Models;
using Microsoft.AspNetCore.Components;

namespace m8.Web.Components;

public partial class SidebarContactComponent : ComponentBase
{
    public List<SocialProfile> SocialProfiles { get; set; }

    protected override void OnInitialized()
    {
        SocialProfiles = new List<SocialProfile>()
        {
            new SocialProfile { ImagePath = "images/linkedin.png", Url = "https://www.linkedin.com/in/morten-lomholt-m%C3%B8ller-715abb5a", AltText="LinkedIn" },
            new SocialProfile { ImagePath = "images/github.png", Url = "https://github.com/mortenmoulder", AltText = "GitHub" },
            new SocialProfile { ImagePath = "images/stackoverflow.png", Url = "https://stackoverflow.com/users/2098652/mortenmoulder", AltText = "StackOverflow" },
        };
    }
}
