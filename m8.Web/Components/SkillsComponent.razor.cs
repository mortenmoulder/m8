using m8.Web.Models;
using Microsoft.AspNetCore.Components;

namespace m8.Web.Components;

public partial class SkillsComponent : ComponentBase
{
    public List<Skill> Skills { get; set; }

    protected override void OnInitialized()
    {
        var skills = new List<Skill>
        {
            new Skill(".NET (Blazor, EF, .NET Framework)", 100),
            new Skill("SQL Server", 80),
            new Skill("Docker", 85),
            new Skill("TypeScript / JavaScript", 90),
            new Skill("Angular", 85),
            new Skill("HTML / CSS", 95),
            new Skill("Git", 90),
            new Skill("Scrum & Agile", 80),
            new Skill("Windows & Linux", 80),
            new Skill("NodeJS", 85)
        }
        .OrderByDescending(x => x.Percentage)
        .ToList();

        Skills = skills;
    }
}
