using m8.Web.Models;
using Microsoft.AspNetCore.Components;

namespace m8.Web.Components;

public partial class WorkExperienceComponent : ComponentBase
{
    [Parameter]
    public string CssClass { get; set; } = "";
    public List<WorkExperience> WorkExperiences { get; set; }

    protected override void OnInitialized()
    {
        WorkExperiences = new List<WorkExperience>()
        {
            new WorkExperience
            {
                Company = "itm8 / IT Relation",
                Location = "Viby J.",
                JobTitle = "Software Developer",
                Description = "Building and maintaining an internal control panel used for collecting data, invoicing, customer relations, products, and more.",
                Technologies = new List<string>
                {
                    ".NET 6 backend",
                    ".NET Blazor frontend",
                    "Microservices",
                    "SQL Server",
                    "Hosted in Azure"
                },
                From = new DateTime(2021, 7, 1),
                To = new DateTime(2023, 10, 1)
            },
            new WorkExperience
            {
                Company = "Co3",
                Location = "Ikast",
                JobTitle = "Software Developer",
                Description = "Working directly with customers and their custom CMS solutions. I developed new features, fixed bugs, and managed DNS, networking, and security updates.",
                Technologies = new List<string>
                {
                    "DynamicWeb",
                    "SQL Server",
                    ".NET"
                },
                From = new DateTime(2020, 12, 1),
                To = new DateTime(2021, 7, 1)
            },
            new WorkExperience
            {
                Company = "team.blue / Zitcom",
                Location = "Skanderborg",
                JobTitle = "Software Developer",
                Description = "Extended and maintained multiple internal systems and control panels, that supported several of the company's brands such as DanDomain, Wannafind, Curanet, and ScanNet.",
                Technologies = new List<string>
                {
                    ".NET Core",
                    "Angular",
                    "TypeScript",
                    "Docker",
                    "Microservices",
                    "SQL Server"
                },
                From = new DateTime(2018, 2, 1),
                To = new DateTime(2020, 12, 1)
            },
            new WorkExperience
            {
                Company = "Iterator IT",
                Location = "Aarhus",
                JobTitle = "Software Developer",
                Description = "Implementing custom Umbraco CMS solutions - backend and frontend. I also participated in mapping out the customers' needs along with a designer.",
                Technologies = new List<string>
                {
                    ".NET",
                    "Umbraco",
                    "SQL Server",
                    "Angular"
                },
                From = new DateTime(2016, 11, 1),
                To = new DateTime(2018, 1, 1)
            },
        };
    }
}
